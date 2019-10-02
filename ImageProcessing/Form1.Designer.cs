namespace ImageProcessing
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
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.label14 = new System.Windows.Forms.Label();
            this.blueColorLabel = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.greenColorLabel = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.redColorLabel = new System.Windows.Forms.Label();
            this.blueColorRadio = new System.Windows.Forms.RadioButton();
            this.greenColorRadio = new System.Windows.Forms.RadioButton();
            this.redColorRadio = new System.Windows.Forms.RadioButton();
            this.allColorsRadio = new System.Windows.Forms.RadioButton();
            this.label9 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label13 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.imageSizeAfterLabel = new System.Windows.Forms.Label();
            this.imageSizeLabel = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.tiffDiffJpegBtn = new System.Windows.Forms.Button();
            this.bmpDiffJpegBtn = new System.Windows.Forms.Button();
            this.bmpDiffTiffBtn = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.saveAsBmpBtn = new System.Windows.Forms.Button();
            this.saveAsTiffBtn = new System.Windows.Forms.Button();
            this.saveAsJpegBtn = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.writingTime = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.encodingTime = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.decodingTime = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.readingTime = new System.Windows.Forms.Label();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.progressBar = new System.Windows.Forms.ToolStripProgressBar();
            this.openFileButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox
            // 
            this.pictureBox.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox.Location = new System.Drawing.Point(126, 319);
            this.pictureBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(1150, 353);
            this.pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox.TabIndex = 0;
            this.pictureBox.TabStop = false;
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(8, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(1293, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "image";
            this.openFileDialog.Filter = "bmp(*.bmp)|*.bmp";
            // 
            // saveFileDialog
            // 
            this.saveFileDialog.FileName = "image";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.panel6);
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(16, 32);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1264, 279);
            this.panel1.TabIndex = 2;
            // 
            // panel6
            // 
            this.panel6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel6.Controls.Add(this.label14);
            this.panel6.Controls.Add(this.blueColorLabel);
            this.panel6.Controls.Add(this.label12);
            this.panel6.Controls.Add(this.greenColorLabel);
            this.panel6.Controls.Add(this.label11);
            this.panel6.Controls.Add(this.redColorLabel);
            this.panel6.Controls.Add(this.blueColorRadio);
            this.panel6.Controls.Add(this.greenColorRadio);
            this.panel6.Controls.Add(this.redColorRadio);
            this.panel6.Controls.Add(this.allColorsRadio);
            this.panel6.Controls.Add(this.label9);
            this.panel6.Location = new System.Drawing.Point(593, 153);
            this.panel6.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(663, 117);
            this.panel6.TabIndex = 10;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label14.Location = new System.Drawing.Point(437, 79);
            this.label14.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(48, 20);
            this.label14.TabIndex = 20;
            this.label14.Text = "Blue:";
            // 
            // blueColorLabel
            // 
            this.blueColorLabel.AutoSize = true;
            this.blueColorLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.blueColorLabel.Location = new System.Drawing.Point(496, 79);
            this.blueColorLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.blueColorLabel.Name = "blueColorLabel";
            this.blueColorLabel.Size = new System.Drawing.Size(18, 20);
            this.blueColorLabel.TabIndex = 21;
            this.blueColorLabel.Text = "0";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label12.Location = new System.Drawing.Point(220, 79);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(60, 20);
            this.label12.TabIndex = 18;
            this.label12.Text = "Green:";
            // 
            // greenColorLabel
            // 
            this.greenColorLabel.AutoSize = true;
            this.greenColorLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.greenColorLabel.Location = new System.Drawing.Point(292, 79);
            this.greenColorLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.greenColorLabel.Name = "greenColorLabel";
            this.greenColorLabel.Size = new System.Drawing.Size(18, 20);
            this.greenColorLabel.TabIndex = 19;
            this.greenColorLabel.Text = "0";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label11.Location = new System.Drawing.Point(4, 79);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(44, 20);
            this.label11.TabIndex = 13;
            this.label11.Text = "Red:";
            // 
            // redColorLabel
            // 
            this.redColorLabel.AutoSize = true;
            this.redColorLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.redColorLabel.Location = new System.Drawing.Point(61, 79);
            this.redColorLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.redColorLabel.Name = "redColorLabel";
            this.redColorLabel.Size = new System.Drawing.Size(18, 20);
            this.redColorLabel.TabIndex = 14;
            this.redColorLabel.Text = "0";
            // 
            // blueColorRadio
            // 
            this.blueColorRadio.AutoSize = true;
            this.blueColorRadio.Location = new System.Drawing.Point(357, 47);
            this.blueColorRadio.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.blueColorRadio.Name = "blueColorRadio";
            this.blueColorRadio.Size = new System.Drawing.Size(57, 21);
            this.blueColorRadio.TabIndex = 17;
            this.blueColorRadio.TabStop = true;
            this.blueColorRadio.Text = "Blue";
            this.blueColorRadio.UseVisualStyleBackColor = true;
            // 
            // greenColorRadio
            // 
            this.greenColorRadio.AutoSize = true;
            this.greenColorRadio.Location = new System.Drawing.Point(277, 47);
            this.greenColorRadio.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.greenColorRadio.Name = "greenColorRadio";
            this.greenColorRadio.Size = new System.Drawing.Size(69, 21);
            this.greenColorRadio.TabIndex = 16;
            this.greenColorRadio.TabStop = true;
            this.greenColorRadio.Text = "Green";
            this.greenColorRadio.UseVisualStyleBackColor = true;
            // 
            // redColorRadio
            // 
            this.redColorRadio.AutoSize = true;
            this.redColorRadio.Location = new System.Drawing.Point(209, 47);
            this.redColorRadio.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.redColorRadio.Name = "redColorRadio";
            this.redColorRadio.Size = new System.Drawing.Size(55, 21);
            this.redColorRadio.TabIndex = 15;
            this.redColorRadio.TabStop = true;
            this.redColorRadio.Text = "Red";
            this.redColorRadio.UseVisualStyleBackColor = true;
            // 
            // allColorsRadio
            // 
            this.allColorsRadio.AutoSize = true;
            this.allColorsRadio.Checked = true;
            this.allColorsRadio.Location = new System.Drawing.Point(117, 47);
            this.allColorsRadio.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.allColorsRadio.Name = "allColorsRadio";
            this.allColorsRadio.Size = new System.Drawing.Size(88, 21);
            this.allColorsRadio.TabIndex = 14;
            this.allColorsRadio.TabStop = true;
            this.allColorsRadio.Text = "All Colors";
            this.allColorsRadio.UseVisualStyleBackColor = true;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label9.Location = new System.Drawing.Point(193, 12);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(164, 20);
            this.label9.TabIndex = 13;
            this.label9.Text = "Difference options";
            // 
            // panel4
            // 
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Controls.Add(this.panel5);
            this.panel4.Controls.Add(this.label8);
            this.panel4.Location = new System.Drawing.Point(8, 4);
            this.panel4.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(577, 113);
            this.panel4.TabIndex = 9;
            // 
            // panel5
            // 
            this.panel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel5.Controls.Add(this.label13);
            this.panel5.Controls.Add(this.label1);
            this.panel5.Controls.Add(this.imageSizeAfterLabel);
            this.panel5.Controls.Add(this.imageSizeLabel);
            this.panel5.Controls.Add(this.label10);
            this.panel5.Location = new System.Drawing.Point(7, 36);
            this.panel5.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(559, 63);
            this.panel5.TabIndex = 17;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label13.Location = new System.Drawing.Point(109, 5);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(46, 20);
            this.label13.TabIndex = 18;
            this.label13.Text = "Size";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(20, 25);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(159, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Before compession:";
            // 
            // imageSizeAfterLabel
            // 
            this.imageSizeAfterLabel.AutoSize = true;
            this.imageSizeAfterLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.imageSizeAfterLabel.Location = new System.Drawing.Point(484, 25);
            this.imageSizeAfterLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.imageSizeAfterLabel.Name = "imageSizeAfterLabel";
            this.imageSizeAfterLabel.Size = new System.Drawing.Size(40, 20);
            this.imageSizeAfterLabel.TabIndex = 16;
            this.imageSizeAfterLabel.Text = "0 kb";
            this.imageSizeAfterLabel.Click += new System.EventHandler(this.imageSizeAfterLabel_Click);
            // 
            // imageSizeLabel
            // 
            this.imageSizeLabel.AutoSize = true;
            this.imageSizeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.imageSizeLabel.Location = new System.Drawing.Point(199, 25);
            this.imageSizeLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.imageSizeLabel.Name = "imageSizeLabel";
            this.imageSizeLabel.Size = new System.Drawing.Size(40, 20);
            this.imageSizeLabel.TabIndex = 1;
            this.imageSizeLabel.Text = "0 kb";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label10.Location = new System.Drawing.Point(308, 25);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(151, 20);
            this.label10.TabIndex = 15;
            this.label10.Text = "After compression:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.Location = new System.Drawing.Point(231, 12);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(96, 20);
            this.label8.TabIndex = 14;
            this.label8.Text = "Image info";
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.tiffDiffJpegBtn);
            this.panel3.Controls.Add(this.bmpDiffJpegBtn);
            this.panel3.Controls.Add(this.bmpDiffTiffBtn);
            this.panel3.Controls.Add(this.label7);
            this.panel3.Controls.Add(this.saveAsBmpBtn);
            this.panel3.Controls.Add(this.saveAsTiffBtn);
            this.panel3.Controls.Add(this.saveAsJpegBtn);
            this.panel3.Location = new System.Drawing.Point(593, 4);
            this.panel3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(663, 141);
            this.panel3.TabIndex = 8;
            // 
            // tiffDiffJpegBtn
            // 
            this.tiffDiffJpegBtn.Enabled = false;
            this.tiffDiffJpegBtn.Location = new System.Drawing.Point(401, 78);
            this.tiffDiffJpegBtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tiffDiffJpegBtn.Name = "tiffDiffJpegBtn";
            this.tiffDiffJpegBtn.Size = new System.Drawing.Size(161, 34);
            this.tiffDiffJpegBtn.TabIndex = 16;
            this.tiffDiffJpegBtn.Text = "TIFF diff JPEG";
            this.tiffDiffJpegBtn.UseVisualStyleBackColor = true;
            this.tiffDiffJpegBtn.Click += new System.EventHandler(this.TiffDiffJpegBtn_Click);
            // 
            // bmpDiffJpegBtn
            // 
            this.bmpDiffJpegBtn.Enabled = false;
            this.bmpDiffJpegBtn.Location = new System.Drawing.Point(211, 78);
            this.bmpDiffJpegBtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.bmpDiffJpegBtn.Name = "bmpDiffJpegBtn";
            this.bmpDiffJpegBtn.Size = new System.Drawing.Size(161, 34);
            this.bmpDiffJpegBtn.TabIndex = 15;
            this.bmpDiffJpegBtn.Text = "BMP diff JPEG";
            this.bmpDiffJpegBtn.UseVisualStyleBackColor = true;
            this.bmpDiffJpegBtn.Click += new System.EventHandler(this.BmpDiffJpegBtn_Click);
            // 
            // bmpDiffTiffBtn
            // 
            this.bmpDiffTiffBtn.Enabled = false;
            this.bmpDiffTiffBtn.Location = new System.Drawing.Point(7, 78);
            this.bmpDiffTiffBtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.bmpDiffTiffBtn.Name = "bmpDiffTiffBtn";
            this.bmpDiffTiffBtn.Size = new System.Drawing.Size(161, 34);
            this.bmpDiffTiffBtn.TabIndex = 14;
            this.bmpDiffTiffBtn.Text = "BMP diff TIFF";
            this.bmpDiffTiffBtn.UseVisualStyleBackColor = true;
            this.bmpDiffTiffBtn.Click += new System.EventHandler(this.BmpDiffTiffBtn_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(223, 12);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(101, 20);
            this.label7.TabIndex = 13;
            this.label7.Text = "Operations";
            // 
            // saveAsBmpBtn
            // 
            this.saveAsBmpBtn.Enabled = false;
            this.saveAsBmpBtn.Location = new System.Drawing.Point(5, 36);
            this.saveAsBmpBtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.saveAsBmpBtn.Name = "saveAsBmpBtn";
            this.saveAsBmpBtn.Size = new System.Drawing.Size(161, 34);
            this.saveAsBmpBtn.TabIndex = 2;
            this.saveAsBmpBtn.Text = "Save As BMP (RLE)";
            this.saveAsBmpBtn.UseVisualStyleBackColor = true;
            this.saveAsBmpBtn.Click += new System.EventHandler(this.SaveAsBmpBtn_Click);
            // 
            // saveAsTiffBtn
            // 
            this.saveAsTiffBtn.Enabled = false;
            this.saveAsTiffBtn.Location = new System.Drawing.Point(211, 36);
            this.saveAsTiffBtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.saveAsTiffBtn.Name = "saveAsTiffBtn";
            this.saveAsTiffBtn.Size = new System.Drawing.Size(161, 34);
            this.saveAsTiffBtn.TabIndex = 3;
            this.saveAsTiffBtn.Text = "Save As TIFF (LZW)";
            this.saveAsTiffBtn.UseVisualStyleBackColor = true;
            this.saveAsTiffBtn.Click += new System.EventHandler(this.SaveAsTiffBtn_Click);
            // 
            // saveAsJpegBtn
            // 
            this.saveAsJpegBtn.Enabled = false;
            this.saveAsJpegBtn.Location = new System.Drawing.Point(401, 36);
            this.saveAsJpegBtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.saveAsJpegBtn.Name = "saveAsJpegBtn";
            this.saveAsJpegBtn.Size = new System.Drawing.Size(161, 34);
            this.saveAsJpegBtn.TabIndex = 4;
            this.saveAsJpegBtn.Text = "Save As JPEG";
            this.saveAsJpegBtn.UseVisualStyleBackColor = true;
            this.saveAsJpegBtn.Click += new System.EventHandler(this.SaveAsJpegBtn_Click);
            // 
            // panel2
            // 
            this.panel2.AccessibleDescription = "";
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.writingTime);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.encodingTime);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.decodingTime);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.readingTime);
            this.panel2.Location = new System.Drawing.Point(8, 125);
            this.panel2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(577, 145);
            this.panel2.TabIndex = 7;
            this.panel2.Tag = "";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(193, 14);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(143, 20);
            this.label5.TabIndex = 8;
            this.label5.Text = "Operations time";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(316, 52);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 20);
            this.label2.TabIndex = 11;
            this.label2.Text = "Writing:";
            // 
            // writingTime
            // 
            this.writingTime.AutoSize = true;
            this.writingTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.writingTime.Location = new System.Drawing.Point(391, 52);
            this.writingTime.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.writingTime.Name = "writingTime";
            this.writingTime.Size = new System.Drawing.Size(46, 20);
            this.writingTime.TabIndex = 12;
            this.writingTime.Text = "0 ms";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(316, 107);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 20);
            this.label4.TabIndex = 9;
            this.label4.Text = "Encoding:";
            // 
            // encodingTime
            // 
            this.encodingTime.AutoSize = true;
            this.encodingTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.encodingTime.Location = new System.Drawing.Point(407, 107);
            this.encodingTime.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.encodingTime.Name = "encodingTime";
            this.encodingTime.Size = new System.Drawing.Size(46, 20);
            this.encodingTime.TabIndex = 10;
            this.encodingTime.Text = "0 ms";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(4, 107);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(85, 20);
            this.label6.TabIndex = 7;
            this.label6.Text = "Decoding:";
            // 
            // decodingTime
            // 
            this.decodingTime.AutoSize = true;
            this.decodingTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.decodingTime.Location = new System.Drawing.Point(97, 107);
            this.decodingTime.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.decodingTime.Name = "decodingTime";
            this.decodingTime.Size = new System.Drawing.Size(46, 20);
            this.decodingTime.TabIndex = 8;
            this.decodingTime.Text = "0 ms";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(3, 52);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Reading:";
            // 
            // readingTime
            // 
            this.readingTime.AutoSize = true;
            this.readingTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.readingTime.Location = new System.Drawing.Point(95, 52);
            this.readingTime.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.readingTime.Name = "readingTime";
            this.readingTime.Size = new System.Drawing.Size(46, 20);
            this.readingTime.TabIndex = 6;
            this.readingTime.Text = "0 ms";
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.progressBar});
            this.statusStrip1.Location = new System.Drawing.Point(0, 679);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Padding = new System.Windows.Forms.Padding(1, 0, 19, 0);
            this.statusStrip1.Size = new System.Drawing.Size(1293, 26);
            this.statusStrip1.TabIndex = 3;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // progressBar
            // 
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(1267, 20);
            // 
            // openFileButton
            // 
            this.openFileButton.Location = new System.Drawing.Point(16, 331);
            this.openFileButton.Name = "openFileButton";
            this.openFileButton.Size = new System.Drawing.Size(75, 28);
            this.openFileButton.TabIndex = 4;
            this.openFileButton.Text = "Open image";
            this.openFileButton.UseVisualStyleBackColor = true;
            this.openFileButton.Click += new System.EventHandler(this.openFileButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1293, 705);
            this.Controls.Add(this.openFileButton);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "Image Processing";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button saveAsJpegBtn;
        private System.Windows.Forms.Button saveAsTiffBtn;
        private System.Windows.Forms.Button saveAsBmpBtn;
        private System.Windows.Forms.Label readingTime;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label imageSizeLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label writingTime;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label encodingTime;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label decodingTime;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label imageSizeAfterLabel;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripProgressBar progressBar;
        private System.Windows.Forms.Button tiffDiffJpegBtn;
        private System.Windows.Forms.Button bmpDiffJpegBtn;
        private System.Windows.Forms.Button bmpDiffTiffBtn;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label blueColorLabel;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label greenColorLabel;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label redColorLabel;
        private System.Windows.Forms.RadioButton blueColorRadio;
        private System.Windows.Forms.RadioButton greenColorRadio;
        private System.Windows.Forms.RadioButton redColorRadio;
        private System.Windows.Forms.RadioButton allColorsRadio;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button openFileButton;
    }
}

