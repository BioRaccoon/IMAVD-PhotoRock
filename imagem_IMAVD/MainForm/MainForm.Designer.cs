﻿namespace PhotoRock
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
            this.mainImage = new System.Windows.Forms.PictureBox();
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
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.clearFilter = new System.Windows.Forms.Button();
            this.blueFilter = new System.Windows.Forms.Button();
            this.greenFilter = new System.Windows.Forms.Button();
            this.redFilter = new System.Windows.Forms.Button();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.mainImageCopy = new System.Windows.Forms.PictureBox();
            this.saveImageBtn = new System.Windows.Forms.Button();
            this.undoBtn = new System.Windows.Forms.Button();
            this.zoomComboBox = new System.Windows.Forms.ComboBox();
            this.zoomLbl = new System.Windows.Forms.Label();
            this.chromakey = new System.Windows.Forms.Button();
            this.gcb = new System.Windows.Forms.Button();
            this.invertColor = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.mainImage)).BeginInit();
            this.cropTab.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.tabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mainImageCopy)).BeginInit();
            this.SuspendLayout();
            // 
            // mainImage
            // 
            this.mainImage.Location = new System.Drawing.Point(12, 12);
            this.mainImage.Margin = new System.Windows.Forms.Padding(2);
            this.mainImage.Name = "mainImage";
            this.mainImage.Size = new System.Drawing.Size(550, 550);
            this.mainImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.mainImage.TabIndex = 0;
            this.mainImage.TabStop = false;
            this.mainImage.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseDown);
            this.mainImage.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseMove);
            // 
            // loadBtn
            // 
            this.loadBtn.Location = new System.Drawing.Point(582, 321);
            this.loadBtn.Margin = new System.Windows.Forms.Padding(2);
            this.loadBtn.Name = "loadBtn";
            this.loadBtn.Size = new System.Drawing.Size(172, 41);
            this.loadBtn.TabIndex = 1;
            this.loadBtn.Text = "Load Image";
            this.loadBtn.UseVisualStyleBackColor = true;
            this.loadBtn.Click += new System.EventHandler(this.loadBtn_Click);
            // 
            // propertiesBtn
            // 
            this.propertiesBtn.Location = new System.Drawing.Point(582, 365);
            this.propertiesBtn.Margin = new System.Windows.Forms.Padding(2);
            this.propertiesBtn.Name = "propertiesBtn";
            this.propertiesBtn.Size = new System.Drawing.Size(345, 41);
            this.propertiesBtn.TabIndex = 2;
            this.propertiesBtn.Text = "Show Details";
            this.propertiesBtn.UseVisualStyleBackColor = true;
            this.propertiesBtn.Click += new System.EventHandler(this.propertiesBtn_Click);
            // 
            // selectCropAreaBtn
            // 
            this.selectCropAreaBtn.Location = new System.Drawing.Point(4, 4);
            this.selectCropAreaBtn.Margin = new System.Windows.Forms.Padding(2);
            this.selectCropAreaBtn.Name = "selectCropAreaBtn";
            this.selectCropAreaBtn.Size = new System.Drawing.Size(345, 41);
            this.selectCropAreaBtn.TabIndex = 5;
            this.selectCropAreaBtn.Text = "Select Area";
            this.selectCropAreaBtn.UseVisualStyleBackColor = true;
            this.selectCropAreaBtn.Click += new System.EventHandler(this.selectCropAreaBtn_Click);
            // 
            // cropBtn
            // 
            this.cropBtn.Location = new System.Drawing.Point(4, 45);
            this.cropBtn.Margin = new System.Windows.Forms.Padding(2);
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
            this.cropTab.Location = new System.Drawing.Point(574, 21);
            this.cropTab.Name = "cropTab";
            this.cropTab.SelectedIndex = 0;
            this.cropTab.Size = new System.Drawing.Size(359, 278);
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
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(351, 252);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Crop";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // crop2TrianglesBtn
            // 
            this.crop2TrianglesBtn.Location = new System.Drawing.Point(4, 167);
            this.crop2TrianglesBtn.Margin = new System.Windows.Forms.Padding(2);
            this.crop2TrianglesBtn.Name = "crop2TrianglesBtn";
            this.crop2TrianglesBtn.Size = new System.Drawing.Size(345, 41);
            this.crop2TrianglesBtn.TabIndex = 9;
            this.crop2TrianglesBtn.Text = "Crop (2 Triangles)";
            this.crop2TrianglesBtn.UseVisualStyleBackColor = true;
            this.crop2TrianglesBtn.Click += new System.EventHandler(this.crop2TrianglesBtn_Click);
            // 
            // crop4Btn
            // 
            this.crop4Btn.Location = new System.Drawing.Point(4, 126);
            this.crop4Btn.Margin = new System.Windows.Forms.Padding(2);
            this.crop4Btn.Name = "crop4Btn";
            this.crop4Btn.Size = new System.Drawing.Size(345, 41);
            this.crop4Btn.TabIndex = 8;
            this.crop4Btn.Text = "Crop (4 Squares)";
            this.crop4Btn.UseVisualStyleBackColor = true;
            this.crop4Btn.Click += new System.EventHandler(this.crop4Btn_Click);
            // 
            // crop2Btn
            // 
            this.crop2Btn.Location = new System.Drawing.Point(4, 85);
            this.crop2Btn.Margin = new System.Windows.Forms.Padding(2);
            this.crop2Btn.Name = "crop2Btn";
            this.crop2Btn.Size = new System.Drawing.Size(345, 41);
            this.crop2Btn.TabIndex = 7;
            this.crop2Btn.Text = "Crop (2 Squares)";
            this.crop2Btn.UseVisualStyleBackColor = true;
            this.crop2Btn.Click += new System.EventHandler(this.crop2Btn_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.button5);
            this.tabPage2.Controls.Add(this.button4);
            this.tabPage2.Controls.Add(this.button3);
            this.tabPage2.Controls.Add(this.button2);
            this.tabPage2.Controls.Add(this.button1);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(351, 210);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Rotate & Flip";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(4, 85);
            this.button5.Margin = new System.Windows.Forms.Padding(2);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(345, 41);
            this.button5.TabIndex = 4;
            this.button5.Text = "Rotate 180º";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.rotate180Btn_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(3, 45);
            this.button4.Margin = new System.Windows.Forms.Padding(2);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(345, 41);
            this.button4.TabIndex = 3;
            this.button4.Text = "Rotate 90º";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.rotate90Btn_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(4, 167);
            this.button3.Margin = new System.Windows.Forms.Padding(2);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(345, 41);
            this.button3.TabIndex = 2;
            this.button3.Text = "Flip Vertically";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.flipVBtn_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(4, 126);
            this.button2.Margin = new System.Windows.Forms.Padding(2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(345, 41);
            this.button2.TabIndex = 1;
            this.button2.Text = "Flip Horizontally";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.flipHBtn_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(4, 4);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(345, 41);
            this.button1.TabIndex = 0;
            this.button1.Text = "Rotate 45º";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.rotate45Btn_Click);
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.invertColor);
            this.tabPage3.Controls.Add(this.gcb);
            this.tabPage3.Controls.Add(this.clearFilter);
            this.tabPage3.Controls.Add(this.blueFilter);
            this.tabPage3.Controls.Add(this.greenFilter);
            this.tabPage3.Controls.Add(this.redFilter);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(351, 252);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Adjustments";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // clearFilter
            // 
            this.clearFilter.Location = new System.Drawing.Point(4, 126);
            this.clearFilter.Name = "clearFilter";
            this.clearFilter.Size = new System.Drawing.Size(345, 41);
            this.clearFilter.TabIndex = 3;
            this.clearFilter.Text = "Clear Filter";
            this.clearFilter.UseVisualStyleBackColor = true;
            this.clearFilter.Click += new System.EventHandler(this.clearFilter_Click);
            // 
            // blueFilter
            // 
            this.blueFilter.Location = new System.Drawing.Point(4, 85);
            this.blueFilter.Name = "blueFilter";
            this.blueFilter.Size = new System.Drawing.Size(345, 41);
            this.blueFilter.TabIndex = 2;
            this.blueFilter.Text = "Blue Filter";
            this.blueFilter.UseVisualStyleBackColor = true;
            this.blueFilter.Click += new System.EventHandler(this.blueFilter_Click);
            // 
            // greenFilter
            // 
            this.greenFilter.Location = new System.Drawing.Point(4, 45);
            this.greenFilter.Name = "greenFilter";
            this.greenFilter.Size = new System.Drawing.Size(345, 41);
            this.greenFilter.TabIndex = 1;
            this.greenFilter.Text = "Green Filter";
            this.greenFilter.UseVisualStyleBackColor = true;
            this.greenFilter.Click += new System.EventHandler(this.greenFilter_Click);
            // 
            // redFilter
            // 
            this.redFilter.Location = new System.Drawing.Point(4, 4);
            this.redFilter.Name = "redFilter";
            this.redFilter.Size = new System.Drawing.Size(345, 41);
            this.redFilter.TabIndex = 0;
            this.redFilter.Text = "Red Filter";
            this.redFilter.UseVisualStyleBackColor = true;
            this.redFilter.Click += new System.EventHandler(this.redFilter_Click);
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.chromakey);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(351, 252);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Search Color";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // tabPage5
            // 
            this.tabPage5.Location = new System.Drawing.Point(4, 22);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage5.Size = new System.Drawing.Size(351, 210);
            this.tabPage5.TabIndex = 4;
            this.tabPage5.Text = "Color Picker";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // mainImageCopy
            // 
            this.mainImageCopy.Location = new System.Drawing.Point(12, 12);
            this.mainImageCopy.Name = "mainImageCopy";
            this.mainImageCopy.Size = new System.Drawing.Size(550, 550);
            this.mainImageCopy.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.mainImageCopy.TabIndex = 8;
            this.mainImageCopy.TabStop = false;
            // 
            // saveImageBtn
            // 
            this.saveImageBtn.Location = new System.Drawing.Point(755, 321);
            this.saveImageBtn.Margin = new System.Windows.Forms.Padding(2);
            this.saveImageBtn.Name = "saveImageBtn";
            this.saveImageBtn.Size = new System.Drawing.Size(172, 41);
            this.saveImageBtn.TabIndex = 9;
            this.saveImageBtn.Text = "Save Image";
            this.saveImageBtn.UseVisualStyleBackColor = true;
            this.saveImageBtn.Click += new System.EventHandler(this.saveImageBtn_Click);
            // 
            // undoBtn
            // 
            this.undoBtn.Location = new System.Drawing.Point(582, 409);
            this.undoBtn.Margin = new System.Windows.Forms.Padding(2);
            this.undoBtn.Name = "undoBtn";
            this.undoBtn.Size = new System.Drawing.Size(345, 41);
            this.undoBtn.TabIndex = 10;
            this.undoBtn.Text = "Undo Last Operation";
            this.undoBtn.UseVisualStyleBackColor = true;
            this.undoBtn.Click += new System.EventHandler(this.undoBtn_Click);
            // 
            // zoomComboBox
            // 
            this.zoomComboBox.Enabled = false;
            this.zoomComboBox.FormattingEnabled = true;
            this.zoomComboBox.Location = new System.Drawing.Point(805, 455);
            this.zoomComboBox.Name = "zoomComboBox";
            this.zoomComboBox.Size = new System.Drawing.Size(121, 21);
            this.zoomComboBox.TabIndex = 11;
            this.zoomComboBox.SelectedIndexChanged += new System.EventHandler(this.zoomComboBox_SelectedIndexChanged);
            // 
            // zoomLbl
            // 
            this.zoomLbl.AutoSize = true;
            this.zoomLbl.Location = new System.Drawing.Point(765, 458);
            this.zoomLbl.Name = "zoomLbl";
            this.zoomLbl.Size = new System.Drawing.Size(34, 13);
            this.zoomLbl.TabIndex = 12;
            this.zoomLbl.Text = "Zoom";
            // 
            // chromakey
            // 
            this.chromakey.Location = new System.Drawing.Point(3, 5);
            this.chromakey.Margin = new System.Windows.Forms.Padding(2);
            this.chromakey.Name = "chromakey";
            this.chromakey.Size = new System.Drawing.Size(345, 41);
            this.chromakey.TabIndex = 10;
            this.chromakey.Text = "Chroma Key";
            this.chromakey.UseVisualStyleBackColor = true;
            this.chromakey.Click += new System.EventHandler(this.chromaKey_Click);
            // 
            // gcb
            // 
            this.gcb.Location = new System.Drawing.Point(5, 167);
            this.gcb.Name = "gcb";
            this.gcb.Size = new System.Drawing.Size(345, 41);
            this.gcb.TabIndex = 4;
            this.gcb.Text = "Change gamma/contrast/brightness";
            this.gcb.UseVisualStyleBackColor = true;
            this.gcb.Click += new System.EventHandler(this.gbcBtn_Click);
            // 
            // invertColor
            // 
            this.invertColor.Location = new System.Drawing.Point(5, 208);
            this.invertColor.Name = "invertColor";
            this.invertColor.Size = new System.Drawing.Size(345, 41);
            this.invertColor.TabIndex = 5;
            this.invertColor.Text = "Invert Colors";
            this.invertColor.UseVisualStyleBackColor = true;
            this.invertColor.Click += new System.EventHandler(this.button6_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(962, 585);
            this.Controls.Add(this.zoomLbl);
            this.Controls.Add(this.zoomComboBox);
            this.Controls.Add(this.undoBtn);
            this.Controls.Add(this.saveImageBtn);
            this.Controls.Add(this.mainImageCopy);
            this.Controls.Add(this.cropTab);
            this.Controls.Add(this.propertiesBtn);
            this.Controls.Add(this.loadBtn);
            this.Controls.Add(this.mainImage);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "MainForm";
            this.Text = "PhotoRock";
            ((System.ComponentModel.ISupportInitialize)(this.mainImage)).EndInit();
            this.cropTab.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.tabPage4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.mainImageCopy)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox mainImage;
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
        private System.Windows.Forms.Button redFilter;
        private System.Windows.Forms.Button greenFilter;
        private System.Windows.Forms.Button blueFilter;
        private System.Windows.Forms.Button clearFilter;
        private System.Windows.Forms.PictureBox mainImageCopy;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button saveImageBtn;
        private System.Windows.Forms.Button undoBtn;
        private System.Windows.Forms.ComboBox zoomComboBox;
        private System.Windows.Forms.Label zoomLbl;
        private System.Windows.Forms.Button invertColor;
        private System.Windows.Forms.Button gcb;
        private System.Windows.Forms.Button chromakey;
    }
}
