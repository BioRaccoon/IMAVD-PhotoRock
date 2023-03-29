namespace PhotoRock
{
    partial class MainForm
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.loadBtn = new System.Windows.Forms.Button();
            this.propertiesBtn = new System.Windows.Forms.Button();
            this.selectCropAreaBtn = new System.Windows.Forms.Button();
            this.cropBtn = new System.Windows.Forms.Button();
            this.cropTab = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.crop2TrianglesBtn = new System.Windows.Forms.Button();
            this.crop4Btn = new System.Windows.Forms.Button();
            this.crop2Btn = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.cropTab.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(9, 10);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(414, 346);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseDown);
            this.pictureBox1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseMove);
            // 
            // loadBtn
            // 
            this.loadBtn.Location = new System.Drawing.Point(47, 371);
            this.loadBtn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.loadBtn.Name = "loadBtn";
            this.loadBtn.Size = new System.Drawing.Size(83, 29);
            this.loadBtn.TabIndex = 1;
            this.loadBtn.Text = "Load";
            this.loadBtn.UseVisualStyleBackColor = true;
            this.loadBtn.Click += new System.EventHandler(this.loadBtn_Click);
            // 
            // propertiesBtn
            // 
            this.propertiesBtn.Location = new System.Drawing.Point(310, 371);
            this.propertiesBtn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.propertiesBtn.Name = "propertiesBtn";
            this.propertiesBtn.Size = new System.Drawing.Size(83, 29);
            this.propertiesBtn.TabIndex = 2;
            this.propertiesBtn.Text = "Show Details";
            this.propertiesBtn.UseVisualStyleBackColor = true;
            this.propertiesBtn.Click += new System.EventHandler(this.propertiesBtn_Click);
            // 
            // selectCropAreaBtn
            // 
            this.selectCropAreaBtn.Location = new System.Drawing.Point(4, 4);
            this.selectCropAreaBtn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.selectCropAreaBtn.Name = "selectCropAreaBtn";
            this.selectCropAreaBtn.Size = new System.Drawing.Size(345, 41);
            this.selectCropAreaBtn.TabIndex = 5;
            this.selectCropAreaBtn.Text = "Select Area";
            this.selectCropAreaBtn.UseVisualStyleBackColor = true;
            this.selectCropAreaBtn.Click += new System.EventHandler(this.selectCropAreaBtn_Click);
            // 
            // cropBtn
            // 
            this.cropBtn.Location = new System.Drawing.Point(3, 48);
            this.cropBtn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cropBtn.Name = "cropBtn";
            this.cropBtn.Size = new System.Drawing.Size(345, 41);
            this.cropBtn.TabIndex = 6;
            this.cropBtn.Text = "Crop";
            this.cropBtn.UseVisualStyleBackColor = true;
            this.cropBtn.Click += new System.EventHandler(this.cropBtn_Click);
            // 
            // cropTab
            // 
            this.cropTab.Controls.Add(this.tabPage1);
            this.cropTab.Controls.Add(this.tabPage2);
            this.cropTab.Controls.Add(this.tabPage3);
            this.cropTab.Controls.Add(this.tabPage4);
            this.cropTab.Controls.Add(this.tabPage5);
            this.cropTab.Location = new System.Drawing.Point(428, 22);
            this.cropTab.Name = "cropTab";
            this.cropTab.SelectedIndex = 0;
            this.cropTab.Size = new System.Drawing.Size(359, 334);
            this.cropTab.TabIndex = 7;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.crop2TrianglesBtn);
            this.tabPage1.Controls.Add(this.crop4Btn);
            this.tabPage1.Controls.Add(this.crop2Btn);
            this.tabPage1.Controls.Add(this.selectCropAreaBtn);
            this.tabPage1.Controls.Add(this.cropBtn);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3, 3, 3, 3);
            this.tabPage1.Size = new System.Drawing.Size(351, 308);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Crop";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // crop2TrianglesBtn
            // 
            this.crop2TrianglesBtn.Location = new System.Drawing.Point(4, 179);
            this.crop2TrianglesBtn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.crop2TrianglesBtn.Name = "crop2TrianglesBtn";
            this.crop2TrianglesBtn.Size = new System.Drawing.Size(345, 41);
            this.crop2TrianglesBtn.TabIndex = 9;
            this.crop2TrianglesBtn.Text = "Crop (2 Triangles)";
            this.crop2TrianglesBtn.UseVisualStyleBackColor = true;
            this.crop2TrianglesBtn.Click += new System.EventHandler(this.crop2TrianglesBtn_Click);
            // 
            // crop4Btn
            // 
            this.crop4Btn.Location = new System.Drawing.Point(4, 135);
            this.crop4Btn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.crop4Btn.Name = "crop4Btn";
            this.crop4Btn.Size = new System.Drawing.Size(345, 41);
            this.crop4Btn.TabIndex = 8;
            this.crop4Btn.Text = "Crop (4 Squares)";
            this.crop4Btn.UseVisualStyleBackColor = true;
            this.crop4Btn.Click += new System.EventHandler(this.crop4Btn_Click);
            // 
            // crop2Btn
            // 
            this.crop2Btn.Location = new System.Drawing.Point(4, 92);
            this.crop2Btn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.crop2Btn.Name = "crop2Btn";
            this.crop2Btn.Size = new System.Drawing.Size(345, 41);
            this.crop2Btn.TabIndex = 7;
            this.crop2Btn.Text = "Crop (2 Squares)";
            this.crop2Btn.UseVisualStyleBackColor = true;
            this.crop2Btn.Click += new System.EventHandler(this.crop2Btn_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.button3);
            this.tabPage2.Controls.Add(this.button2);
            this.tabPage2.Controls.Add(this.button1);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3, 3, 3, 3);
            this.tabPage2.Size = new System.Drawing.Size(351, 308);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Rotate & Flip";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(5, 98);
            this.button3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(338, 41);
            this.button3.TabIndex = 2;
            this.button3.Text = "Flip Vertically";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.flipVBtn_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(5, 52);
            this.button2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(338, 41);
            this.button2.TabIndex = 1;
            this.button2.Text = "Flip Horizontally";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.flipHBtn_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(5, 6);
            this.button1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(338, 41);
            this.button1.TabIndex = 0;
            this.button1.Text = "Rotate";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.rotateBtn_Click);
            // 
            // tabPage3
            // 
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3, 3, 3, 3);
            this.tabPage3.Size = new System.Drawing.Size(351, 308);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Adjustments";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // tabPage4
            // 
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3, 3, 3, 3);
            this.tabPage4.Size = new System.Drawing.Size(351, 308);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Search Color";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // tabPage5
            // 
            this.tabPage5.Location = new System.Drawing.Point(4, 22);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Padding = new System.Windows.Forms.Padding(3, 3, 3, 3);
            this.tabPage5.Size = new System.Drawing.Size(351, 308);
            this.tabPage5.TabIndex = 4;
            this.tabPage5.Text = "tabPage5";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 418);
            this.Controls.Add(this.cropTab);
            this.Controls.Add(this.propertiesBtn);
            this.Controls.Add(this.loadBtn);
            this.Controls.Add(this.pictureBox1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "MainForm";
            this.Text = "PhotoRock";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.cropTab.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button loadBtn;
        private System.Windows.Forms.Button propertiesBtn;
        private System.Windows.Forms.Button selectCropAreaBtn;
        private System.Windows.Forms.Button cropBtn;
        private System.Windows.Forms.TabControl cropTab;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.TabPage tabPage5;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button crop2Btn;
        private System.Windows.Forms.Button crop2TrianglesBtn;
        private System.Windows.Forms.Button crop4Btn;
    }
}

