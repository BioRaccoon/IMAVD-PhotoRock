using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Imaging;

namespace PhotoRock
{
    public partial class Form1 : Form
    {
        bool imageIsSelected = false;
        bool imageHasFilter = false;
        bool tilted = false;
        string filePath;
        Image img;
        Bitmap originalImage;

        int cropX;
        int cropY;
        int cropWidth;
        int cropHeight;
        int oCropX;
        int oCropY;
        public Pen cropPen;
        public DashStyle cropDashStyle = DashStyle.DashDot;

        public Form1()
        {
            InitializeComponent();
            pictureBox3.Visible= false;
            

        }

        private void loadBtn_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();

            openFileDialog1.Title = "Select an image file";
            openFileDialog1.Filter = "Image files (*.jpg, *.jpeg, *.png) | *.jpg; *.jpeg; *.png";

            DialogResult result = openFileDialog1.ShowDialog();

            if (result == DialogResult.OK)
            {
                filePath = openFileDialog1.FileName;
                pictureBox1.Image = Image.FromFile(filePath);
                pictureBox3.Image = Image.FromFile(filePath);
                img = Image.FromFile(filePath);
                imageIsSelected = true;
                
            }
        }


        private void propertiesBtn_Click(object sender, EventArgs e)
        {
            if (imageIsSelected)
            {
                propertiesForm propertiesF = new propertiesForm();
                propertiesF.FilePath = filePath;
                propertiesF.Show();
            }
            else
            {
                MessageBox.Show("Tem que inserir uma imagem primero!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                Cursor = Cursors.Cross;
                cropX = e.X;
                cropY = e.Y;
                cropPen = new Pen(Color.Black, 1);
                cropPen.DashStyle = DashStyle.DashDotDot;
            }
            pictureBox1.Refresh();
        }

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            if (pictureBox1.Image == null)
                return;
            if (e.Button == MouseButtons.Left)
            {
                pictureBox1.Refresh();
                cropWidth = e.X - cropX;
                cropHeight = e.Y - cropY;
                pictureBox1.CreateGraphics().DrawRectangle(cropPen, cropX, cropY, cropWidth, cropHeight);
            }
        }

        private void cropBtn_Click(object sender, EventArgs e)
        {
            Cursor = Cursors.Default;
            if (cropWidth < 1)
            {
                return;
            }
            Rectangle rect = new Rectangle(cropX, cropY, cropWidth, cropHeight);
            //First we define a rectangle with the help of already calculated points  
            Bitmap OriginalImage = new Bitmap(pictureBox1.Image, pictureBox1.Width, pictureBox1.Height);
            //Original image  
            Bitmap _img = new Bitmap(cropWidth, cropHeight);
            // for cropinf image  
            Graphics g = Graphics.FromImage(_img);
            // create graphics  
            g.InterpolationMode = InterpolationMode.HighQualityBicubic;
            g.PixelOffsetMode = PixelOffsetMode.HighQuality;
            g.CompositingQuality = CompositingQuality.HighQuality;
            //set image attributes  
            g.DrawImage(OriginalImage, 0, 0, rect, GraphicsUnit.Pixel);
            pictureBox2.Image = _img;
            pictureBox2.Width = _img.Width;
            pictureBox2.Height = _img.Height;
            //pictureBoxLocation();
            cropBtn.Enabled = false;
        }

        private void selectCropAreaBtn_Click(object sender, EventArgs e)
        {

        }

        private void rotate45Btn_Click(object sender, EventArgs e)
        {
            if (pictureBox1.Image == null)
            {
                return;
            }

            Bitmap OriginalImage = new Bitmap(pictureBox1.Image, pictureBox1.Width, pictureBox1.Height);
            Bitmap _img = Rotate45(OriginalImage, tilted);
            pictureBox1.Image = _img;
            tilted = !tilted;
        }


        private void rotate90Btn_Click(object sender, EventArgs e)
        {
            if (pictureBox1.Image == null)
            {
                return;
            }

            Bitmap OriginalImage = new Bitmap(pictureBox1.Image, pictureBox1.Width, pictureBox1.Height);
            Bitmap _img = RotateImageN(OriginalImage, 90.0F);
            pictureBox1.Image = _img;
        }

        private void rotate180Btn_Click(object sender, EventArgs e)
        {
            if (pictureBox1.Image == null)
            {
                return;
            }

            Bitmap OriginalImage = new Bitmap(pictureBox1.Image, pictureBox1.Width, pictureBox1.Height);
            Bitmap _img = RotateImageN(OriginalImage, 180.0F);
            pictureBox1.Image = _img;
        }

