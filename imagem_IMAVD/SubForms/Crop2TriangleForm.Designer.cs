﻿namespace imagem_IMAVD
{
    partial class Crop2TriangleForm
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
            this.triangle2Btn = new System.Windows.Forms.Button();
            this.triangle1Btn = new System.Windows.Forms.Button();
            this.saveImagesBtn = new System.Windows.Forms.Button();
            this.triangle2 = new System.Windows.Forms.PictureBox();
            this.triangle1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.triangle2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.triangle1)).BeginInit();
            this.SuspendLayout();
            // 
            // triangle2Btn
            // 
            this.triangle2Btn.Location = new System.Drawing.Point(464, 509);
            this.triangle2Btn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.triangle2Btn.Name = "triangle2Btn";
            this.triangle2Btn.Size = new System.Drawing.Size(450, 41);
            this.triangle2Btn.TabIndex = 9;
            this.triangle2Btn.Text = "Work with Second Image";
            this.triangle2Btn.UseVisualStyleBackColor = true;
            this.triangle2Btn.Click += new System.EventHandler(this.triangle2Btn_Click);
            // 
            // triangle1Btn
            // 
            this.triangle1Btn.Location = new System.Drawing.Point(11, 509);
            this.triangle1Btn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.triangle1Btn.Name = "triangle1Btn";
            this.triangle1Btn.Size = new System.Drawing.Size(450, 41);
            this.triangle1Btn.TabIndex = 8;
            this.triangle1Btn.Text = "Work with First Image";
            this.triangle1Btn.UseVisualStyleBackColor = true;
            this.triangle1Btn.Click += new System.EventHandler(this.triangle1Btn_Click);
            // 
            // saveImagesBtn
            // 
            this.saveImagesBtn.Location = new System.Drawing.Point(10, 464);
            this.saveImagesBtn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.saveImagesBtn.Name = "saveImagesBtn";
            this.saveImagesBtn.Size = new System.Drawing.Size(904, 41);
            this.saveImagesBtn.TabIndex = 7;
            this.saveImagesBtn.Text = "Save Images";
            this.saveImagesBtn.UseVisualStyleBackColor = true;
            this.saveImagesBtn.Click += new System.EventHandler(this.saveImagesBtn_Click);
            // 
            // triangle2
            // 
            this.triangle2.Location = new System.Drawing.Point(464, 10);
            this.triangle2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.triangle2.Name = "triangle2";
            this.triangle2.Size = new System.Drawing.Size(450, 450);
            this.triangle2.TabIndex = 6;
            this.triangle2.TabStop = false;
            // 
            // triangle1
            // 
            this.triangle1.Location = new System.Drawing.Point(10, 10);
            this.triangle1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.triangle1.Name = "triangle1";
            this.triangle1.Size = new System.Drawing.Size(450, 450);
            this.triangle1.TabIndex = 5;
            this.triangle1.TabStop = false;
            // 
            // Crop2TriangleForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(926, 555);
            this.Controls.Add(this.triangle1);
            this.Controls.Add(this.triangle2Btn);
            this.Controls.Add(this.triangle1Btn);
            this.Controls.Add(this.saveImagesBtn);
            this.Controls.Add(this.triangle2);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Crop2TriangleForm";
            this.Text = "Crop2TriangleForm";
            this.Load += new System.EventHandler(this.Crop2TriangleForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.triangle2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.triangle1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button triangle2Btn;
        private System.Windows.Forms.Button triangle1Btn;
        private System.Windows.Forms.Button saveImagesBtn;
        private System.Windows.Forms.PictureBox triangle2;
        private System.Windows.Forms.PictureBox triangle1;
    }
}