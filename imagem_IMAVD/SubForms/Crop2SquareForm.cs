using imagem_IMAVD.Utils;
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

namespace imagem_IMAVD
{
    public partial class Crop2SquareForm : Form
    {

        public PictureBox imageToCrop { get; set; }

        public Image newImageToWork { get; set; }

        public Crop2SquareForm()
        {
            InitializeComponent();
            SetStyle(ControlStyles.SupportsTransparentBackColor, true);
        }

        private void Crop2SquareForm_Load(object sender, EventArgs e)
        {
            Rectangle rect = new Rectangle(0, 0, imageToCrop.Width, imageToCrop.Height/2);
            Bitmap OriginalImage = new Bitmap(imageToCrop.Image, imageToCrop.Width, imageToCrop.Height);
            Bitmap _img = new Bitmap(imageToCrop.Width, imageToCrop.Height / 2);
            _img.MakeTransparent(Color.Transparent);
            Graphics g = Graphics.FromImage(_img);
            g.InterpolationMode = InterpolationMode.HighQualityBicubic;
            g.PixelOffsetMode = PixelOffsetMode.HighQuality;
            g.CompositingQuality = CompositingQuality.HighQuality;
            g.DrawImage(OriginalImage, 0, 0, rect, GraphicsUnit.Pixel);
            square1.Image = _img;
            square1.Width = _img.Width;
            square1.Height = _img.Height;

            rect = new Rectangle(0, imageToCrop.Height / 2, imageToCrop.Width, imageToCrop.Height / 2);
            OriginalImage = new Bitmap(imageToCrop.Image, imageToCrop.Width, imageToCrop.Height);
            _img = new Bitmap(imageToCrop.Width, imageToCrop.Height / 2);
            _img.MakeTransparent(Color.Transparent);
            g = Graphics.FromImage(_img);
            g.InterpolationMode = InterpolationMode.HighQualityBicubic;
            g.PixelOffsetMode = PixelOffsetMode.HighQuality;
            g.CompositingQuality = CompositingQuality.HighQuality;
            g.DrawImage(OriginalImage, 0, 0, rect, GraphicsUnit.Pixel);

            square2.Image = _img;
            square2.Width = _img.Width;
            square2.Height = _img.Height;

        }

        private void saveImagesBtn_Click(object sender, EventArgs e)
        {
            GlobalFunctions.saveImage(square1.Image);
            GlobalFunctions.saveImage(square2.Image);
        }

        private void square1Btn_Click(object sender, EventArgs e)
        {
            newImageToWork = square1.Image;
            DialogResult = DialogResult.OK;
            Close();
        }

        private void square2Btn_Click(object sender, EventArgs e)
        {
            newImageToWork = square2.Image;
            DialogResult = DialogResult.OK;
            Close();
        }

        private void square2_Click(object sender, EventArgs e)
        {

        }

        private void square1_Click(object sender, EventArgs e)
        {

        }
    }
}
