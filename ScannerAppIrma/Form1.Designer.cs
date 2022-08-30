namespace ScannerAppIrma
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panelMenu = new System.Windows.Forms.Panel();
            this.buttonPath = new System.Windows.Forms.Button();
            this.textBoxFileLoc = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.comboBoxFormatImg = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxFileName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBoxSelectScan = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panelLogo = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.buttonScan = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.ScannnedPic = new System.Windows.Forms.PictureBox();
            this.label6 = new System.Windows.Forms.Label();
            this.panelMenu.SuspendLayout();
            this.panelLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ScannnedPic)).BeginInit();
            this.SuspendLayout();
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.panelMenu.Controls.Add(this.buttonPath);
            this.panelMenu.Controls.Add(this.textBoxFileLoc);
            this.panelMenu.Controls.Add(this.label5);
            this.panelMenu.Controls.Add(this.comboBoxFormatImg);
            this.panelMenu.Controls.Add(this.label4);
            this.panelMenu.Controls.Add(this.textBoxFileName);
            this.panelMenu.Controls.Add(this.label3);
            this.panelMenu.Controls.Add(this.comboBoxSelectScan);
            this.panelMenu.Controls.Add(this.label1);
            this.panelMenu.Controls.Add(this.panelLogo);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(293, 657);
            this.panelMenu.TabIndex = 0;
            // 
            // buttonPath
            // 
            this.buttonPath.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.buttonPath.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.buttonPath.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.buttonPath.FlatAppearance.BorderSize = 0;
            this.buttonPath.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonPath.Font = new System.Drawing.Font("Monotype Corsiva", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonPath.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonPath.Location = new System.Drawing.Point(23, 455);
            this.buttonPath.Name = "buttonPath";
            this.buttonPath.Size = new System.Drawing.Size(231, 35);
            this.buttonPath.TabIndex = 8;
            this.buttonPath.Text = "Choose File";
            this.buttonPath.UseVisualStyleBackColor = false;
            this.buttonPath.Click += new System.EventHandler(this.buttonPath_Click);
            // 
            // textBoxFileLoc
            // 
            this.textBoxFileLoc.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.textBoxFileLoc.Font = new System.Drawing.Font("Monotype Corsiva", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxFileLoc.ForeColor = System.Drawing.Color.White;
            this.textBoxFileLoc.Location = new System.Drawing.Point(23, 422);
            this.textBoxFileLoc.Name = "textBoxFileLoc";
            this.textBoxFileLoc.Size = new System.Drawing.Size(231, 30);
            this.textBoxFileLoc.TabIndex = 7;
            this.textBoxFileLoc.TextChanged += new System.EventHandler(this.textBoxFileLoc_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Monotype Corsiva", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.Control;
            this.label5.Location = new System.Drawing.Point(19, 395);
            this.label5.Name = "label5";
            this.label5.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.label5.Size = new System.Drawing.Size(157, 24);
            this.label5.TabIndex = 6;
            this.label5.Text = "Choose the output";
            // 
            // comboBoxFormatImg
            // 
            this.comboBoxFormatImg.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.comboBoxFormatImg.Font = new System.Drawing.Font("Monotype Corsiva", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxFormatImg.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.comboBoxFormatImg.Items.AddRange(new object[] {
            "PNG",
            "JPEG",
            "TIFF"});
            this.comboBoxFormatImg.Location = new System.Drawing.Point(21, 342);
            this.comboBoxFormatImg.Name = "comboBoxFormatImg";
            this.comboBoxFormatImg.Size = new System.Drawing.Size(231, 28);
            this.comboBoxFormatImg.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Monotype Corsiva", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.Control;
            this.label4.Location = new System.Drawing.Point(19, 315);
            this.label4.Name = "label4";
            this.label4.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.label4.Size = new System.Drawing.Size(126, 24);
            this.label4.TabIndex = 4;
            this.label4.Text = "Image Format";
            // 
            // textBoxFileName
            // 
            this.textBoxFileName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.textBoxFileName.Font = new System.Drawing.Font("Monotype Corsiva", 10F);
            this.textBoxFileName.ForeColor = System.Drawing.SystemColors.Window;
            this.textBoxFileName.Location = new System.Drawing.Point(21, 264);
            this.textBoxFileName.Name = "textBoxFileName";
            this.textBoxFileName.Size = new System.Drawing.Size(231, 26);
            this.textBoxFileName.TabIndex = 3;
            this.textBoxFileName.Text = "myscan";
            this.textBoxFileName.TextChanged += new System.EventHandler(this.textBoxFileName_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Monotype Corsiva", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.Control;
            this.label3.Location = new System.Drawing.Point(19, 237);
            this.label3.Name = "label3";
            this.label3.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.label3.Size = new System.Drawing.Size(141, 24);
            this.label3.TabIndex = 2;
            this.label3.Text = "Name Your File";
            // 
            // comboBoxSelectScan
            // 
            this.comboBoxSelectScan.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.comboBoxSelectScan.Font = new System.Drawing.Font("Monotype Corsiva", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxSelectScan.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.comboBoxSelectScan.FormattingEnabled = true;
            this.comboBoxSelectScan.Location = new System.Drawing.Point(20, 192);
            this.comboBoxSelectScan.Name = "comboBoxSelectScan";
            this.comboBoxSelectScan.Size = new System.Drawing.Size(231, 28);
            this.comboBoxSelectScan.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Monotype Corsiva", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(19, 165);
            this.label1.Name = "label1";
            this.label1.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.label1.Size = new System.Drawing.Size(172, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Select Your Scanner";
            // 
            // panelLogo
            // 
            this.panelLogo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(58)))));
            this.panelLogo.Controls.Add(this.pictureBox1);
            this.panelLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelLogo.Location = new System.Drawing.Point(0, 0);
            this.panelLogo.Name = "panelLogo";
            this.panelLogo.Size = new System.Drawing.Size(293, 100);
            this.panelLogo.TabIndex = 0;
            this.panelLogo.Paint += new System.Windows.Forms.PaintEventHandler(this.panelLogo_Paint);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(7, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(264, 90);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(136)))));
            this.panel1.Controls.Add(this.buttonScan);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(293, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(847, 100);
            this.panel1.TabIndex = 1;
            // 
            // buttonScan
            // 
            this.buttonScan.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonScan.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.buttonScan.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.buttonScan.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.buttonScan.FlatAppearance.BorderSize = 0;
            this.buttonScan.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonScan.Font = new System.Drawing.Font("Monotype Corsiva", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonScan.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonScan.Location = new System.Drawing.Point(702, 61);
            this.buttonScan.Name = "buttonScan";
            this.buttonScan.Size = new System.Drawing.Size(141, 35);
            this.buttonScan.TabIndex = 9;
            this.buttonScan.Text = "Scan Now";
            this.buttonScan.UseVisualStyleBackColor = false;
            this.buttonScan.Click += new System.EventHandler(this.buttonScan_Click);
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Monotype Corsiva", 20F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.Control;
            this.label2.Image = ((System.Drawing.Image)(resources.GetObject("label2.Image")));
            this.label2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label2.Location = new System.Drawing.Point(283, 28);
            this.label2.Name = "label2";
            this.label2.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.label2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label2.Size = new System.Drawing.Size(253, 41);
            this.label2.TabIndex = 1;
            this.label2.Text = "   Scan Your Docs";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ScannnedPic
            // 
            this.ScannnedPic.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ScannnedPic.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.ScannnedPic.Location = new System.Drawing.Point(300, 144);
            this.ScannnedPic.Name = "ScannnedPic";
            this.ScannnedPic.Size = new System.Drawing.Size(828, 501);
            this.ScannnedPic.TabIndex = 2;
            this.ScannnedPic.TabStop = false;
            this.ScannnedPic.Click += new System.EventHandler(this.ScannnedPic_Click);
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Dock = System.Windows.Forms.DockStyle.Top;
            this.label6.Font = new System.Drawing.Font("Monotype Corsiva", 20F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label6.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label6.Location = new System.Drawing.Point(293, 100);
            this.label6.Name = "label6";
            this.label6.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.label6.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label6.Size = new System.Drawing.Size(847, 41);
            this.label6.TabIndex = 3;
            this.label6.Text = "   Result Here:";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1140, 657);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.ScannnedPic);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panelMenu);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Scanner";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panelMenu.ResumeLayout(false);
            this.panelMenu.PerformLayout();
            this.panelLogo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ScannnedPic)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Panel panelLogo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBoxSelectScan;
        private System.Windows.Forms.TextBox textBoxFileLoc;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox comboBoxFormatImg;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxFileName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button buttonPath;
        private System.Windows.Forms.PictureBox ScannnedPic;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button buttonScan;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

