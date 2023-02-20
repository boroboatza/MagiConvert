using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using ImageMagick;
using SixLabors.ImageSharp;
using SixLabors.ImageSharp.Processing;

namespace CEngine
{
    public class ConvertEngine
    {   
        public static void Convert(string inputPath, string outputPath, string format, bool transparent)
        {
            string input = inputPath.Substring(inputPath.LastIndexOf('.'));
            if (format == ".png")
            {
                if (input == ".webp")
                {
                    if (transparent)
                    {
                        string tempOutput = outputPath.Remove(outputPath.LastIndexOf('.'));
                        tempOutput += "(temp).png";
                        RegularConvert(inputPath, tempOutput);
                        string tempInput = tempOutput;
                        PngTransparentConvert(tempInput, outputPath);
                        File.Delete(tempInput);
                    }
                    else
                        RegularConvert(inputPath, outputPath);
                }
                else if(input==".png" && transparent)
                {
                    
                    string tempOutput = outputPath.Remove(outputPath.LastIndexOf('.'));
                    tempOutput += "(transparent).png";
                    PngTransparentConvert(outputPath, tempOutput);
                }
                else if(input == ".dib")
                {
                    PngMagicKonvert(inputPath, outputPath);
                }
                else
                {
                    if (transparent)
                        PngTransparentConvert(inputPath, outputPath);
                    else
                        MagiKonvert(inputPath, outputPath, format);
                        //RegularConvert(inputPath, outputPath);
                }
            }
            else if(format ==".ico")
            {
                if (input == ".webp")
                {
                    if (transparent)
                    {
                        string tempOutput = outputPath.Remove(outputPath.LastIndexOf('.'));
                        tempOutput += "(temp).png";
                        RegularConvert(inputPath, tempOutput);
                        string tempInput = tempOutput;
                        tempOutput = outputPath.Remove(outputPath.LastIndexOf('.'));
                        tempOutput += "(temp transparent).png";
                        PngTransparentConvert(tempInput, tempOutput);
                        File.Delete(tempInput);
                        tempInput = tempOutput;
                        IcoConvert(tempInput, outputPath);
                        File.Delete(tempInput);

                    }
                    else
                        IcoConvert(inputPath, outputPath);
                }
                else
                {
                    if (transparent)
                    {
                        if (input != ".dib")
                            IcoTransparentConvert(inputPath, outputPath);
                        else
                            IcoConvert(inputPath, outputPath);
                    }
                    else
                        IcoConvert(inputPath, outputPath);
                }
            }
            else
            {
                MagiKonvert(inputPath, outputPath, format);
            }
                
        }
       
