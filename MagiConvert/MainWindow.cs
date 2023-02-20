using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CEngine;
namespace MagiConvert
{
	public partial class MainWindow : Form
	{
		public MainWindow()
		{
			InitializeComponent();
		}

        private void ButtonBrowse_Click(object sender, EventArgs e)
        {
            labelDone.Text = "";
            openFileDialog = new OpenFileDialog
            {

                Filter = File.ReadAllText("Filter.flt")

            };
            if(openFileDialog.ShowDialog() == DialogResult.OK ) 
            {
                InputPath.Text = openFileDialog.FileName;
            }
            string outputString = InputPath.Text;
            if (outputString != "")
                outputString = outputString.Remove(outputString.LastIndexOf('.'));
            outputString += format;
            OutputPath.Text = outputString;

        }
        private void ButtonConvert_Click(object sender, EventArgs e)
        {
            ConvertEngine.Convert(InputPath.Text, OutputPath.Text, format, checkBoxTransparent.Checked);
            labelDone.ForeColor= Color.Green;
            labelDone.Text = "\u2713" + "Done !";
        }

        private void RadioButtonBMP_CheckedChanged(object sender, EventArgs e)
        {
            labelDone.Text = "";
            checkBoxTransparent.Checked = false;
            checkBoxTransparent.Enabled = false;
            format = ".bmp";
            GetFormat();
        }

        private void RadioButtonDIB_CheckedChanged(object sender, EventArgs e)
        {
            labelDone.Text = "";
            checkBoxTransparent.Checked = false;
            checkBoxTransparent.Enabled = false;
            format = ".dib";
            GetFormat();
        }

        private void RadioButtonICO_CheckedChanged(object sender, EventArgs e)
        {
            labelDone.Text = "";
            checkBoxTransparent.Enabled = true;
            format = ".ico";
            GetFormat();
        }

        private void RadioButtonJPE_CheckedChanged(object sender, EventArgs e)
        {
            labelDone.Text = "";
            checkBoxTransparent.Checked = false;
            checkBoxTransparent.Enabled = false;
            format = ".jpe";
            GetFormat();
        }

        private void RadioButtonJPEG_CheckedChanged(object sender, EventArgs e)
        {
            labelDone.Text = "";
            checkBoxTransparent.Checked = false;
            checkBoxTransparent.Enabled = false;
            format = ".jpeg";
            GetFormat();
        }

        private void RadioButtonJPG_CheckedChanged(object sender, EventArgs e)
        {
            labelDone.Text = "";
            checkBoxTransparent.Checked = false;
            checkBoxTransparent.Enabled = false;
            format = ".jpg";
            GetFormat();
        }

        private void RadioButtonTIF_CheckedChanged(object sender, EventArgs e)
        {
            labelDone.Text = "";
            checkBoxTransparent.Checked = false;
            checkBoxTransparent.Enabled = false;
            format = ".tif";
            GetFormat();
        }
        private void RadioButtonPNG_CheckedChanged(object sender, EventArgs e)
        {
            labelDone.Text = "";
            checkBoxTransparent.Enabled = true;
            format = ".png";
            GetFormat();
        }
        private void RadioButtonTIFF_CheckedChanged(object sender, EventArgs e)
        {
            labelDone.Text = "";
            checkBoxTransparent.Checked = false;
            checkBoxTransparent.Enabled = false;
            format = ".tiff";
            GetFormat();
        }

        private void RadioButtonWEBP_CheckedChanged(object sender, EventArgs e)
        {
            labelDone.Text = "";
            checkBoxTransparent.Checked = false;
            checkBoxTransparent.Enabled = false;
            format = ".webp";
            GetFormat();
        }
        private void GetFormat()
        {
            string outputString = InputPath.Text;
            if (outputString != "")
                outputString = outputString.Remove(outputString.LastIndexOf('.'));
            outputString += format;
            OutputPath.Text = outputString;
        }
    }
}