        private Bitmap Rotate45(Bitmap b, bool tilted)
        {
            float angle = 45.0F;
            if (angle > 0)
            {
                int l = b.Width;
                int h = b.Height;
                double an = angle * Math.PI / 180;
                double cos = Math.Abs(Math.Cos(an));
                double sin = Math.Abs(Math.Sin(an));
                int nl = (int)(l * cos + h * sin);
                int nh = (int)(l * sin + h * cos);
                Bitmap returnBitmap = new Bitmap(nl, nh);
                Graphics g = Graphics.FromImage(returnBitmap);
                if (!tilted)
                {
                    g.TranslateTransform((float)(nl - l) / 2, (float)(nh - h) / 2);
                    g.TranslateTransform((float)b.Width / 2, (float)b.Height / 2);
                }
                else
                {
                    g.TranslateTransform((float)(nl - l) / 2, (float)(nh - h) / 2);
                    g.TranslateTransform((float)b.Width / 2, (float)b.Height / 2);
                    float scIdx = (float)nl / l;
                    //Console.WriteLine(scIdx.ToString());
                    //nao sei pq eq tenho q dar scale 2x mas funciona :))))) adoro geometria
                    g.ScaleTransform(scIdx, scIdx);
                    g.ScaleTransform(scIdx, scIdx);
                }

                g.RotateTransform(angle);
                g.TranslateTransform(-(float)b.Width / 2, -(float)b.Height / 2);
                g.DrawImage(b, new Point(0, 0));

                //Console.WriteLine(nl.ToString() + " " + nh.ToString() + " " + l.ToString() + " " + h.ToString());

                return returnBitmap;
            }
            else return b;
        }

        private Bitmap RotateImageN(Bitmap b, float angle)
        {
            //Create a new empty bitmap to hold rotated image.
            Bitmap returnBitmap = new Bitmap(b.Width, b.Height);
            //Make a graphics object from the empty bitmap.
            Graphics g = Graphics.FromImage(returnBitmap);
            //move rotation point to center of image.
            g.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.HighQualityBicubic;
            g.TranslateTransform((float)b.Width / 2, (float)b.Height / 2);
            //Rotate.        
            g.RotateTransform(angle);
            //Move image back.
            g.TranslateTransform(-(float)b.Width / 2, -(float)b.Height / 2);
            //Draw passed in image onto graphics object.
            //Found ERROR 1: Many people do g.DwarImage(b,0,0); The problem is that you re giving just the position
            //Found ERROR 2: Many people do g.DrawImage(b, new Point(0,0));

            g.DrawImage(b, 0, 0, b.Width, b.Height);
            return returnBitmap;
        }

        private void flipHBtn_Click(object sender, EventArgs e) {
            if (pictureBox1.Image == null) {
                return;
            }
            Image img = pictureBox1.Image;
                //rotate the picture by 90 degrees and re-save the picture as a Jpeg
                img.RotateFlip(RotateFlipType.RotateNoneFlipX);
            pictureBox1.Image = img;
        }

        private void flipVBtn_Click(object sender, EventArgs e) {
            if (pictureBox1.Image == null) {
                return;
            }
            Image img = pictureBox1.Image;
            //rotate the picture by 90 degrees and re-save the picture as a Jpeg
            img.RotateFlip(RotateFlipType.RotateNoneFlipY);
            pictureBox1.Image = img;
        }

        private void redFilter_Click(object sender, EventArgs e)
        {
            Bitmap filteredImage = (Bitmap)pictureBox1.Image;
            for (int y = 0; y < filteredImage.Height; y++)
            {
                for (int x = 0; x < filteredImage.Width; x++)
                {
                    Color pixelColor = filteredImage.GetPixel(x, y);
                    Color newColor = Color.FromArgb(pixelColor.R, 0, 0);
                    filteredImage.SetPixel(x, y, newColor);
                    pictureBox1.Image = filteredImage;
                    imageHasFilter=true;
                }
            }
        }

        private void greenFilter_Click(object sender, EventArgs e)
        {
            Bitmap filteredImage = (Bitmap)pictureBox1.Image;
            for (int y = 0; y < filteredImage.Height; y++)
            {
                for (int x = 0; x < filteredImage.Width; x++)
                {
                    Color pixelColor = filteredImage.GetPixel(x, y);
                    Color newColor = Color.FromArgb(0, pixelColor.G, 0);
                    filteredImage.SetPixel(x, y, newColor);
                    pictureBox1.Image = filteredImage;
                    imageHasFilter = true;
                }
            }

        }

        private void blueFilter_Click(object sender, EventArgs e)
        {
            Bitmap filteredImage = (Bitmap)pictureBox1.Image;
            for (int y = 0; y < filteredImage.Height; y++)
            {
                for (int x = 0; x < filteredImage.Width; x++)
                {
                    Color pixelColor = filteredImage.GetPixel(x, y);
                    Color newColor = Color.FromArgb(0, 0, pixelColor.B);
                    filteredImage.SetPixel(x, y, newColor);
                    pictureBox1.Image = filteredImage;
                    imageHasFilter = true;
                }
            }
        }

        private void clearFilter_Click(object sender, EventArgs e)
        {
            if(imageHasFilter)
            {
                pictureBox1.Image = pictureBox3.Image;
                imageHasFilter=false;
            } 
        }
    }
}
