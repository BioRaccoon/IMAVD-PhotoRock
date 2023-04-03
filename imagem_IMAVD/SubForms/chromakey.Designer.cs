namespace imagem_IMAVD.SubForms
{
    partial class chromakey
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
            this.finalPic = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.cancelBtn = new System.Windows.Forms.Button();
            this.applyBtn = new System.Windows.Forms.Button();
            this.toReplacePic = new System.Windows.Forms.PictureBox();
            this.wChromaKeyPic = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.finalPic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.toReplacePic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.wChromaKeyPic)).BeginInit();
            this.SuspendLayout();
            // 
            // finalPic
            // 
            this.finalPic.Location = new System.Drawing.Point(12, 12);
            this.finalPic.Name = "finalPic";
            this.finalPic.Size = new System.Drawing.Size(441, 426);
            this.finalPic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.finalPic.TabIndex = 0;
            this.finalPic.TabStop = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(498, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(130, 42);
            this.button1.TabIndex = 1;
            this.button1.Text = "Load Image W/ Chroma Key Color";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(657, 12);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(130, 42);
            this.button2.TabIndex = 2;
            this.button2.Text = "Load Image to Insert";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // cancelBtn
            // 
            this.cancelBtn.Location = new System.Drawing.Point(515, 408);
            this.cancelBtn.Name = "cancelBtn";
            this.cancelBtn.Size = new System.Drawing.Size(84, 30);
            this.cancelBtn.TabIndex = 6;
            this.cancelBtn.Text = "Cancel";
            this.cancelBtn.UseVisualStyleBackColor = true;
            this.cancelBtn.Click += new System.EventHandler(this.cancelBtn_Click);
            // 
            // applyBtn
            // 
            this.applyBtn.Location = new System.Drawing.Point(678, 408);
            this.applyBtn.Name = "applyBtn";
            this.applyBtn.Size = new System.Drawing.Size(84, 30);
            this.applyBtn.TabIndex = 5;
            this.applyBtn.Text = "Apply";
            this.applyBtn.UseVisualStyleBackColor = true;
            this.applyBtn.Click += new System.EventHandler(this.applyBtn_Click);
            // 
            // toReplacePic
            // 
            this.toReplacePic.Location = new System.Drawing.Point(499, 236);
            this.toReplacePic.Name = "toReplacePic";
            this.toReplacePic.Size = new System.Drawing.Size(289, 166);
            this.toReplacePic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.toReplacePic.TabIndex = 7;
            this.toReplacePic.TabStop = false;
            // 
            // wChromaKeyPic
            // 
            this.wChromaKeyPic.Location = new System.Drawing.Point(499, 64);
            this.wChromaKeyPic.Name = "wChromaKeyPic";
            this.wChromaKeyPic.Size = new System.Drawing.Size(289, 166);
            this.wChromaKeyPic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.wChromaKeyPic.TabIndex = 8;
            this.wChromaKeyPic.TabStop = false;
            // 
            // chromakey
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.wChromaKeyPic);
            this.Controls.Add(this.toReplacePic);
            this.Controls.Add(this.cancelBtn);
            this.Controls.Add(this.applyBtn);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.finalPic);
            this.Name = "chromakey";
            this.Text = "chromakey";
            ((System.ComponentModel.ISupportInitialize)(this.finalPic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.toReplacePic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.wChromaKeyPic)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox finalPic;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button cancelBtn;
        private System.Windows.Forms.Button applyBtn;
        private System.Windows.Forms.PictureBox toReplacePic;
        private System.Windows.Forms.PictureBox wChromaKeyPic;
    }
}