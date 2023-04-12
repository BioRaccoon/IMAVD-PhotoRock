namespace imagem_IMAVD
{
    partial class Crop4SquareForm
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
            this.square2Btn = new System.Windows.Forms.Button();
            this.square1Btn = new System.Windows.Forms.Button();
            this.saveImagesBtn = new System.Windows.Forms.Button();
            this.square1 = new System.Windows.Forms.PictureBox();
            this.square2 = new System.Windows.Forms.PictureBox();
            this.square3 = new System.Windows.Forms.PictureBox();
            this.square4 = new System.Windows.Forms.PictureBox();
            this.square3Btn = new System.Windows.Forms.Button();
            this.square4Btn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.square1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.square2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.square3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.square4)).BeginInit();
            this.SuspendLayout();
            // 
            // square2Btn
            // 
            this.square2Btn.Location = new System.Drawing.Point(239, 513);
            this.square2Btn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.square2Btn.Name = "square2Btn";
            this.square2Btn.Size = new System.Drawing.Size(225, 41);
            this.square2Btn.TabIndex = 9;
            this.square2Btn.Text = "Work with Second Image";
            this.square2Btn.UseVisualStyleBackColor = true;
            this.square2Btn.Click += new System.EventHandler(this.square2Btn_Click);
            // 
            // square1Btn
            // 
            this.square1Btn.Location = new System.Drawing.Point(10, 513);
            this.square1Btn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.square1Btn.Name = "square1Btn";
            this.square1Btn.Size = new System.Drawing.Size(225, 41);
            this.square1Btn.TabIndex = 8;
            this.square1Btn.Text = "Work with First Image";
            this.square1Btn.UseVisualStyleBackColor = true;
            this.square1Btn.Click += new System.EventHandler(this.square1Btn_Click);
            // 
            // saveImagesBtn
            // 
            this.saveImagesBtn.Location = new System.Drawing.Point(10, 469);
            this.saveImagesBtn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.saveImagesBtn.Name = "saveImagesBtn";
            this.saveImagesBtn.Size = new System.Drawing.Size(455, 41);
            this.saveImagesBtn.TabIndex = 7;
            this.saveImagesBtn.Text = "Save Images";
            this.saveImagesBtn.UseVisualStyleBackColor = true;
            this.saveImagesBtn.Click += new System.EventHandler(this.saveImagesBtn_Click);
            // 
            // square1
            // 
            this.square1.Location = new System.Drawing.Point(10, 10);
            this.square1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.square1.Name = "square1";
            this.square1.Size = new System.Drawing.Size(225, 225);
            this.square1.TabIndex = 5;
            this.square1.TabStop = false;
            // 
            // square2
            // 
            this.square2.Location = new System.Drawing.Point(240, 10);
            this.square2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.square2.Name = "square2";
            this.square2.Size = new System.Drawing.Size(225, 225);
            this.square2.TabIndex = 10;
            this.square2.TabStop = false;
            // 
            // square3
            // 
            this.square3.Location = new System.Drawing.Point(10, 240);
            this.square3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.square3.Name = "square3";
            this.square3.Size = new System.Drawing.Size(225, 225);
            this.square3.TabIndex = 11;
            this.square3.TabStop = false;
            // 
            // square4
            // 
            this.square4.Location = new System.Drawing.Point(240, 240);
            this.square4.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.square4.Name = "square4";
            this.square4.Size = new System.Drawing.Size(225, 225);
            this.square4.TabIndex = 12;
            this.square4.TabStop = false;
            this.square4.Click += new System.EventHandler(this.square4_Click);
            // 
            // square3Btn
            // 
            this.square3Btn.Location = new System.Drawing.Point(10, 558);
            this.square3Btn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.square3Btn.Name = "square3Btn";
            this.square3Btn.Size = new System.Drawing.Size(225, 41);
            this.square3Btn.TabIndex = 13;
            this.square3Btn.Text = "Work with Third Image";
            this.square3Btn.UseVisualStyleBackColor = true;
            this.square3Btn.Click += new System.EventHandler(this.square3Btn_Click);
            // 
            // square4Btn
            // 
            this.square4Btn.Location = new System.Drawing.Point(239, 558);
            this.square4Btn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.square4Btn.Name = "square4Btn";
            this.square4Btn.Size = new System.Drawing.Size(225, 41);
            this.square4Btn.TabIndex = 14;
            this.square4Btn.Text = "Work with Fourth Image";
            this.square4Btn.UseVisualStyleBackColor = true;
            this.square4Btn.Click += new System.EventHandler(this.square4Btn_Click);
            // 
            // Crop4SquareForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(477, 604);
            this.Controls.Add(this.square4Btn);
            this.Controls.Add(this.square3Btn);
            this.Controls.Add(this.square4);
            this.Controls.Add(this.square3);
            this.Controls.Add(this.square2);
            this.Controls.Add(this.square2Btn);
            this.Controls.Add(this.square1Btn);
            this.Controls.Add(this.saveImagesBtn);
            this.Controls.Add(this.square1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Crop4SquareForm";
            this.Text = "Crop4Form";
            this.Load += new System.EventHandler(this.Crop4SquareForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.square1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.square2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.square3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.square4)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button square2Btn;
        private System.Windows.Forms.Button square1Btn;
        private System.Windows.Forms.Button saveImagesBtn;
        private System.Windows.Forms.PictureBox square1;
        private System.Windows.Forms.PictureBox square2;
        private System.Windows.Forms.PictureBox square3;
        private System.Windows.Forms.PictureBox square4;
        private System.Windows.Forms.Button square3Btn;
        private System.Windows.Forms.Button square4Btn;
    }
}