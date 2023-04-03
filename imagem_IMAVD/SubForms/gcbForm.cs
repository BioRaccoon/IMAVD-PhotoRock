using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace imagem_IMAVD.SubForms
{
    public partial class gcbForm : Form
    {
        public Bitmap imageNow;
        public Bitmap adjustedImage;
        public gcbForm()
        {
            InitializeComponent();
        }

        private void applyBtn_Click(object sender, EventArgs e)
        {
            adjustedImage = AdjustImage(imageNow, gamma.Value / 5, contrast.Value, brightness.Value);
            DialogResult = DialogResult.OK;
            Close();
        }
        public Bitmap AdjustImage(Bitmap image, double gamma, int contrast, int brightness)
        {
            adjustedImage = new Bitmap(image.Width, image.Height);

            gamma = Math.Max(0.2, Math.Min(5, gamma));
            double gammaCorrection = 1 / gamma;
            byte[] gammaTable = new byte[256];
            for (int i = 0; i < 256; i++)
            {
                gammaTable[i] = (byte)Math.Min(255, (int)((255.0 * Math.Pow(i / 255.0, gammaCorrection)) + 0.5));
            }

            contrast = Math.Max(-100, Math.Min(100, contrast));
            double contrastLevel = Math.Pow((100.0 + contrast) / 100.0, 2);

            brightness = Math.Max(-255, Math.Min(255, brightness));
            double brightnessLevel = (brightness / 255.0) * 255.0;
            for (int x = 0; x < adjustedImage.Width; x++)
            {
                for (int y = 0; y < adjustedImage.Height; y++)
                {
                    Color color = image.GetPixel(x, y);
                    byte r = gammaTable[color.R];
                    byte g = gammaTable[color.G];
                    byte b = gammaTable[color.B];
                    r = (byte)Math.Min(255, Math.Max(0, (contrastLevel * (r - 128) + 128 + brightnessLevel)));
                    g = (byte)Math.Min(255, Math.Max(0, (contrastLevel * (g - 128) + 128 + brightnessLevel)));
                    b = (byte)Math.Min(255, Math.Max(0, (contrastLevel * (b - 128) + 128 + brightnessLevel)));
                    adjustedImage.SetPixel(x, y, Color.FromArgb(color.A, r, g, b));
                }
            }

            return adjustedImage;
        }
        private void brightness_ValueChanged(object sender, EventArgs e)
        {
            brightnessValueLabel.Text = brightness.Value.ToString();
        }
        private void contrast_ValueChanged(object sender, EventArgs e)
        {
            contrastValueLabel.Text = contrast.Value.ToString();
        }
        private void gamma_ValueChanged(object sender, EventArgs e)
        {
            double decimalValue = (double)gamma.Value/5;
            gammaValueLabel.Text = decimalValue.ToString("F1");
        }

        private void previewBtn_Click(object sender, EventArgs e)
        {
            adjustedImagePicBox.Image = AdjustImage(imageNow, gamma.Value / 5, contrast.Value, brightness.Value);
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }
    }
}
