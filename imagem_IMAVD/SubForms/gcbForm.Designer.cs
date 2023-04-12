namespace imagem_IMAVD.SubForms
{
    partial class gcbForm
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
            this.brightness = new System.Windows.Forms.TrackBar();
            this.contrast = new System.Windows.Forms.TrackBar();
            this.gamma = new System.Windows.Forms.TrackBar();
            this.applyBtn = new System.Windows.Forms.Button();
            this.cancelBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.brightnessValueLabel = new System.Windows.Forms.Label();
            this.contrastValueLabel = new System.Windows.Forms.Label();
            this.gammaValueLabel = new System.Windows.Forms.Label();
            this.adjustedImagePicBox = new System.Windows.Forms.PictureBox();
            this.previewBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.brightness)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.contrast)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gamma)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.adjustedImagePicBox)).BeginInit();
            this.SuspendLayout();
            // 
            // brightness
            // 
            this.brightness.Location = new System.Drawing.Point(17, 60);
            this.brightness.Maximum = 255;
            this.brightness.Minimum = -255;
            this.brightness.Name = "brightness";
            this.brightness.Size = new System.Drawing.Size(104, 45);
            this.brightness.TabIndex = 0;
            this.brightness.TickStyle = System.Windows.Forms.TickStyle.None;
            this.brightness.ValueChanged += new System.EventHandler(this.brightness_ValueChanged);
            // 
            // contrast
            // 
            this.contrast.Location = new System.Drawing.Point(12, 173);
            this.contrast.Maximum = 100;
            this.contrast.Minimum = -100;
            this.contrast.Name = "contrast";
            this.contrast.Size = new System.Drawing.Size(104, 45);
            this.contrast.TabIndex = 1;
            this.contrast.TickStyle = System.Windows.Forms.TickStyle.None;
            this.contrast.ValueChanged += new System.EventHandler(this.contrast_ValueChanged);
            // 
            // gamma
            // 
            this.gamma.Location = new System.Drawing.Point(14, 290);
            this.gamma.Maximum = 25;
            this.gamma.Minimum = 1;
            this.gamma.Name = "gamma";
            this.gamma.Size = new System.Drawing.Size(104, 45);
            this.gamma.TabIndex = 2;
            this.gamma.TickStyle = System.Windows.Forms.TickStyle.None;
            this.gamma.Value = 5;
            this.gamma.ValueChanged += new System.EventHandler(this.gamma_ValueChanged);
            // 
            // applyBtn
            // 
            this.applyBtn.Location = new System.Drawing.Point(382, 338);
            this.applyBtn.Name = "applyBtn";
            this.applyBtn.Size = new System.Drawing.Size(84, 30);
            this.applyBtn.TabIndex = 3;
            this.applyBtn.Text = "Apply";
            this.applyBtn.UseVisualStyleBackColor = true;
            this.applyBtn.Click += new System.EventHandler(this.applyBtn_Click);
            // 
            // cancelBtn
            // 
            this.cancelBtn.Location = new System.Drawing.Point(219, 338);
            this.cancelBtn.Name = "cancelBtn";
            this.cancelBtn.Size = new System.Drawing.Size(84, 30);
            this.cancelBtn.TabIndex = 4;
            this.cancelBtn.Text = "Cancel";
            this.cancelBtn.UseVisualStyleBackColor = true;
            this.cancelBtn.Click += new System.EventHandler(this.cancelBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(41, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Brightness";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(41, 152);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Contrast";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(44, 271);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Gamma";
            // 
            // brightnessValueLabel
            // 
            this.brightnessValueLabel.AutoSize = true;
            this.brightnessValueLabel.Location = new System.Drawing.Point(56, 83);
            this.brightnessValueLabel.Name = "brightnessValueLabel";
            this.brightnessValueLabel.Size = new System.Drawing.Size(13, 13);
            this.brightnessValueLabel.TabIndex = 8;
            this.brightnessValueLabel.Text = "0";
            // 
            // contrastValueLabel
            // 
            this.contrastValueLabel.AutoSize = true;
            this.contrastValueLabel.Location = new System.Drawing.Point(51, 196);
            this.contrastValueLabel.Name = "contrastValueLabel";
            this.contrastValueLabel.Size = new System.Drawing.Size(13, 13);
            this.contrastValueLabel.TabIndex = 9;
            this.contrastValueLabel.Text = "0";
            // 
            // gammaValueLabel
            // 
            this.gammaValueLabel.AutoSize = true;
            this.gammaValueLabel.Location = new System.Drawing.Point(53, 312);
            this.gammaValueLabel.Name = "gammaValueLabel";
            this.gammaValueLabel.Size = new System.Drawing.Size(13, 13);
            this.gammaValueLabel.TabIndex = 10;
            this.gammaValueLabel.Text = "0";
            // 
            // adjustedImagePicBox
            // 
            this.adjustedImagePicBox.Location = new System.Drawing.Point(138, 12);
            this.adjustedImagePicBox.Name = "adjustedImagePicBox";
            this.adjustedImagePicBox.Size = new System.Drawing.Size(428, 313);
            this.adjustedImagePicBox.TabIndex = 11;
            this.adjustedImagePicBox.TabStop = false;
            // 
            // previewBtn
            // 
            this.previewBtn.Location = new System.Drawing.Point(28, 356);
            this.previewBtn.Name = "previewBtn";
            this.previewBtn.Size = new System.Drawing.Size(84, 30);
            this.previewBtn.TabIndex = 12;
            this.previewBtn.Text = "Preview";
            this.previewBtn.UseVisualStyleBackColor = true;
            this.previewBtn.Click += new System.EventHandler(this.previewBtn_Click);
            // 
            // gcbForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(578, 398);
            this.Controls.Add(this.previewBtn);
            this.Controls.Add(this.adjustedImagePicBox);
            this.Controls.Add(this.gammaValueLabel);
            this.Controls.Add(this.contrastValueLabel);
            this.Controls.Add(this.brightnessValueLabel);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cancelBtn);
            this.Controls.Add(this.applyBtn);
            this.Controls.Add(this.gamma);
            this.Controls.Add(this.contrast);
            this.Controls.Add(this.brightness);
            this.Name = "gcbForm";
            this.Text = "gcbForm";
            ((System.ComponentModel.ISupportInitialize)(this.brightness)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.contrast)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gamma)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.adjustedImagePicBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TrackBar brightness;
        private System.Windows.Forms.TrackBar contrast;
        private System.Windows.Forms.TrackBar gamma;
        private System.Windows.Forms.Button applyBtn;
        private System.Windows.Forms.Button cancelBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label brightnessValueLabel;
        private System.Windows.Forms.Label contrastValueLabel;
        private System.Windows.Forms.Label gammaValueLabel;
        private System.Windows.Forms.PictureBox adjustedImagePicBox;
        private System.Windows.Forms.Button previewBtn;
    }
}