        private static void PngTransparentConvert(string inputPath, string outputPath)
        {


            // load the image from the file
            using (var image = new Bitmap(inputPath))
            {
                // create a new bitmap with the same dimensions as the original image, and with a transparent background
                var transparentImage = new Bitmap(image.Width, image.Height, System.Drawing.Imaging.PixelFormat.Format32bppArgb);

                // make the background transparent
                transparentImage.MakeTransparent();

                // copy the original image to the transparent image, setting the alpha value of background pixels to 0
                using (var graphics = Graphics.FromImage(transparentImage))
                {
                    graphics.DrawImage(image, 0, 0);

                    var data = transparentImage.LockBits(new System.Drawing.Rectangle(0, 0, transparentImage.Width, transparentImage.Height),
                        ImageLockMode.ReadWrite, transparentImage.PixelFormat);
                    var bytesPerPixel = System.Drawing.Bitmap.GetPixelFormatSize(transparentImage.PixelFormat) / 8;
                    var heightInPixels = data.Height;
                    var widthInBytes = data.Width * bytesPerPixel;
                    var currentLine = System.IntPtr.Zero;

                    //set memory address of the first byte of the first row (top-left corner)
                    currentLine = data.Scan0 + (0 * data.Stride);

                    // Set variables to the top-left pixel (which is used as the background color)
                    var blue_0 = System.Runtime.InteropServices.Marshal.ReadByte(currentLine, 0);
                    var green_0 = System.Runtime.InteropServices.Marshal.ReadByte(currentLine, 0 + 1);
                    var red_0 = System.Runtime.InteropServices.Marshal.ReadByte(currentLine, 0 + 2);

                    //reset memory address of the first byte
                    currentLine = System.IntPtr.Zero;

                    //loops over all the pixels in the image
                    for (int y = 0; y < heightInPixels; y++)
                    {
                        currentLine = data.Scan0 + (y * data.Stride);

                        for (int x = 0; x < widthInBytes; x += bytesPerPixel)
                        {
                            var blue = System.Runtime.InteropServices.Marshal.ReadByte(currentLine, x);
                            var green = System.Runtime.InteropServices.Marshal.ReadByte(currentLine, x + 1);
                            var red = System.Runtime.InteropServices.Marshal.ReadByte(currentLine, x + 2);
                            //If the pixel matches the background color,
                            if (red == red_0 && green == green_0 && blue == blue_0) // background pixel
                            {
                                //the alpha value of the pixel is set to 0 to make it transparent.
                                System.Runtime.InteropServices.Marshal.WriteByte(currentLine, x + 3, 0); // Set alpha to 0
                            }
                        }
                    }
                    //release the lock on the bitmap data.
                    //This is necessary to ensure that the image is saved correctly.
                    transparentImage.UnlockBits(data);
                }
                // save the transparent background PNG image to the output path
                transparentImage.Save(outputPath, System.Drawing.Imaging.ImageFormat.Png);
            }
        }
        private static void IcoTransparentConvert(string inputPath, string outputPath)
        {
            outputPath = outputPath.Remove(outputPath.LastIndexOf('.'));
            outputPath += "(temp).png";
            PngTransparentConvert(inputPath, outputPath);
            string tempPath = outputPath;
            outputPath = outputPath.Remove(outputPath.LastIndexOf("(temp).png"));
            outputPath += ".ico";
            IcoConvert(tempPath,outputPath);
            File.Delete(tempPath);

        }

        //* <SIX LABORS>
        private static void RegularConvert(string input, string output)
        {
            using (var image = SixLabors.ImageSharp.Image.Load(input))
            {
                /// { [ONLY FOR PNG OR ICO]
                /// Create a new image with transparent background( NOT WORKING!!! - can you fix it?  )
                /// var outputImage = new Image<Rgba32>(image.Width, image.Height, SixLabors.ImageSharp.Color.Transparent);
                /// }

                // Draw the WebP image onto the new image
                image.Mutate(x => x.DrawImage(image, 1f));

                // Save the image
                image.Save(output);
            }
        }
        //* </six labors>

        //* <MAGICK>
        private static void IcoConvert(string inputPath, string outputPath)
        {
            using (MagickImage image = new MagickImage(inputPath))
            {
                image.Resize(new MagickGeometry(256, 256));
                image.Alpha(AlphaOption.Set);
                image.Format = MagickFormat.Icon;
                image.Write(outputPath);
            }
        }
        private static void PngMagicKonvert(string inputPath, string outputPath)
        {
            using (MagickImage image = new MagickImage(inputPath))
            {
                image.Format = MagickFormat.Png;
                image.Write(outputPath);
            }
        }
        private static void MagiKonvert(string inputPath, string outputPath,string format)
        {
            using (MagickImage image = new MagickImage(inputPath))
            {
                if(format == ".png")                  
                    image.Format = MagickFormat.Png;
                if(format == ".ico")
                {
                    image.Resize(new MagickGeometry(256, 256));
                    image.Alpha(AlphaOption.Set);
                    image.Format = MagickFormat.Icon;
                }
                if(format == ".bmp")
                    image.Format= MagickFormat.Bmp;
                if(format == ".dib")
                    image.Format = MagickFormat.Dib;
                if(format == ".jpeg")
                    image.Format = MagickFormat.Jpeg;
                if(format == ".jpg")
                    image.Format = MagickFormat.Jpg;
                if(format == ".jpe" )
                    image.Format = MagickFormat.Jpe;
                if(format == ".tif")
                    image.Format = MagickFormat.Tif;
                if(format == ".tiff")
                    image.Format = MagickFormat.Tiff;
                if(format == ".webp")
                    image.Format = MagickFormat.WebP;
                image.Write(outputPath);
            }
        }
        //* </magick>
    }
}
