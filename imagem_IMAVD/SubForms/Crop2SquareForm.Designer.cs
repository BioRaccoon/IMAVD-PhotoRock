namespace imagem_IMAVD
{
    partial class Crop2SquareForm
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
            this.square1 = new System.Windows.Forms.PictureBox();
            this.square2 = new System.Windows.Forms.PictureBox();
            this.saveImagesBtn = new System.Windows.Forms.Button();
            this.square1Btn = new System.Windows.Forms.Button();
            this.square2Btn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.square1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.square2)).BeginInit();
            this.SuspendLayout();
            // 
            // square1
            // 
            this.square1.Location = new System.Drawing.Point(10, 10);
            this.square1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.square1.Name = "square1";
            this.square1.Size = new System.Drawing.Size(450, 225);
            this.square1.TabIndex = 0;
            this.square1.TabStop = false;
            this.square1.Click += new System.EventHandler(this.square1_Click);
            // 
            // square2
            // 
            this.square2.Location = new System.Drawing.Point(10, 238);
            this.square2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.square2.Name = "square2";
            this.square2.Size = new System.Drawing.Size(450, 225);
            this.square2.TabIndex = 1;
            this.square2.TabStop = false;
            this.square2.Click += new System.EventHandler(this.square2_Click);
            // 
            // saveImagesBtn
            // 
            this.saveImagesBtn.Location = new System.Drawing.Point(10, 466);
            this.saveImagesBtn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.saveImagesBtn.Name = "saveImagesBtn";
            this.saveImagesBtn.Size = new System.Drawing.Size(450, 41);
            this.saveImagesBtn.TabIndex = 2;
            this.saveImagesBtn.Text = "Save Images";
            this.saveImagesBtn.UseVisualStyleBackColor = true;
            this.saveImagesBtn.Click += new System.EventHandler(this.saveImagesBtn_Click);
            // 
            // square1Btn
            // 
            this.square1Btn.Location = new System.Drawing.Point(10, 510);
            this.square1Btn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.square1Btn.Name = "square1Btn";
            this.square1Btn.Size = new System.Drawing.Size(222, 41);
            this.square1Btn.TabIndex = 3;
            this.square1Btn.Text = "Work with First Image";
            this.square1Btn.UseVisualStyleBackColor = true;
            this.square1Btn.Click += new System.EventHandler(this.square1Btn_Click);
            // 
            // square2Btn
            // 
            this.square2Btn.Location = new System.Drawing.Point(238, 510);
            this.square2Btn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.square2Btn.Name = "square2Btn";
            this.square2Btn.Size = new System.Drawing.Size(222, 41);
            this.square2Btn.TabIndex = 4;
            this.square2Btn.Text = "Work with Second Image";
            this.square2Btn.UseVisualStyleBackColor = true;
            this.square2Btn.Click += new System.EventHandler(this.square2Btn_Click);
            // 
            // Crop2SquareForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(471, 555);
            this.Controls.Add(this.square2Btn);
            this.Controls.Add(this.square1Btn);
            this.Controls.Add(this.saveImagesBtn);
            this.Controls.Add(this.square2);
            this.Controls.Add(this.square1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Crop2SquareForm";
            this.Text = "Crop2Form";
            this.Load += new System.EventHandler(this.Crop2SquareForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.square1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.square2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox square1;
        private System.Windows.Forms.PictureBox square2;
        private System.Windows.Forms.Button saveImagesBtn;
        private System.Windows.Forms.Button square1Btn;
        private System.Windows.Forms.Button square2Btn;
    }
}