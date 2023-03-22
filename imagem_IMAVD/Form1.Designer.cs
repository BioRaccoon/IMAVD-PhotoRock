namespace PhotoRock
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.loadBtn = new System.Windows.Forms.Button();
            this.propertiesBtn = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.selectCropAreaBtn = new System.Windows.Forms.Button();
            this.cropBtn = new System.Windows.Forms.Button();
            this.cropTab = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.cropTab.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(552, 426);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseDown);
            this.pictureBox1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseMove);
            // 
            // loadBtn
            // 
            this.loadBtn.Location = new System.Drawing.Point(51, 457);
            this.loadBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.loadBtn.Name = "loadBtn";
            this.loadBtn.Size = new System.Drawing.Size(111, 36);
            this.loadBtn.TabIndex = 1;
            this.loadBtn.Text = "Load";
            this.loadBtn.UseVisualStyleBackColor = true;
            this.loadBtn.Click += new System.EventHandler(this.loadBtn_Click);
            // 
            // propertiesBtn
            // 
            this.propertiesBtn.Location = new System.Drawing.Point(196, 457);
            this.propertiesBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.propertiesBtn.Name = "propertiesBtn";
            this.propertiesBtn.Size = new System.Drawing.Size(111, 36);
            this.propertiesBtn.TabIndex = 2;
            this.propertiesBtn.Text = "Show Details";
            this.propertiesBtn.UseVisualStyleBackColor = true;
            this.propertiesBtn.Click += new System.EventHandler(this.propertiesBtn_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Location = new System.Drawing.Point(443, 474);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(201, 175);
            this.pictureBox2.TabIndex = 4;
            this.pictureBox2.TabStop = false;
            // 
            // selectCropAreaBtn
            // 
            this.selectCropAreaBtn.Location = new System.Drawing.Point(35, 37);
            this.selectCropAreaBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.selectCropAreaBtn.Name = "selectCropAreaBtn";
            this.selectCropAreaBtn.Size = new System.Drawing.Size(111, 36);
            this.selectCropAreaBtn.TabIndex = 5;
            this.selectCropAreaBtn.Text = "Select Area";
            this.selectCropAreaBtn.UseVisualStyleBackColor = true;
            this.selectCropAreaBtn.Click += new System.EventHandler(this.selectCropAreaBtn_Click);
            // 
            // cropBtn
            // 
            this.cropBtn.Location = new System.Drawing.Point(35, 95);
            this.cropBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cropBtn.Name = "cropBtn";
            this.cropBtn.Size = new System.Drawing.Size(111, 36);
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
            this.cropTab.Location = new System.Drawing.Point(571, 27);
            this.cropTab.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cropTab.Name = "cropTab";
            this.cropTab.SelectedIndex = 0;
            this.cropTab.Size = new System.Drawing.Size(479, 411);
            this.cropTab.TabIndex = 7;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.selectCropAreaBtn);
            this.tabPage1.Controls.Add(this.cropBtn);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabPage1.Size = new System.Drawing.Size(471, 382);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "tabPage1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.button3);
            this.tabPage2.Controls.Add(this.button2);
            this.tabPage2.Controls.Add(this.button1);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabPage2.Size = new System.Drawing.Size(471, 382);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            this.tabPage3.Location = new System.Drawing.Point(4, 25);
            this.tabPage3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabPage3.Size = new System.Drawing.Size(471, 382);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "tabPage3";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // tabPage4
            // 
            this.tabPage4.Location = new System.Drawing.Point(4, 25);
            this.tabPage4.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabPage4.Size = new System.Drawing.Size(471, 382);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "tabPage4";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // tabPage5
            // 
            this.tabPage5.Location = new System.Drawing.Point(4, 25);
            this.tabPage5.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabPage5.Size = new System.Drawing.Size(471, 382);
            this.tabPage5.TabIndex = 4;
            this.tabPage5.Text = "tabPage5";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(7, 7);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(450, 50);
            this.button1.TabIndex = 0;
            this.button1.Text = "Rotate";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.rotateBtn_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(7, 64);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(450, 50);
            this.button2.TabIndex = 1;
            this.button2.Text = "Flip Horizontally";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.flipHBtn_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(7, 120);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(450, 50);
            this.button3.TabIndex = 2;
            this.button3.Text = "Flip Vertically";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.flipVBtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1065, 866);
            this.Controls.Add(this.cropTab);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.propertiesBtn);
            this.Controls.Add(this.loadBtn);
            this.Controls.Add(this.pictureBox1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.cropTab.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button loadBtn;
        private System.Windows.Forms.Button propertiesBtn;
        private System.Windows.Forms.PictureBox pictureBox2;
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
    }
}

