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
            this.mainImage = new System.Windows.Forms.PictureBox();
            this.loadImageBtn = new System.Windows.Forms.Button();
            this.imageDetailsBtn = new System.Windows.Forms.Button();
            this.selectCropAreaBtn = new System.Windows.Forms.Button();
            this.cropBtn = new System.Windows.Forms.Button();
            this.cropTab = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.crop2TrianglesBtn = new System.Windows.Forms.Button();
            this.crop4Btn = new System.Windows.Forms.Button();
            this.crop2Btn = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.rotate180Btn = new System.Windows.Forms.Button();
            this.rotate90Btn = new System.Windows.Forms.Button();
            this.flipVerticalBtn = new System.Windows.Forms.Button();
            this.flipHorizontalBtn = new System.Windows.Forms.Button();
            this.rotate45Btn = new System.Windows.Forms.Button();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.invertColor = new System.Windows.Forms.Button();
            this.gcb = new System.Windows.Forms.Button();
            this.clearFilter = new System.Windows.Forms.Button();
            this.blueFilter = new System.Windows.Forms.Button();
            this.greenFilter = new System.Windows.Forms.Button();
            this.redFilter = new System.Windows.Forms.Button();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.selectedColorBox = new System.Windows.Forms.Label();
            this.colorMousePickerBtn = new System.Windows.Forms.Button();
            this.colorPixelsNumberLabel = new System.Windows.Forms.Label();
            this.searchColorBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.colorPalettePickerBtn = new System.Windows.Forms.Button();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.resize_btn = new System.Windows.Forms.Button();
            this.chromakey = new System.Windows.Forms.Button();
            this.mainImageCopy = new System.Windows.Forms.PictureBox();
            this.saveImageBtn = new System.Windows.Forms.Button();
            this.undoBtn = new System.Windows.Forms.Button();
            this.zoomComboBox = new System.Windows.Forms.ComboBox();
            this.zoomLbl = new System.Windows.Forms.Label();
            this.addElement_btn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.mainImage)).BeginInit();
            this.cropTab.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.tabPage5.SuspendLayout();
            this.tabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mainImageCopy)).BeginInit();
            this.SuspendLayout();
            // 
            // mainImage
            // 
            this.mainImage.Location = new System.Drawing.Point(10, 10);
            this.mainImage.Margin = new System.Windows.Forms.Padding(2);
            this.mainImage.Name = "mainImage";
            this.mainImage.Size = new System.Drawing.Size(450, 450);
            this.mainImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.mainImage.TabIndex = 0;
            this.mainImage.TabStop = false;
            this.mainImage.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseDown);
            this.mainImage.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseMove);
            // 
            // loadImageBtn
            // 
            this.loadImageBtn.Location = new System.Drawing.Point(473, 252);
            this.loadImageBtn.Margin = new System.Windows.Forms.Padding(2);
            this.loadImageBtn.Name = "loadImageBtn";
            this.loadImageBtn.Size = new System.Drawing.Size(172, 40);
            this.loadImageBtn.TabIndex = 1;
            this.loadImageBtn.Text = "Load Image";
            this.loadImageBtn.UseVisualStyleBackColor = true;
            this.loadImageBtn.Click += new System.EventHandler(this.loadBtn_Click);
            // 
            // imageDetailsBtn
            // 
            this.imageDetailsBtn.Location = new System.Drawing.Point(473, 296);
            this.imageDetailsBtn.Margin = new System.Windows.Forms.Padding(2);
            this.imageDetailsBtn.Name = "imageDetailsBtn";
            this.imageDetailsBtn.Size = new System.Drawing.Size(345, 40);
            this.imageDetailsBtn.TabIndex = 2;
            this.imageDetailsBtn.Text = "Show Details";
            this.imageDetailsBtn.UseVisualStyleBackColor = true;
            this.imageDetailsBtn.Click += new System.EventHandler(this.propertiesBtn_Click);
            // 
            // selectCropAreaBtn
            // 
            this.selectCropAreaBtn.Location = new System.Drawing.Point(4, 4);
            this.selectCropAreaBtn.Margin = new System.Windows.Forms.Padding(2);
            this.selectCropAreaBtn.Name = "selectCropAreaBtn";
            this.selectCropAreaBtn.Size = new System.Drawing.Size(345, 40);
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
            this.cropBtn.Size = new System.Drawing.Size(345, 40);
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
            this.cropTab.Controls.Add(this.tabPage5);
            this.cropTab.Controls.Add(this.tabPage4);
            this.cropTab.Location = new System.Drawing.Point(466, 12);
            this.cropTab.Name = "cropTab";
            this.cropTab.SelectedIndex = 0;
            this.cropTab.Size = new System.Drawing.Size(359, 236);
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
            this.tabPage1.Size = new System.Drawing.Size(351, 210);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Crop";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // crop2TrianglesBtn
            // 
            this.crop2TrianglesBtn.Location = new System.Drawing.Point(4, 167);
            this.crop2TrianglesBtn.Margin = new System.Windows.Forms.Padding(2);
            this.crop2TrianglesBtn.Name = "crop2TrianglesBtn";
            this.crop2TrianglesBtn.Size = new System.Drawing.Size(345, 40);
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
            this.crop4Btn.Size = new System.Drawing.Size(345, 40);
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
            this.crop2Btn.Size = new System.Drawing.Size(345, 40);
            this.crop2Btn.TabIndex = 7;
            this.crop2Btn.Text = "Crop (2 Squares)";
            this.crop2Btn.UseVisualStyleBackColor = true;
            this.crop2Btn.Click += new System.EventHandler(this.crop2Btn_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.rotate180Btn);
            this.tabPage2.Controls.Add(this.rotate90Btn);
            this.tabPage2.Controls.Add(this.flipVerticalBtn);
            this.tabPage2.Controls.Add(this.flipHorizontalBtn);
            this.tabPage2.Controls.Add(this.rotate45Btn);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(351, 210);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Rotate & Flip";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // rotate180Btn
            // 
            this.rotate180Btn.Location = new System.Drawing.Point(4, 85);
            this.rotate180Btn.Margin = new System.Windows.Forms.Padding(2);
            this.rotate180Btn.Name = "rotate180Btn";
            this.rotate180Btn.Size = new System.Drawing.Size(345, 40);
            this.rotate180Btn.TabIndex = 4;
            this.rotate180Btn.Text = "Rotate 180º";
            this.rotate180Btn.UseVisualStyleBackColor = true;
            this.rotate180Btn.Click += new System.EventHandler(this.rotate180Btn_Click);
            // 
            // rotate90Btn
            // 
            this.rotate90Btn.Location = new System.Drawing.Point(3, 45);
            this.rotate90Btn.Margin = new System.Windows.Forms.Padding(2);
            this.rotate90Btn.Name = "rotate90Btn";
            this.rotate90Btn.Size = new System.Drawing.Size(345, 40);
            this.rotate90Btn.TabIndex = 3;
            this.rotate90Btn.Text = "Rotate 90º";
            this.rotate90Btn.UseVisualStyleBackColor = true;
            this.rotate90Btn.Click += new System.EventHandler(this.rotate90Btn_Click);
            // 
            // flipVerticalBtn
            // 
            this.flipVerticalBtn.Location = new System.Drawing.Point(4, 167);
            this.flipVerticalBtn.Margin = new System.Windows.Forms.Padding(2);
            this.flipVerticalBtn.Name = "flipVerticalBtn";
            this.flipVerticalBtn.Size = new System.Drawing.Size(345, 40);
            this.flipVerticalBtn.TabIndex = 2;
            this.flipVerticalBtn.Text = "Flip Vertically";
            this.flipVerticalBtn.UseVisualStyleBackColor = true;
            this.flipVerticalBtn.Click += new System.EventHandler(this.flipVBtn_Click);
            // 
            // flipHorizontalBtn
            // 
            this.flipHorizontalBtn.Location = new System.Drawing.Point(4, 126);
            this.flipHorizontalBtn.Margin = new System.Windows.Forms.Padding(2);
            this.flipHorizontalBtn.Name = "flipHorizontalBtn";
            this.flipHorizontalBtn.Size = new System.Drawing.Size(345, 40);
            this.flipHorizontalBtn.TabIndex = 1;
            this.flipHorizontalBtn.Text = "Flip Horizontally";
            this.flipHorizontalBtn.UseVisualStyleBackColor = true;
            this.flipHorizontalBtn.Click += new System.EventHandler(this.flipHBtn_Click);
            // 
            // rotate45Btn
            // 
            this.rotate45Btn.Location = new System.Drawing.Point(4, 4);
            this.rotate45Btn.Margin = new System.Windows.Forms.Padding(2);
            this.rotate45Btn.Name = "rotate45Btn";
            this.rotate45Btn.Size = new System.Drawing.Size(345, 40);
            this.rotate45Btn.TabIndex = 0;
            this.rotate45Btn.Text = "Rotate 45º";
            this.rotate45Btn.UseVisualStyleBackColor = true;
            this.rotate45Btn.Click += new System.EventHandler(this.rotate45Btn_Click);
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
            this.tabPage3.Size = new System.Drawing.Size(351, 210);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Adjustments";
            this.tabPage3.UseVisualStyleBackColor = true;
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
            // gcb
            // 
            this.gcb.Location = new System.Drawing.Point(5, 167);
            this.gcb.Name = "gcb";
            this.gcb.Size = new System.Drawing.Size(345, 40);
            this.gcb.TabIndex = 4;
            this.gcb.Text = "Change gamma/contrast/brightness";
            this.gcb.UseVisualStyleBackColor = true;
            this.gcb.Click += new System.EventHandler(this.gbcBtn_Click);
            // 
            // clearFilter
            // 
            this.clearFilter.Location = new System.Drawing.Point(4, 126);
            this.clearFilter.Name = "clearFilter";
            this.clearFilter.Size = new System.Drawing.Size(345, 40);
            this.clearFilter.TabIndex = 3;
            this.clearFilter.Text = "Clear Filter";
            this.clearFilter.UseVisualStyleBackColor = true;
            this.clearFilter.Click += new System.EventHandler(this.clearFilter_Click);
            // 
            // blueFilter
            // 
            this.blueFilter.Location = new System.Drawing.Point(4, 85);
            this.blueFilter.Name = "blueFilter";
            this.blueFilter.Size = new System.Drawing.Size(345, 40);
            this.blueFilter.TabIndex = 2;
            this.blueFilter.Text = "Blue Filter";
            this.blueFilter.UseVisualStyleBackColor = true;
            this.blueFilter.Click += new System.EventHandler(this.blueFilter_Click);
            // 
            // greenFilter
            // 
            this.greenFilter.Location = new System.Drawing.Point(4, 45);
            this.greenFilter.Name = "greenFilter";
            this.greenFilter.Size = new System.Drawing.Size(345, 40);
            this.greenFilter.TabIndex = 1;
            this.greenFilter.Text = "Green Filter";
            this.greenFilter.UseVisualStyleBackColor = true;
            this.greenFilter.Click += new System.EventHandler(this.greenFilter_Click);
            // 
            // redFilter
            // 
            this.redFilter.Location = new System.Drawing.Point(4, 4);
            this.redFilter.Name = "redFilter";
            this.redFilter.Size = new System.Drawing.Size(345, 40);
            this.redFilter.TabIndex = 0;
            this.redFilter.Text = "Red Filter";
            this.redFilter.UseVisualStyleBackColor = true;
            this.redFilter.Click += new System.EventHandler(this.redFilter_Click);
            // 
            // tabPage5
            // 
            this.tabPage5.Controls.Add(this.selectedColorBox);
            this.tabPage5.Controls.Add(this.colorMousePickerBtn);
            this.tabPage5.Controls.Add(this.colorPixelsNumberLabel);
            this.tabPage5.Controls.Add(this.searchColorBtn);
            this.tabPage5.Controls.Add(this.label1);
            this.tabPage5.Controls.Add(this.colorPalettePickerBtn);
            this.tabPage5.Location = new System.Drawing.Point(4, 22);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage5.Size = new System.Drawing.Size(351, 210);
            this.tabPage5.TabIndex = 4;
            this.tabPage5.Text = "Color Picker";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // selectedColorBox
            // 
            this.selectedColorBox.Location = new System.Drawing.Point(86, 92);
            this.selectedColorBox.Name = "selectedColorBox";
            this.selectedColorBox.Size = new System.Drawing.Size(255, 20);
            this.selectedColorBox.TabIndex = 13;
            this.selectedColorBox.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // colorMousePickerBtn
            // 
            this.colorMousePickerBtn.Location = new System.Drawing.Point(5, 45);
            this.colorMousePickerBtn.Name = "colorMousePickerBtn";
            this.colorMousePickerBtn.Size = new System.Drawing.Size(340, 40);
            this.colorMousePickerBtn.TabIndex = 9;
            this.colorMousePickerBtn.Text = "Pick Color (With Mouse)";
            this.colorMousePickerBtn.UseVisualStyleBackColor = true;
            this.colorMousePickerBtn.Click += new System.EventHandler(this.colorMousePickerBtn_Click);
            // 
            // colorPixelsNumberLabel
            // 
            this.colorPixelsNumberLabel.AutoSize = true;
            this.colorPixelsNumberLabel.Location = new System.Drawing.Point(55, 166);
            this.colorPixelsNumberLabel.Name = "colorPixelsNumberLabel";
            this.colorPixelsNumberLabel.Size = new System.Drawing.Size(237, 26);
            this.colorPixelsNumberLabel.TabIndex = 8;
            this.colorPixelsNumberLabel.Text = "Color Found! \r\nThe image contains 0 pixels of the selected color";
            this.colorPixelsNumberLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // searchColorBtn
            // 
            this.searchColorBtn.Location = new System.Drawing.Point(5, 116);
            this.searchColorBtn.Name = "searchColorBtn";
            this.searchColorBtn.Size = new System.Drawing.Size(340, 40);
            this.searchColorBtn.TabIndex = 7;
            this.searchColorBtn.Text = "Search Color";
            this.searchColorBtn.UseVisualStyleBackColor = true;
            this.searchColorBtn.Click += new System.EventHandler(this.searchColorBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(5, 96);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Selected Color:";
            // 
            // colorPalettePickerBtn
            // 
            this.colorPalettePickerBtn.Location = new System.Drawing.Point(5, 5);
            this.colorPalettePickerBtn.Name = "colorPalettePickerBtn";
            this.colorPalettePickerBtn.Size = new System.Drawing.Size(340, 40);
            this.colorPalettePickerBtn.TabIndex = 4;
            this.colorPalettePickerBtn.Text = "Pick Color (With Palette)";
            this.colorPalettePickerBtn.UseVisualStyleBackColor = true;
            this.colorPalettePickerBtn.Click += new System.EventHandler(this.colorPalettePickerBtn_Click);
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.addElement_btn);
            this.tabPage4.Controls.Add(this.resize_btn);
            this.tabPage4.Controls.Add(this.chromakey);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(351, 210);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Extra";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // resize_btn
            // 
            this.resize_btn.Location = new System.Drawing.Point(3, 51);
            this.resize_btn.Name = "resize_btn";
            this.resize_btn.Size = new System.Drawing.Size(345, 40);
            this.resize_btn.TabIndex = 11;
            this.resize_btn.Text = "Resize";
            this.resize_btn.UseVisualStyleBackColor = true;
            this.resize_btn.Click += new System.EventHandler(this.resize_btn_Click);
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
            // mainImageCopy
            // 
            this.mainImageCopy.Location = new System.Drawing.Point(10, 10);
            this.mainImageCopy.Name = "mainImageCopy";
            this.mainImageCopy.Size = new System.Drawing.Size(450, 450);
            this.mainImageCopy.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.mainImageCopy.TabIndex = 8;
            this.mainImageCopy.TabStop = false;
            // 
            // saveImageBtn
            // 
            this.saveImageBtn.Location = new System.Drawing.Point(646, 252);
            this.saveImageBtn.Margin = new System.Windows.Forms.Padding(2);
            this.saveImageBtn.Name = "saveImageBtn";
            this.saveImageBtn.Size = new System.Drawing.Size(172, 40);
            this.saveImageBtn.TabIndex = 9;
            this.saveImageBtn.Text = "Save Image";
            this.saveImageBtn.UseVisualStyleBackColor = true;
            this.saveImageBtn.Click += new System.EventHandler(this.saveImageBtn_Click);
            // 
            // undoBtn
            // 
            this.undoBtn.Location = new System.Drawing.Point(473, 340);
            this.undoBtn.Margin = new System.Windows.Forms.Padding(2);
            this.undoBtn.Name = "undoBtn";
            this.undoBtn.Size = new System.Drawing.Size(345, 40);
            this.undoBtn.TabIndex = 10;
            this.undoBtn.Text = "Undo Last Operation";
            this.undoBtn.UseVisualStyleBackColor = true;
            this.undoBtn.Click += new System.EventHandler(this.undoBtn_Click);
            // 
            // zoomComboBox
            // 
            this.zoomComboBox.Enabled = false;
            this.zoomComboBox.FormattingEnabled = true;
            this.zoomComboBox.Location = new System.Drawing.Point(518, 385);
            this.zoomComboBox.Name = "zoomComboBox";
            this.zoomComboBox.Size = new System.Drawing.Size(300, 21);
            this.zoomComboBox.TabIndex = 11;
            this.zoomComboBox.SelectedIndexChanged += new System.EventHandler(this.zoomComboBox_SelectedIndexChanged);
            // 
            // zoomLbl
            // 
            this.zoomLbl.AutoSize = true;
            this.zoomLbl.Location = new System.Drawing.Point(478, 389);
            this.zoomLbl.Name = "zoomLbl";
            this.zoomLbl.Size = new System.Drawing.Size(37, 13);
            this.zoomLbl.TabIndex = 12;
            this.zoomLbl.Text = "Zoom:";
            // 
            // addElement_btn
            // 
            this.addElement_btn.Location = new System.Drawing.Point(3, 97);
            this.addElement_btn.Name = "addElement_btn";
            this.addElement_btn.Size = new System.Drawing.Size(342, 40);
            this.addElement_btn.TabIndex = 12;
            this.addElement_btn.Text = "Add Element";
            this.addElement_btn.UseVisualStyleBackColor = true;
            this.addElement_btn.Click += new System.EventHandler(this.addElement_btn_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(840, 470);
            this.Controls.Add(this.zoomLbl);
            this.Controls.Add(this.undoBtn);
            this.Controls.Add(this.saveImageBtn);
            this.Controls.Add(this.zoomComboBox);
            this.Controls.Add(this.mainImageCopy);
            this.Controls.Add(this.cropTab);
            this.Controls.Add(this.imageDetailsBtn);
            this.Controls.Add(this.loadImageBtn);
            this.Controls.Add(this.mainImage);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "MainForm";
            this.Text = "PhotoRock";
            ((System.ComponentModel.ISupportInitialize)(this.mainImage)).EndInit();
            this.cropTab.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.tabPage5.ResumeLayout(false);
            this.tabPage5.PerformLayout();
            this.tabPage4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.mainImageCopy)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox mainImage;
        private System.Windows.Forms.Button loadImageBtn;
        private System.Windows.Forms.Button imageDetailsBtn;
        private System.Windows.Forms.Button selectCropAreaBtn;
        private System.Windows.Forms.Button cropBtn;
        private System.Windows.Forms.TabControl cropTab;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.TabPage tabPage5;
        private System.Windows.Forms.Button rotate45Btn;
        private System.Windows.Forms.Button flipVerticalBtn;
        private System.Windows.Forms.Button flipHorizontalBtn;
        private System.Windows.Forms.Button crop2Btn;
        private System.Windows.Forms.Button crop2TrianglesBtn;
        private System.Windows.Forms.Button crop4Btn;
        private System.Windows.Forms.Button redFilter;
        private System.Windows.Forms.Button greenFilter;
        private System.Windows.Forms.Button blueFilter;
        private System.Windows.Forms.Button clearFilter;
        private System.Windows.Forms.PictureBox mainImageCopy;
        private System.Windows.Forms.Button rotate180Btn;
        private System.Windows.Forms.Button rotate90Btn;
        private System.Windows.Forms.Button saveImageBtn;
        private System.Windows.Forms.Button undoBtn;
        private System.Windows.Forms.ComboBox zoomComboBox;
        private System.Windows.Forms.Label zoomLbl;
        private System.Windows.Forms.Button invertColor;
        private System.Windows.Forms.Button gcb;
        private System.Windows.Forms.Button chromakey;
        private System.Windows.Forms.Button colorPalettePickerBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button searchColorBtn;
        private System.Windows.Forms.Label colorPixelsNumberLabel;
        private System.Windows.Forms.Button colorMousePickerBtn;
        private System.Windows.Forms.Label selectedColorBox;
        private System.Windows.Forms.Button resize_btn;
        private System.Windows.Forms.Button addElement_btn;
    }
}
