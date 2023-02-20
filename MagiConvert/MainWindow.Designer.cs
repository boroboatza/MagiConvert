namespace MagiConvert
{
	partial class MainWindow
	{
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private string format;
        private System.ComponentModel.IContainer components = null;
		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.buttonBrowse = new System.Windows.Forms.Button();
			this.InputPath = new System.Windows.Forms.TextBox();
			this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
			this.radioButtonPNG = new System.Windows.Forms.RadioButton();
			this.radioButtonICO = new System.Windows.Forms.RadioButton();
			this.checkBoxTransparent = new System.Windows.Forms.CheckBox();
			this.label1 = new System.Windows.Forms.Label();
			this.radioButtonBMP = new System.Windows.Forms.RadioButton();
			this.groupBoxBMP = new System.Windows.Forms.GroupBox();
			this.labelDone = new System.Windows.Forms.Label();
			this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
			this.radioButtonJPEG = new System.Windows.Forms.RadioButton();
			this.radioButtonDIB = new System.Windows.Forms.RadioButton();
			this.radioButtonJPG = new System.Windows.Forms.RadioButton();
			this.radioButtonTIF = new System.Windows.Forms.RadioButton();
			this.radioButtonTIFF = new System.Windows.Forms.RadioButton();
			this.radioButtonJPE = new System.Windows.Forms.RadioButton();
			this.radioButtonWEBP = new System.Windows.Forms.RadioButton();
			this.buttonConvert = new System.Windows.Forms.Button();
			this.OutputPath = new System.Windows.Forms.Label();
			this.groupBoxBMP.SuspendLayout();
			this.tableLayoutPanel2.SuspendLayout();
			this.SuspendLayout();
			// 
			// buttonBrowse
			// 
			this.buttonBrowse.Font = new System.Drawing.Font("Century", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.buttonBrowse.Location = new System.Drawing.Point(12, 23);
			this.buttonBrowse.Name = "buttonBrowse";
			this.buttonBrowse.Size = new System.Drawing.Size(149, 30);
			this.buttonBrowse.TabIndex = 0;
			this.buttonBrowse.Text = "Open Image";
			this.buttonBrowse.UseVisualStyleBackColor = true;
			this.buttonBrowse.Click += new System.EventHandler(this.ButtonBrowse_Click);
			// 
			// InputPath
			// 
			this.InputPath.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.InputPath.Location = new System.Drawing.Point(165, 25);
			this.InputPath.Name = "InputPath";
			this.InputPath.Size = new System.Drawing.Size(578, 28);
			this.InputPath.TabIndex = 1;
			// 
			// openFileDialog
			// 
			this.openFileDialog.FileName = "openFileDialog";
			// 
			// radioButtonPNG
			// 
			this.radioButtonPNG.AutoSize = true;
			this.radioButtonPNG.Location = new System.Drawing.Point(5, 5);
			this.radioButtonPNG.Name = "radioButtonPNG";
			this.radioButtonPNG.Size = new System.Drawing.Size(74, 25);
			this.radioButtonPNG.TabIndex = 0;
			this.radioButtonPNG.TabStop = true;
			this.radioButtonPNG.Text = "*.png";
			this.radioButtonPNG.UseVisualStyleBackColor = true;
			this.radioButtonPNG.CheckedChanged += new System.EventHandler(this.RadioButtonPNG_CheckedChanged);
			// 
			// radioButtonICO
			// 
			this.radioButtonICO.AutoSize = true;
			this.radioButtonICO.Location = new System.Drawing.Point(5, 38);
			this.radioButtonICO.Name = "radioButtonICO";
			this.radioButtonICO.Size = new System.Drawing.Size(67, 25);
			this.radioButtonICO.TabIndex = 1;
			this.radioButtonICO.TabStop = true;
			this.radioButtonICO.Text = "*.ico";
			this.radioButtonICO.UseVisualStyleBackColor = true;
			this.radioButtonICO.CheckedChanged += new System.EventHandler(this.RadioButtonICO_CheckedChanged);
			// 
			// checkBoxTransparent
			// 
			this.checkBoxTransparent.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.checkBoxTransparent.AutoSize = true;
			this.checkBoxTransparent.Enabled = false;
			this.checkBoxTransparent.Location = new System.Drawing.Point(6, 104);
			this.checkBoxTransparent.Name = "checkBoxTransparent";
			this.checkBoxTransparent.Size = new System.Drawing.Size(228, 25);
			this.checkBoxTransparent.TabIndex = 3;
			this.checkBoxTransparent.Text = "Transparent background";
			this.checkBoxTransparent.UseVisualStyleBackColor = true;
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(0, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(100, 23);
			this.label1.TabIndex = 7;
			// 
			// radioButtonBMP
			// 
			this.radioButtonBMP.AutoSize = true;
			this.radioButtonBMP.Location = new System.Drawing.Point(148, 5);
			this.radioButtonBMP.Name = "radioButtonBMP";
			this.radioButtonBMP.Size = new System.Drawing.Size(79, 25);
			this.radioButtonBMP.TabIndex = 4;
			this.radioButtonBMP.TabStop = true;
			this.radioButtonBMP.Text = "*.bmp";
			this.radioButtonBMP.UseVisualStyleBackColor = true;
			this.radioButtonBMP.CheckedChanged += new System.EventHandler(this.RadioButtonBMP_CheckedChanged);
			// 
			// groupBoxBMP
			// 
			this.groupBoxBMP.Controls.Add(this.checkBoxTransparent);
			this.groupBoxBMP.Controls.Add(this.tableLayoutPanel2);
			this.groupBoxBMP.Font = new System.Drawing.Font("Century", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.groupBoxBMP.Location = new System.Drawing.Point(12, 59);
			this.groupBoxBMP.Name = "groupBoxBMP";
			this.groupBoxBMP.Size = new System.Drawing.Size(731, 132);
			this.groupBoxBMP.TabIndex = 5;
			this.groupBoxBMP.TabStop = false;
			this.groupBoxBMP.Text = "Convert to ...";
			// 
			// labelDone
			// 
			this.labelDone.AutoSize = true;
			this.labelDone.Font = new System.Drawing.Font("Wingdings 3", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelDone.Location = new System.Drawing.Point(12, 227);
			this.labelDone.Name = "labelDone";
			this.labelDone.Size = new System.Drawing.Size(0, 32);
			this.labelDone.TabIndex = 4;
			this.labelDone.Click += new System.EventHandler(this.labelDone_Click);
			// 
			// tableLayoutPanel2
			// 
			this.tableLayoutPanel2.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Outset;
			this.tableLayoutPanel2.ColumnCount = 5;
			this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
			this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
			this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
			this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
			this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
			this.tableLayoutPanel2.Controls.Add(this.radioButtonICO, 0, 1);
			this.tableLayoutPanel2.Controls.Add(this.radioButtonJPEG, 2, 0);
			this.tableLayoutPanel2.Controls.Add(this.radioButtonPNG, 0, 0);
			this.tableLayoutPanel2.Controls.Add(this.radioButtonDIB, 1, 1);
			this.tableLayoutPanel2.Controls.Add(this.radioButtonBMP, 1, 0);
			this.tableLayoutPanel2.Controls.Add(this.radioButtonJPG, 2, 1);
			this.tableLayoutPanel2.Controls.Add(this.radioButtonTIF, 4, 0);
			this.tableLayoutPanel2.Controls.Add(this.radioButtonTIFF, 4, 1);
			this.tableLayoutPanel2.Controls.Add(this.radioButtonJPE, 3, 0);
			this.tableLayoutPanel2.Controls.Add(this.radioButtonWEBP, 3, 1);
			this.tableLayoutPanel2.Location = new System.Drawing.Point(6, 26);
			this.tableLayoutPanel2.Name = "tableLayoutPanel2";
			this.tableLayoutPanel2.RowCount = 2;
			this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.tableLayoutPanel2.Size = new System.Drawing.Size(719, 72);
			this.tableLayoutPanel2.TabIndex = 0;
			// 
			// radioButtonJPEG
			// 
			this.radioButtonJPEG.AutoSize = true;
			this.radioButtonJPEG.Location = new System.Drawing.Point(291, 5);
			this.radioButtonJPEG.Name = "radioButtonJPEG";
			this.radioButtonJPEG.Size = new System.Drawing.Size(78, 25);
			this.radioButtonJPEG.TabIndex = 10;
			this.radioButtonJPEG.TabStop = true;
			this.radioButtonJPEG.Text = "*.jpeg";
			this.radioButtonJPEG.UseVisualStyleBackColor = true;
			this.radioButtonJPEG.CheckedChanged += new System.EventHandler(this.RadioButtonJPEG_CheckedChanged);
			// 
			// radioButtonDIB
			// 
			this.radioButtonDIB.AutoSize = true;
			this.radioButtonDIB.Location = new System.Drawing.Point(148, 38);
			this.radioButtonDIB.Name = "radioButtonDIB";
			this.radioButtonDIB.Size = new System.Drawing.Size(69, 25);
			this.radioButtonDIB.TabIndex = 5;
			this.radioButtonDIB.TabStop = true;
			this.radioButtonDIB.Text = "*.dib";
			this.radioButtonDIB.UseVisualStyleBackColor = true;
			this.radioButtonDIB.CheckedChanged += new System.EventHandler(this.RadioButtonDIB_CheckedChanged);
			// 
			// radioButtonJPG
			// 
			this.radioButtonJPG.AutoSize = true;
			this.radioButtonJPG.Location = new System.Drawing.Point(291, 38);
			this.radioButtonJPG.Name = "radioButtonJPG";
			this.radioButtonJPG.Size = new System.Drawing.Size(69, 25);
			this.radioButtonJPG.TabIndex = 14;
			this.radioButtonJPG.TabStop = true;
			this.radioButtonJPG.Text = "*.jpg";
			this.radioButtonJPG.UseVisualStyleBackColor = true;
			this.radioButtonJPG.CheckedChanged += new System.EventHandler(this.RadioButtonJPG_CheckedChanged);
			// 
			// radioButtonTIF
			// 
			this.radioButtonTIF.AutoSize = true;
			this.radioButtonTIF.Location = new System.Drawing.Point(577, 5);
			this.radioButtonTIF.Name = "radioButtonTIF";
			this.radioButtonTIF.Size = new System.Drawing.Size(63, 25);
			this.radioButtonTIF.TabIndex = 7;
			this.radioButtonTIF.TabStop = true;
			this.radioButtonTIF.Text = "*.tif";
			this.radioButtonTIF.UseVisualStyleBackColor = true;
			this.radioButtonTIF.CheckedChanged += new System.EventHandler(this.RadioButtonTIF_CheckedChanged);
			// 
			// radioButtonTIFF
			// 
			this.radioButtonTIFF.AutoSize = true;
			this.radioButtonTIFF.Location = new System.Drawing.Point(577, 38);
			this.radioButtonTIFF.Name = "radioButtonTIFF";
			this.radioButtonTIFF.Size = new System.Drawing.Size(69, 25);
			this.radioButtonTIFF.TabIndex = 8;
			this.radioButtonTIFF.TabStop = true;
			this.radioButtonTIFF.Text = "*.tiff";
			this.radioButtonTIFF.UseVisualStyleBackColor = true;
			this.radioButtonTIFF.CheckedChanged += new System.EventHandler(this.RadioButtonTIFF_CheckedChanged);
			// 
			// radioButtonJPE
			// 
			this.radioButtonJPE.AutoSize = true;
			this.radioButtonJPE.Location = new System.Drawing.Point(434, 5);
			this.radioButtonJPE.Name = "radioButtonJPE";
			this.radioButtonJPE.Size = new System.Drawing.Size(69, 25);
			this.radioButtonJPE.TabIndex = 11;
			this.radioButtonJPE.TabStop = true;
			this.radioButtonJPE.Text = "*.jpe";
			this.radioButtonJPE.UseVisualStyleBackColor = true;
			this.radioButtonJPE.CheckedChanged += new System.EventHandler(this.RadioButtonJPE_CheckedChanged);
			// 
			// radioButtonWEBP
			// 
			this.radioButtonWEBP.AutoSize = true;
			this.radioButtonWEBP.Location = new System.Drawing.Point(434, 38);
			this.radioButtonWEBP.Name = "radioButtonWEBP";
			this.radioButtonWEBP.Size = new System.Drawing.Size(85, 25);
			this.radioButtonWEBP.TabIndex = 9;
			this.radioButtonWEBP.TabStop = true;
			this.radioButtonWEBP.Text = "*.webp";
			this.radioButtonWEBP.UseVisualStyleBackColor = true;
			this.radioButtonWEBP.CheckedChanged += new System.EventHandler(this.RadioButtonWEBP_CheckedChanged);
			// 
			// buttonConvert
			// 
			this.buttonConvert.Font = new System.Drawing.Font("Century", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.buttonConvert.Location = new System.Drawing.Point(12, 194);
			this.buttonConvert.Name = "buttonConvert";
			this.buttonConvert.Size = new System.Drawing.Size(149, 30);
			this.buttonConvert.TabIndex = 6;
			this.buttonConvert.Text = "Convert";
			this.buttonConvert.UseVisualStyleBackColor = true;
			this.buttonConvert.Click += new System.EventHandler(this.ButtonConvert_Click);
			// 
			// OutputPath
			// 
			this.OutputPath.AutoSize = true;
			this.OutputPath.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.OutputPath.Location = new System.Drawing.Point(167, 198);
			this.OutputPath.Name = "OutputPath";
			this.OutputPath.Size = new System.Drawing.Size(0, 24);
			this.OutputPath.TabIndex = 8;
			// 
			// MainWindow
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(755, 262);
			this.Controls.Add(this.labelDone);
			this.Controls.Add(this.OutputPath);
			this.Controls.Add(this.buttonConvert);
			this.Controls.Add(this.groupBoxBMP);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.InputPath);
			this.Controls.Add(this.buttonBrowse);
			this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.MaximizeBox = false;
			this.Name = "MainWindow";
			this.Text = "MagicConvert";
			this.groupBoxBMP.ResumeLayout(false);
			this.groupBoxBMP.PerformLayout();
			this.tableLayoutPanel2.ResumeLayout(false);
			this.tableLayoutPanel2.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

        #endregion

        private System.Windows.Forms.Button buttonBrowse;
        private System.Windows.Forms.TextBox InputPath;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.CheckBox checkBoxTransparent;
        private System.Windows.Forms.RadioButton radioButtonICO;
        private System.Windows.Forms.RadioButton radioButtonPNG;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton radioButtonBMP;
        private System.Windows.Forms.GroupBox groupBoxBMP;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.RadioButton radioButtonJPEG;
        private System.Windows.Forms.RadioButton radioButtonWEBP;
        private System.Windows.Forms.RadioButton radioButtonTIFF;
        private System.Windows.Forms.RadioButton radioButtonTIF;
        private System.Windows.Forms.RadioButton radioButtonDIB;
        private System.Windows.Forms.RadioButton radioButtonJPE;
        private System.Windows.Forms.RadioButton radioButtonJPG;
        private System.Windows.Forms.Button buttonConvert;
        private System.Windows.Forms.Label OutputPath;
        private System.Windows.Forms.Label labelDone;
    }
}

