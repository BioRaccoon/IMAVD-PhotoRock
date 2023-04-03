using System;
using System.Diagnostics;
using System.Diagnostics.Contracts;
using System.Drawing;
using System.Windows.Forms;
using Image = System.Drawing.Image;

namespace imagem_IMAVD.SubForms
{
    public partial class chromakey : Form
    {
        string filePath;
        public Bitmap finalImage;
        public chromakey()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();

            openFileDialog1.Title = "Select an image file";
            openFileDialog1.Filter = "Image files (*.jpg, *.jpeg, *.png) | *.jpg; *.jpeg; *.png";

            DialogResult result = openFileDialog1.ShowDialog();

            if (result == DialogResult.OK)
            {
                filePath = openFileDialog1.FileName;
                wChromaKeyPic.Image = Image.FromFile(filePath);
            }
            if (toReplacePic.Image != null && wChromaKeyPic.Image != null)
            {
                ChromaKey();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();

            openFileDialog1.Title = "Select an image file";
            openFileDialog1.Filter = "Image files (*.jpg, *.jpeg, *.png) | *.jpg; *.jpeg; *.png";

            DialogResult result = openFileDialog1.ShowDialog();

            if (result == DialogResult.OK)
            {
                filePath = openFileDialog1.FileName;
                toReplacePic.Image = Image.FromFile(filePath);
            }
            if (toReplacePic.Image != null && wChromaKeyPic.Image != null)
            {
                ChromaKey();
            }
        }
        public void ChromaKey()
        {
            Bitmap wChroma = new Bitmap(wChromaKeyPic.Image, wChromaKeyPic.Width, wChromaKeyPic.Height);
            Bitmap toReplace = new Bitmap(toReplacePic.Image, toReplacePic.Width, toReplacePic.Height);
            Bitmap result = new Bitmap(wChromaKeyPic.Width, wChromaKeyPic.Height);

            Color chromaKeyColor = Color.FromArgb(0, 255, 0);

            for (int x = 0; x < result.Width; x++)
            {
                for (int y = 0; y < result.Height; y++)
                {
                    Color backgroundPixel = wChroma.GetPixel(x, y);
                    Color foregroundPixel = toReplace.GetPixel(x, y);

                    if (ColorDistance(backgroundPixel, chromaKeyColor) <= 170)
                    {
                        result.SetPixel(x, y, foregroundPixel);
                    }
                    else
                    {
                        result.SetPixel(x, y, backgroundPixel);
                    }
                }
            }
            finalPic.Image = result;
            finalImage = result;
        }
        private static double ColorDistance(Color color1, Color color2)
        {
            double redMean = (color1.R + color2.R) / 2.0;
            int redDiff = color1.R - color2.R;
            int greenDiff = color1.G - color2.G;
            int blueDiff = color1.B - color2.B;

            return Math.Sqrt((2 + redMean / 256.0) * Math.Pow(redDiff, 2) + 4 * Math.Pow(greenDiff, 2) + (2 + (255 - redMean) / 256.0) * Math.Pow(blueDiff, 2));
        }

        private void applyBtn_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
            Close();
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }
    }
}
