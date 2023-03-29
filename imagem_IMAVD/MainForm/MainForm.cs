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

namespace PhotoRock
{
    public partial class MainForm : Form
    {
        bool imageIsSelected = false;
        string filePath;
        Image img;

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
                img = Image.FromFile(filePath);
                imageIsSelected = true;

                selectCropAreaBtn.Enabled = true;
                crop2Btn.Enabled = true;
                crop4Btn.Enabled = true;
                crop2TrianglesBtn.Enabled = true;

                //MessageBox.Show("s - " + pictureBox1.Width + "\nt - " + pictureBox1.Height);

            }
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
            pictureBox1.Refresh();
        }

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            if (pictureBox1.Image == null)
                return;
            if (e.Button == MouseButtons.Left && cropEnabled)
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
            if (cropEnabled)
            {
                if (cropWidth < 1)
                {
                    return;
                }
                Rectangle rect = new Rectangle(cropX, cropY, cropWidth, cropHeight);

                Bitmap OriginalImage = new Bitmap(pictureBox1.Image, pictureBox1.Width, pictureBox1.Height);

                Bitmap _img = new Bitmap(cropWidth, cropHeight);

                Graphics g = Graphics.FromImage(_img);

                g.InterpolationMode = InterpolationMode.HighQualityBicubic;
                g.PixelOffsetMode = PixelOffsetMode.HighQuality;
                g.CompositingQuality = CompositingQuality.HighQuality;

                g.DrawImage(OriginalImage, 0, 0, rect, GraphicsUnit.Pixel);
                pictureBox1.Image = _img;
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
                pictureBox1.Refresh();
                crop2Btn.Enabled = true;
                crop4Btn.Enabled = true;
                crop2TrianglesBtn.Enabled = true;
            }
            
        }

        private void crop2Btn_Click(object sender, EventArgs e)
        {
            Crop2SquareForm crop2SquareForm = new Crop2SquareForm();
            crop2SquareForm.imageToCrop = pictureBox1;
            DialogResult result = crop2SquareForm.ShowDialog();

            if (result == DialogResult.OK)
            {
                pictureBox1.Image = crop2SquareForm.newImageToWork;
                //pictureBox1.Width = crop2SquareForm.newImageToWork.Width;
                //pictureBox1.Height = crop2SquareForm.newImageToWork.Height;
            }
        }

        private void crop4Btn_Click(object sender, EventArgs e)
        {
            Crop4SquareForm crop4SquareForm = new Crop4SquareForm();
            crop4SquareForm.imageToCrop = pictureBox1;
            DialogResult result = crop4SquareForm.ShowDialog();

            if (result == DialogResult.OK)
            {
                pictureBox1.Image = crop4SquareForm.newImageToWork;
                //pictureBox1.Width = crop4SquareForm.newImageToWork.Width;
                //pictureBox1.Height = crop4SquareForm.newImageToWork.Height;
            }
        }

        private void crop2TrianglesBtn_Click(object sender, EventArgs e)
        {
            Crop2TriangleForm crop2TriangleForm = new Crop2TriangleForm();
            crop2TriangleForm.imageToCrop = pictureBox1;
            DialogResult result = crop2TriangleForm.ShowDialog();

            if (result == DialogResult.OK)
            {
                pictureBox1.Image = crop2TriangleForm.newImageToWork;
                //pictureBox1.Width = crop2TriangleForm.newImageToWork.Width;
                //pictureBox1.Height = crop2TriangleForm.newImageToWork.Height;
            }
        }

        private void rotateBtn_Click(object sender, EventArgs e) {

            if (pictureBox1.Image == null) {
                return;
            }

            Bitmap OriginalImage = new Bitmap(pictureBox1.Image, pictureBox1.Width, pictureBox1.Height);
            Bitmap _img = RotateImageN(OriginalImage, 90.0F);
            pictureBox1.Image = _img;
        }

        private Bitmap RotateImageN(Bitmap b, float angle) {
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

    }
}
