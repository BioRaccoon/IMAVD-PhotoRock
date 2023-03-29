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
    public partial class Crop2TriangleForm : Form
    {
        public PictureBox imageToCrop { get; set; }

        public Image newImageToWork { get; set; }

        public Crop2TriangleForm()
        {
            InitializeComponent();
            SetStyle(ControlStyles.SupportsTransparentBackColor, true);
        }

        private void Crop2TriangleForm_Load(object sender, EventArgs e)
        {
            GraphicsPath graphicsPath = new GraphicsPath();
            graphicsPath.AddLines(new Point[] { new Point(0, 0), new Point(imageToCrop.Width, 0), new Point(0, imageToCrop.Height) });
            graphicsPath.CloseAllFigures();

            Rectangle rect = new Rectangle(0, 0, imageToCrop.Width, imageToCrop.Height);
            Bitmap OriginalImage = new Bitmap(imageToCrop.Image, imageToCrop.Width, imageToCrop.Height);
            Bitmap _img = new Bitmap(imageToCrop.Width, imageToCrop.Height);
            _img.MakeTransparent(Color.Transparent);
            Graphics g = Graphics.FromImage(_img);
            g.InterpolationMode = InterpolationMode.HighQualityBicubic;
            g.PixelOffsetMode = PixelOffsetMode.HighQuality;
            g.CompositingQuality = CompositingQuality.HighQuality;
            g.Clip = new Region(graphicsPath);
            g.DrawImage(OriginalImage, 0, 0, rect, GraphicsUnit.Pixel);
            triangle1.Image = _img;
            triangle1.Width = _img.Width;
            triangle1.Height = _img.Height;

            graphicsPath = new GraphicsPath();
            graphicsPath.AddLines(new Point[] { new Point(0, imageToCrop.Height), new Point(imageToCrop.Width, imageToCrop.Height), new Point(imageToCrop.Width, 0) });
            graphicsPath.CloseAllFigures();

            rect = new Rectangle(0, 0, imageToCrop.Width, imageToCrop.Height);
            OriginalImage = new Bitmap(imageToCrop.Image, imageToCrop.Width, imageToCrop.Height);
            _img = new Bitmap(imageToCrop.Width, imageToCrop.Height);
            _img.MakeTransparent(Color.Transparent);
            g = Graphics.FromImage(_img);
            g.InterpolationMode = InterpolationMode.HighQualityBicubic;
            g.PixelOffsetMode = PixelOffsetMode.HighQuality;
            g.CompositingQuality = CompositingQuality.HighQuality;
            g.Clip = new Region(graphicsPath);
            g.DrawImage(OriginalImage, 0, 0, rect, GraphicsUnit.Pixel);
            triangle2.Image = _img;
            triangle2.Width = _img.Width;
            triangle2.Height = _img.Height;

            triangle1.BackColor = Color.Transparent;
            triangle2.BackColor = Color.Transparent;

        }

        private void saveImagesBtn_Click(object sender, EventArgs e)
        {
            GlobalFunctions.saveImage(triangle1.Image);
            GlobalFunctions.saveImage(triangle2.Image);
        }

        private void triangle1Btn_Click(object sender, EventArgs e)
        {
            newImageToWork = triangle1.Image;
            DialogResult = DialogResult.OK;
            Close();
        }

        private void triangle2Btn_Click(object sender, EventArgs e)
        {
            newImageToWork = triangle2.Image;
            DialogResult = DialogResult.OK;
            Close();
        }
    }
}
