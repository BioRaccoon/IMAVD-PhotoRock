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
using imagem_IMAVD;
using imagem_IMAVD.Utils;

namespace PhotoRock
{
    public partial class MainForm : Form
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
        public Pen cropPen;
        public DashStyle cropDashStyle = DashStyle.DashDot;
        private bool cropEnabled;

        public MainForm()
        {
            InitializeComponent();
            SetStyle(ControlStyles.SupportsTransparentBackColor, true);

            selectCropAreaBtn.Enabled = false;
            cropBtn.Enabled = false;
            crop2Btn.Enabled = false;
            crop4Btn.Enabled = false;
            crop2TrianglesBtn.Enabled = false;
            mainImageCopy.Visible= false; 

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
                mainImage.Image = Image.FromFile(filePath);
                mainImageCopy.Image = Image.FromFile(filePath);
                img = Image.FromFile(filePath);
                imageIsSelected = true;

                selectCropAreaBtn.Enabled = true;
                crop2Btn.Enabled = true;
                crop4Btn.Enabled = true;
                crop2TrianglesBtn.Enabled = true;

                //MessageBox.Show("s - " + pictureBox1.Width + "\nt - " + pictureBox1.Height);

                
            }
        }

        private void saveImageBtn_Click(object sender, EventArgs e)
        {
            GlobalFunctions.saveImage(mainImage.Image);
        }

        private void propertiesBtn_Click(object sender, EventArgs e)
        {
            if (imageIsSelected)
            {
                PropertiesForm propertiesF = new PropertiesForm();
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
            if (e.Button == MouseButtons.Left && cropEnabled)
            {
                Cursor = Cursors.Cross;
                cropX = e.X;
                cropY = e.Y;
                cropPen = new Pen(Color.Black, 3);
                cropPen.DashStyle = DashStyle.DashDotDot;
            }
            mainImage.Refresh();
        }

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            if (mainImage.Image == null)
                return;
            if (e.Button == MouseButtons.Left && cropEnabled)
            {
                mainImage.Refresh();
                cropWidth = e.X - cropX;
                cropHeight = e.Y - cropY;
                mainImage.CreateGraphics().DrawRectangle(cropPen, cropX, cropY, cropWidth, cropHeight);
            }
        }

        private void cropBtn_Click(object sender, EventArgs e)
        {
            Cursor = Cursors.Default;
            if (cropEnabled)
            {
                if (cropWidth < 1)
                {
                    return;
                }
                Rectangle rect = new Rectangle(cropX, cropY, cropWidth, cropHeight);

                Bitmap OriginalImage = new Bitmap(mainImage.Image, mainImage.Width, mainImage.Height);

                Bitmap _img = new Bitmap(cropWidth, cropHeight);

                Graphics g = Graphics.FromImage(_img);

                g.InterpolationMode = InterpolationMode.HighQualityBicubic;
                g.PixelOffsetMode = PixelOffsetMode.HighQuality;
                g.CompositingQuality = CompositingQuality.HighQuality;

                g.DrawImage(OriginalImage, 0, 0, rect, GraphicsUnit.Pixel);
                mainImage.Image = _img;
                //pictureBox1.Width = _img.Width;
                //pictureBox1.Height = _img.Height;
                cropBtn.Enabled = false;
                cropEnabled = false;
                selectCropAreaBtn.Text = "Select Area";
                crop2Btn.Enabled = true;
                crop4Btn.Enabled = true;
                crop2TrianglesBtn.Enabled = true;
            }
        }

        private void selectCropAreaBtn_Click(object sender, EventArgs e)
        {
            if (!cropEnabled) {
                cropEnabled = true;
                cropBtn.Enabled = true;
                selectCropAreaBtn.Text = "Cancel Crop";
                crop2Btn.Enabled = false;
                crop4Btn.Enabled = false;
                crop2TrianglesBtn.Enabled = false;
            } else
            {
                selectCropAreaBtn.Text = "Select Area";
                cropEnabled = false;
                cropBtn.Enabled = false;
                Cursor = Cursors.Default;
                cropPen = null;
                mainImage.Refresh();
                crop2Btn.Enabled = true;
                crop4Btn.Enabled = true;
                crop2TrianglesBtn.Enabled = true;
            }
            
        }

        private void crop2Btn_Click(object sender, EventArgs e)
        {
            Crop2SquareForm crop2SquareForm = new Crop2SquareForm();
            crop2SquareForm.imageToCrop = mainImage;
            DialogResult result = crop2SquareForm.ShowDialog();

            if (result == DialogResult.OK)
            {
                mainImage.Image = crop2SquareForm.newImageToWork;
                //pictureBox1.Width = crop2SquareForm.newImageToWork.Width;
                //pictureBox1.Height = crop2SquareForm.newImageToWork.Height;
            }
        }

        private void rotate45Btn_Click(object sender, EventArgs e)
        {
            if (mainImage.Image == null)
            {
                return;
            }

            Bitmap OriginalImage = new Bitmap(mainImage.Image, mainImage.Width, mainImage.Height);
            Bitmap _img = Rotate45(OriginalImage, tilted);
            mainImage.Image = _img;
            tilted = !tilted;
        }

        private void crop4Btn_Click(object sender, EventArgs e)
        {
            Crop4SquareForm crop4SquareForm = new Crop4SquareForm();
            crop4SquareForm.imageToCrop = mainImage;
            DialogResult result = crop4SquareForm.ShowDialog();

            if (result == DialogResult.OK)
            {
                mainImage.Image = crop4SquareForm.newImageToWork;
                //pictureBox1.Width = crop4SquareForm.newImageToWork.Width;
                //pictureBox1.Height = crop4SquareForm.newImageToWork.Height;
            }
        }

        private void crop2TrianglesBtn_Click(object sender, EventArgs e)
        {
            Crop2TriangleForm crop2TriangleForm = new Crop2TriangleForm();
            crop2TriangleForm.imageToCrop = mainImage;
            DialogResult result = crop2TriangleForm.ShowDialog();

            if (result == DialogResult.OK)
            {
                mainImage.Image = crop2TriangleForm.newImageToWork;
                //pictureBox1.Width = crop2TriangleForm.newImageToWork.Width;
                //pictureBox1.Height = crop2TriangleForm.newImageToWork.Height;
            }
        }

        private void rotate90Btn_Click(object sender, EventArgs e)
        {
            if (mainImage.Image == null)
            {
                return;
            }

            Bitmap OriginalImage = new Bitmap(mainImage.Image, mainImage.Width, mainImage.Height);
            Bitmap _img = RotateImageN(OriginalImage, 90.0F);
            mainImage.Image = _img;
        }

        private void rotate180Btn_Click(object sender, EventArgs e)
        {
            if (mainImage.Image == null)
            {
                return;
            }

            Bitmap OriginalImage = new Bitmap(mainImage.Image, mainImage.Width, mainImage.Height);
            Bitmap _img = RotateImageN(OriginalImage, 180.0F);
            mainImage.Image = _img;
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
            if (mainImage.Image == null) {
                return;
            }
            Image img = mainImage.Image;
                //rotate the picture by 90 degrees and re-save the picture as a Jpeg
                img.RotateFlip(RotateFlipType.RotateNoneFlipX);
            mainImage.Image = img;
        }

        private void flipVBtn_Click(object sender, EventArgs e) {
            if (mainImage.Image == null) {
                return;
            }
            Image img = mainImage.Image;
            //rotate the picture by 90 degrees and re-save the picture as a Jpeg
            img.RotateFlip(RotateFlipType.RotateNoneFlipY);
            mainImage.Image = img;
        }

        private void redFilter_Click(object sender, EventArgs e)
        {
            Bitmap filteredImage = (Bitmap)mainImage.Image;
            for (int y = 0; y < filteredImage.Height; y++)
            {
                for (int x = 0; x < filteredImage.Width; x++)
                {
                    Color pixelColor = filteredImage.GetPixel(x, y);
                    Color newColor = Color.FromArgb(pixelColor.R, 0, 0);
                    filteredImage.SetPixel(x, y, newColor);
                    mainImage.Image = filteredImage;
                    imageHasFilter=true;
                }
            }
        }

        private void greenFilter_Click(object sender, EventArgs e)
        {
            Bitmap filteredImage = (Bitmap)mainImage.Image;
            for (int y = 0; y < filteredImage.Height; y++)
            {
                for (int x = 0; x < filteredImage.Width; x++)
                {
                    Color pixelColor = filteredImage.GetPixel(x, y);
                    Color newColor = Color.FromArgb(0, pixelColor.G, 0);
                    filteredImage.SetPixel(x, y, newColor);
                    mainImage.Image = filteredImage;
                    imageHasFilter = true;
                }
            }

        }

        private void blueFilter_Click(object sender, EventArgs e)
        {
            Bitmap filteredImage = (Bitmap)mainImage.Image;
            for (int y = 0; y < filteredImage.Height; y++)
            {
                for (int x = 0; x < filteredImage.Width; x++)
                {
                    Color pixelColor = filteredImage.GetPixel(x, y);
                    Color newColor = Color.FromArgb(0, 0, pixelColor.B);
                    filteredImage.SetPixel(x, y, newColor);
                    mainImage.Image = filteredImage;
                    imageHasFilter = true;
                }
            }
        }

        private void clearFilter_Click(object sender, EventArgs e)
        {
            if(imageHasFilter)
            {
                mainImage.Image = mainImageCopy.Image;
                imageHasFilter=false;
            } 
        }

        private void undoBtn_Click(object sender, EventArgs e)
        {

        }

    }
}
