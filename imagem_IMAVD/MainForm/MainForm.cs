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
using static System.Net.Mime.MediaTypeNames;
using Image = System.Drawing.Image;
using imagem_IMAVD.SubForms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Reflection.Emit;
using System.IO;
using System.Diagnostics;

namespace PhotoRock
{
    public partial class MainForm : Form
    {
        bool imageIsSelected = false;
        bool imageHasFilter = false;
        bool tilted = false;
        string filePath;
        Image img;
        Bitmap unzoomedImg;

        int cropX;
        int cropY;
        int cropWidth;
        int cropHeight;
        public Pen cropPen;
        public DashStyle cropDashStyle = DashStyle.DashDot;
        private bool cropEnabled;
        private bool colorPickerEnabled;
        private PictureBox mainImageCopy;
        private Image imageCopy;
        public List<Image> imageCopiesList = new List<Image>();
        public MainForm()
        {
            InitializeComponent();
            SetStyle(ControlStyles.SupportsTransparentBackColor, true);
            initializeControlsProperties();
        }

        public void initializeControlsProperties()
        {
            deactivateAllButtonControls();
            changeInitialControlsProperties();
        }

        public void changeInitialControlsProperties()
        {
            loadImageBtn.Enabled = true;
            selectedColorBox.Text = "White (Default Color)";
            selectedColorBox.TextAlign = ContentAlignment.MiddleCenter;
            selectedColorBox.BackColor = Color.White;
            colorPixelsNumberLabel.Visible = false;
            colorPixelsNumberLabel.TextAlign = ContentAlignment.MiddleCenter;
        }

        public void deactivateAllButtonControls()
        {
            /////////////////////////////
            loadImageBtn.Enabled = false;
            saveImageBtn.Enabled = false;
            imageDetailsBtn.Enabled = false;
            undoBtn.Enabled = false;
            zoomComboBox.Enabled = false;
            ////////////////////////////
            selectCropAreaBtn.Enabled = false;
            cropBtn.Enabled = false;
            crop2Btn.Enabled = false;
            crop4Btn.Enabled = false;
            crop2TrianglesBtn.Enabled = false;
            ////////////////////////////
            rotate45Btn.Enabled = false;
            rotate90Btn.Enabled = false;
            rotate180Btn.Enabled = false;
            flipHorizontalBtn.Enabled = false;
            flipVerticalBtn.Enabled = false;
            ////////////////////////////
            redFilter.Enabled = false;
            greenFilter.Enabled = false;
            blueFilter.Enabled = false;
            clearFilter.Enabled = false;
            gcb.Enabled = false;
            ////////////////////////////
            colorPalettePickerBtn.Enabled = false;
            colorMousePickerBtn.Enabled = false;
            selectedColorBox.Enabled = false;
            searchColorBtn.Enabled = false;
            ////////////////////////////
            chromakey.Enabled = false;
        }

        public void activateAllButtonControls()
        {
            /////////////////////////////
            loadImageBtn.Enabled = true;
            saveImageBtn.Enabled = true;
            imageDetailsBtn.Enabled = true;
            undoBtn.Enabled = true;
            zoomComboBox.Enabled = true;
            ////////////////////////////
            selectCropAreaBtn.Enabled = true;
            cropBtn.Enabled = true;
            crop2Btn.Enabled = true;
            crop4Btn.Enabled = true;
            crop2TrianglesBtn.Enabled = true;
            ////////////////////////////
            rotate45Btn.Enabled = true;
            rotate90Btn.Enabled = true;
            rotate180Btn.Enabled = true;
            flipHorizontalBtn.Enabled = true;
            flipVerticalBtn.Enabled = true;
            ////////////////////////////
            redFilter.Enabled = true;
            greenFilter.Enabled = true;
            blueFilter.Enabled = true;
            clearFilter.Enabled = true;
            gcb.Enabled = true;
            ////////////////////////////
            colorPalettePickerBtn.Enabled = true;
            colorMousePickerBtn.Enabled = true;
            selectedColorBox.Enabled = true;
            searchColorBtn.Enabled = true;
            ////////////////////////////
            chromakey.Enabled = true;
        }

        private void loadBtn_Click(object sender, EventArgs e)
        {
            deactivateAllButtonControls();
            OpenFileDialog openFileDialog1 = new OpenFileDialog();

            openFileDialog1.Title = "Select an image file";
            openFileDialog1.Filter = "Image files (*.jpg, *.jpeg, *.png) | *.jpg; *.jpeg; *.png";

            DialogResult result = openFileDialog1.ShowDialog();

            if (result == DialogResult.OK)
            {
                mainImageCopy = mainImage;
                filePath = openFileDialog1.FileName;
                imageCopy = Image.FromFile(filePath);
                mainImage.Image = Image.FromFile(filePath);
                mainImageCopy.Image = Image.FromFile(filePath);
                //mainImageCopy.Width = mainImage.Width;
                //mainImageCopy.Height = mainImage.Height;
                img = Image.FromFile(filePath);
                imageIsSelected = true;
                //imageCopiesList.Add(img);

                activateAllButtonControls();

                unzoomedImg = new Bitmap(mainImage.Image, mainImage.Width, mainImage.Height);

                zoomComboBox.DropDownStyle= ComboBoxStyle.DropDownList;

                string[] zooms =
                {
                    "50%",
                    "100%",
                    "150%",
                    "200%",
                    "300%",
                    "400%",
                    "500%"
                };
                zoomComboBox.Items.Clear();
                zoomComboBox.Items.AddRange(zooms);

                zoomComboBox.SelectedItem = zooms[1];

                imageCopiesList = new List<Image>();
                //imageCopiesList.Add(mainImage.Image);
            }
            activateAllButtonControls();
        }

        private void saveImageBtn_Click(object sender, EventArgs e)
        {
            deactivateAllButtonControls();
            GlobalFunctions.saveImage(mainImage.Image);
            activateAllButtonControls();
        }

        private void propertiesBtn_Click(object sender, EventArgs e)
        {
            deactivateAllButtonControls();
            if (imageIsSelected)
            {
                PropertiesForm propertiesF = new PropertiesForm();
                propertiesF.FilePath = filePath;
                propertiesF.ShowDialog();
            }
            else
            {
                MessageBox.Show("Tem que inserir uma imagem primero!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            activateAllButtonControls();
        }

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                if (cropEnabled)
                {
                    Cursor = Cursors.Cross;
                    cropX = e.X;
                    cropY = e.Y;
                    cropPen = new Pen(Color.Black, 3);
                    cropPen.DashStyle = DashStyle.DashDotDot;
                }
                if (colorPickerEnabled)
                {
                    Bitmap bmp = new Bitmap(mainImage.Image);
                    selectedColorBox.Text = "";
                    selectedColorBox.BackColor = bmp.GetPixel(e.X, e.Y);
                    Cursor = Cursors.Default;
                    colorPickerEnabled = false;
                    activateAllButtonControls();
                    colorMousePickerBtn.Text = "Pick Color (With Mouse)";
                }
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
                imageCopiesList.Add(mainImage.Image);
                mainImage.Image = _img;
                //pictureBox1.Width = _img.Width;
                //pictureBox1.Height = _img.Height;
                activateAllButtonControls();
                cropBtn.Enabled = false;
                cropEnabled = false;
                selectCropAreaBtn.Text = "Select Area";
                //imageCopiesList.Add(mainImage.Image);
            }
        }

        private void selectCropAreaBtn_Click(object sender, EventArgs e)
        {
            if (!cropEnabled) {
                deactivateAllButtonControls();
                cropEnabled = true;
                cropBtn.Enabled = true;
                selectCropAreaBtn.Enabled = true;
                selectCropAreaBtn.Text = "Cancel Crop";
            } else
            {
                activateAllButtonControls();
                selectCropAreaBtn.Text = "Select Area";
                cropEnabled = false;
                cropBtn.Enabled = false;
                Cursor = Cursors.Default;
                cropPen = null;
                mainImage.Refresh();
            }
        }

        private void crop2Btn_Click(object sender, EventArgs e)
        {
            deactivateAllButtonControls();
            Crop2SquareForm crop2SquareForm = new Crop2SquareForm();
            crop2SquareForm.imageToCrop = mainImage;
            DialogResult result = crop2SquareForm.ShowDialog();

            if (result == DialogResult.OK)
            {
                imageCopiesList.Add(mainImage.Image);
                mainImage.Image = crop2SquareForm.newImageToWork;
                //imageCopiesList.Add(mainImage.Image);
                //pictureBox1.Width = crop2SquareForm.newImageToWork.Width;
                //pictureBox1.Height = crop2SquareForm.newImageToWork.Height;
            }
            activateAllButtonControls();
        }

        private void rotate45Btn_Click(object sender, EventArgs e)
        {
            if (mainImage.Image == null)
            {
                return;
            }

            //MessageBox.Show("Picture Box - " + mainImage.Width + "," + mainImage.Height);

            Bitmap OriginalImage = new Bitmap(mainImage.Image, mainImage.Width, mainImage.Height);
            Bitmap _img = Rotate45(OriginalImage, tilted);
            imageCopiesList.Add(mainImage.Image);
            mainImage.Image = _img;
            tilted = !tilted;
        }

        private void crop4Btn_Click(object sender, EventArgs e)
        {
            deactivateAllButtonControls();
            Crop4SquareForm crop4SquareForm = new Crop4SquareForm();
            crop4SquareForm.imageToCrop = mainImage;
            DialogResult result = crop4SquareForm.ShowDialog();

            if (result == DialogResult.OK)
            {
                imageCopiesList.Add(mainImage.Image);
                mainImage.Image = crop4SquareForm.newImageToWork;
                //imageCopiesList.Add(mainImage.Image);
                //pictureBox1.Width = crop4SquareForm.newImageToWork.Width;
                //pictureBox1.Height = crop4SquareForm.newImageToWork.Height;
            }
            activateAllButtonControls();
        }

        private void crop2TrianglesBtn_Click(object sender, EventArgs e)
        {
            deactivateAllButtonControls();
            Crop2TriangleForm crop2TriangleForm = new Crop2TriangleForm();
            crop2TriangleForm.imageToCrop = mainImage;
            DialogResult result = crop2TriangleForm.ShowDialog();

            if (result == DialogResult.OK)
            {
                imageCopiesList.Add(mainImage.Image);
                mainImage.Image = crop2TriangleForm.newImageToWork;
                //imageCopiesList.Add(mainImage.Image);
                //pictureBox1.Width = crop2TriangleForm.newImageToWork.Width;
                //pictureBox1.Height = crop2TriangleForm.newImageToWork.Height;
            }
            activateAllButtonControls();
        }

        private void rotate90Btn_Click(object sender, EventArgs e)
        {
            if (mainImage.Image == null)
            {
                return;
            }

            Bitmap OriginalImage = new Bitmap(mainImage.Image, mainImage.Width, mainImage.Height);
            Bitmap _img = RotateImageN(OriginalImage, 90.0F);
            imageCopiesList.Add(mainImage.Image);
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
            imageCopiesList.Add(mainImage.Image);
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
            imageCopiesList.Add(mainImage.Image);
            Image img = new Bitmap(mainImage.Image);
            //rotate the picture by 90 degrees and re-save the picture as a Jpeg
            img.RotateFlip(RotateFlipType.RotateNoneFlipX);
            mainImage.Image = img;
        } 

        private void flipVBtn_Click(object sender, EventArgs e) {
            if (mainImage.Image == null) {
                return;
            }
            imageCopiesList.Add(mainImage.Image);
            Image img = new Bitmap(mainImage.Image);
            //rotate the picture by 90 degrees and re-save the picture as a Jpeg
            img.RotateFlip(RotateFlipType.RotateNoneFlipY);
            mainImage.Image = img;
        }

        private void redFilter_Click(object sender, EventArgs e)
        {
            imageCopiesList.Add(mainImage.Image);
            Bitmap filteredImage = (Bitmap)mainImage.Image;
            for (int y = 0; y < filteredImage.Height; y++)
            {
                for (int x = 0; x < filteredImage.Width; x++)
                {
                    Color pixelColor = filteredImage.GetPixel(x, y);
                    Color newColor = Color.FromArgb(pixelColor.R, 0, 0);
                    filteredImage.SetPixel(x, y, newColor);
                    mainImage.Image = filteredImage;
                }
            }
            imageHasFilter = true;
        }

        private void greenFilter_Click(object sender, EventArgs e)
        {
            imageCopiesList.Add(mainImage.Image);
            Bitmap filteredImage = (Bitmap)mainImage.Image;
            for (int y = 0; y < filteredImage.Height; y++)
            {
                for (int x = 0; x < filteredImage.Width; x++)
                {
                    Color pixelColor = filteredImage.GetPixel(x, y);
                    Color newColor = Color.FromArgb(0, pixelColor.G, 0);
                    filteredImage.SetPixel(x, y, newColor);
                    mainImage.Image = filteredImage;
                }
            }
            imageHasFilter = true;
        }

        private void blueFilter_Click(object sender, EventArgs e)
        {
            imageCopiesList.Add(mainImage.Image);
            Bitmap filteredImage = (Bitmap)mainImage.Image;
            for (int y = 0; y < filteredImage.Height; y++)
            {
                for (int x = 0; x < filteredImage.Width; x++)
                {
                    Color pixelColor = filteredImage.GetPixel(x, y);
                    Color newColor = Color.FromArgb(0, 0, pixelColor.B);
                    filteredImage.SetPixel(x, y, newColor);
                    mainImage.Image = filteredImage;
                    
                }
            }
            imageHasFilter = true;
        }

        private void clearFilter_Click(object sender, EventArgs e)
        {
            if(imageHasFilter)
            {
                imageHasFilter=false;
            } 
        }

        private void undoBtn_Click(object sender, EventArgs e)
        {
            if (imageCopiesList.Count > 0) {
                mainImage.Image = imageCopiesList[imageCopiesList.Count - 1];
                imageCopiesList.RemoveAt(imageCopiesList.Count - 1);
            }
            if (imageHasFilter)
            {
               mainImage.Image = imageCopy;
            }

            //mainImage.Width = mainImage.Image.Width;
            //mainImage.Height = mainImage.Image.Height;
            mainImage.Width = 450;
            mainImage.Height = 450;
        }

        private void zoomComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

            float[] idx =
            {
                0.5f,
                1f,
                1.5f,
                2f,
                3f,
                4f,
                5f
            };

            float scIdx = idx[zoomComboBox.SelectedIndex];

            Bitmap OriginalImage = new Bitmap(unzoomedImg, unzoomedImg.Width, unzoomedImg.Height);
            Bitmap _img = zoomImage(OriginalImage, scIdx);
            imageCopiesList.Add(mainImage.Image);
            mainImage.Image = _img;
        }

        private Bitmap zoomImage(Bitmap b, float scIdx)
        {
            //Create a new empty bitmap to hold rotated image.
            Bitmap returnBitmap = new Bitmap(b.Width, b.Height);
            //Make a graphics object from the empty bitmap.
            Graphics g = Graphics.FromImage(returnBitmap);
            //move rotation point to center of image.
            //if (scIdx != 0.5) {
            //    g.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.HighQualityBicubic;
            //    float trX = (float)b.Width / scIdx - b.Width;
            //    float trY = (float)b.Height / scIdx - b.Height;
            //    g.TranslateTransform(trX, trY);
            //}
            //else {
            //    g.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.HighQualityBicubic;
            //    float trX = (float)b.Width * scIdx - b.Width;
            //    float trY = (float)b.Height * scIdx - b.Height;
            //    g.TranslateTransform(112, 112);
            //}
            switch (scIdx) {
                case 0.5f:
                    g.TranslateTransform(b.Width/4, b.Height/4);
                    break;
                case 1f:
                    g.TranslateTransform(0, 0); break;
                case 1.5f:
                    g.TranslateTransform(-b.Width/4, -b.Width/4);
                    break;
                case 2f:
                    g.TranslateTransform(-b.Width/2,-b.Height/2); break;
                case 3f:
                    g.TranslateTransform(-b.Width,-b.Height); break;
                case 4f:
                    g.TranslateTransform(-3 * b.Width / 2, -3 * b.Height / 2);
                    break;
                case 5f:
                    g.TranslateTransform(-2*b.Width,-2*b.Height);
                    break;
            }

            //Rotate.        
            g.ScaleTransform(scIdx, scIdx);

            g.DrawImage(b, 0, 0, b.Width, b.Height);
            return returnBitmap;
        }
        private void gbcBtn_Click(object sender, EventArgs e)
        {
            gcbForm gcbForm = new gcbForm();
            gcbForm.imageNow = new Bitmap(mainImage.Image, mainImage.Width, mainImage.Height);
            DialogResult result = gcbForm.ShowDialog();

            if (result == DialogResult.OK)
            {
                imageCopiesList.Add(mainImage.Image);
                mainImage.Image = gcbForm.adjustedImage;
            }

        }

        private void button6_Click(object sender, EventArgs e)
        {
            Bitmap normalImage = new Bitmap(mainImage.Image, mainImage.Width, mainImage.Height);
            Bitmap invertedImage = new Bitmap(normalImage.Width, normalImage.Height);

            for (int x = 0; x < normalImage.Width; x++)
            {
                for (int y = 0; y < normalImage.Height; y++)
                {
                    Color originalColor = normalImage.GetPixel(x, y);
                    Color invertedColor = Color.FromArgb(
                        255 - originalColor.R,
                        255 - originalColor.G,
                        255 - originalColor.B);

                    invertedImage.SetPixel(x, y, invertedColor);
                }
            }
            mainImage.Image = invertedImage;
            imageCopiesList.Add(mainImage.Image);
        }

        private void chromaKey_Click(object sender, EventArgs e)
        {
            chromakey ck = new chromakey();
            DialogResult result = ck.ShowDialog();

            if (result == DialogResult.OK)
            {
                mainImage.Image = ck.finalImage;
                imageCopiesList.Add(mainImage.Image);
            }
        }

        private void colorPalettePickerBtn_Click(object sender, EventArgs e)
        {
            deactivateAllButtonControls();
            ColorDialog color = new ColorDialog();
            color.FullOpen = true;
            if (color.ShowDialog() == DialogResult.OK)
            {
                selectedColorBox.BackColor = color.Color;
                selectedColorBox.Text = "";
                colorPixelsNumberLabel.Visible = false;
            }
            activateAllButtonControls();
        }
        private void colorMousePickerBtn_Click(object sender, EventArgs e)
        {
            if (!colorPickerEnabled)
            {
                deactivateAllButtonControls();
                // Mudar o cursor para um "Color Dropper" quando o mouse se mover no formulário
                Cursor = CreateColorDropperCursor();
                colorPickerEnabled = true;
                colorMousePickerBtn.Text = "Cancel Color Pick";
                colorMousePickerBtn.Enabled = true;
            } else
            {
                activateAllButtonControls();
                colorPickerEnabled = false;
                colorMousePickerBtn.Text = "Pick Color (With Mouse)";
                Cursor = Cursors.Default;
            }
        }

        private Cursor CreateColorDropperCursor()
        {
            // Cria uma imagem de cursor personalizada usando um arquivo de imagem PNG
            // Carregar a imagem de cursor personalizada do arquivo

            string photoRockDirectory = AppDomain.CurrentDomain.BaseDirectory;
            var charsToRemove = new string[] { "\\bin", "\\Release", "\\Debug" };
            foreach (var c in charsToRemove)
            {
                photoRockDirectory = photoRockDirectory.Replace(c, string.Empty);
            }

            Image cursorImage = Image.FromFile(photoRockDirectory + "Resources\\colorPickerIcon.png");

            // Criar um cursor a partir da imagem carregada
            Cursor cursor = new Cursor(new Bitmap(cursorImage).GetHicon());

            return cursor;
        }

        private void searchColorBtn_Click(object sender, EventArgs e)
        {
            //Boolean IsColorFound = false;
            int colorPixelsNumber = 0;
            if (mainImage.Image != null)
            {
                //Converting loaded image into bitmap
                Bitmap bmp = new Bitmap(mainImage.Image);

                //Iterate whole bitmap to findout the picked color
                for (int i = 0; i < mainImage.Image.Height; i++)
                {
                    for (int j = 0; j < mainImage.Image.Width; j++)
                    {
                        //Get the color at each pixel
                        Color now_color = bmp.GetPixel(j, i);

                        //Compare Pixel's Color ARGB property with the picked color's ARGB property
                        if (now_color.ToArgb() == selectedColorBox.BackColor.ToArgb())
                        {
                            colorPixelsNumber++;
                        }
                    }
                }
                if (colorPixelsNumber > 0)
                {
                    if (colorPixelsNumber == 1)
                    {
                        colorPixelsNumberLabel.Text = "Color Found! \r\nThe image contains " + colorPixelsNumber + " pixel of the selected color";
                    }
                    else
                    {
                        colorPixelsNumberLabel.Text = "Color Found! \r\nThe image contains " + colorPixelsNumber + " pixels of the selected color";
                    }
                }
                else
                {
                    colorPixelsNumberLabel.Text = "Color Not Found!";
                }
                colorPixelsNumberLabel.Visible = true;
                colorPixelsNumberLabel.Location = new Point(
                    searchColorBtn.Location.X + searchColorBtn.Width/2 - colorPixelsNumberLabel.Width/2,
                    searchColorBtn.Location.Y + searchColorBtn.Height + 10);
            }
            else
            {
                MessageBox.Show("Image is not loaded");
            }
        }

        private void resize_btn_Click(object sender, EventArgs e)
        {
            // Create a new form for the user to input the width and height values
            var resizeForm = new Form
            {
                Text = "Resize Image",
                Size = new Size(200, 150)
            };

            var widthLabel = new System.Windows.Forms.Label
            {
                Text = "Width:",
                Location = new Point(10, 10),
                Size = new Size(50, 20)
            };
            var heightLabel = new System.Windows.Forms.Label
            {
                Text = "Height:",
                Location = new Point(10, 40),
                Size = new Size(50, 20)
            };

            // Create two text boxes for the user to input the width and height values
            var widthTextBox = new System.Windows.Forms.TextBox
            {
                Location = new Point(60, 10),
                Size = new Size(150, 20)
            };
            var heightTextBox = new System.Windows.Forms.TextBox
            {
                Location = new Point(60, 40),
                Size = new Size(150, 20)
            };

            // Add the text boxes to the form
            resizeForm.Controls.Add(widthLabel);
            resizeForm.Controls.Add(heightLabel);
            resizeForm.Controls.Add(widthTextBox);
            resizeForm.Controls.Add(heightTextBox);

            // Create a button for the user to confirm their input
            var okButton = new System.Windows.Forms.Button
            {
                Text = "OK",
                Location = new Point(70, 80),
                DialogResult = DialogResult.OK
            };

            // Add the OK button to the form
            resizeForm.Controls.Add(okButton);

            // Display the form to the user and wait for them to input the width and height values
            if (resizeForm.ShowDialog() == DialogResult.OK)
            {
                // Retrieve the width and height values from the text boxes
                int width, height;
                if (int.TryParse(widthTextBox.Text, out width) && int.TryParse(heightTextBox.Text, out height))
                {
                    // Set the width and height of the picture box to the user input values
                    mainImage.Width = width;
                    mainImage.Height = height;
                }
                else
                {
                    MessageBox.Show("Invalid input. Please enter a valid integer value for the width and height.");
                }
            }
        }

        private void addElement_btn_Click(object sender, EventArgs e)
        {
            // Create a new form for the user to input the text or image file path
            var addForm = new Form
            {
                Text = "Add Image or Text",
                Size = new Size(350, 150)
            };

            // Create a label for the file path text box
            var filePathLabel = new System.Windows.Forms.Label
            {
                Text = "File Path or Text:",
                Location = new Point(10, 10),
                Size = new Size(100, 20)
            };

            // Create a text box for the user to input the file path or text
            var filePathTextBox = new System.Windows.Forms.TextBox
            {
                Location = new Point(120, 10),
                Size = new Size(200, 20)
            };

            // Create a button for the user to browse for an image file
            var browseButton = new System.Windows.Forms.Button
            {
                Text = "Browse",
                Location = new Point(10, 40),
                Size = new Size(80, 23)
            };

            // Create a button for the user to confirm their input
            var okButton = new System.Windows.Forms.Button
            {
                Text = "OK",
                Location = new Point(170, 70),
                DialogResult = DialogResult.OK
            };

            // Add event handler to browse button to open a file dialog when clicked
            browseButton.Click += (s, ea) =>
            {
                var openFileDialog = new OpenFileDialog
                {
                    Filter = "Image Files (*.jpg, *.jpeg, *.png, *.gif)|*.jpg;*.jpeg;*.png;*.gif|All Files (*.*)|*.*"
                };
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    filePathTextBox.Text = openFileDialog.FileName;
                }
            };

            // Add the label, text box, browse button, and OK button to the form
            addForm.Controls.Add(filePathLabel);
            addForm.Controls.Add(filePathTextBox);
            addForm.Controls.Add(browseButton);
            addForm.Controls.Add(okButton);

            // Display the form to the user and wait for them to input the file path or text
            if (addForm.ShowDialog() == DialogResult.OK)
            {
                // Check if the user input a file path or text
                if (!string.IsNullOrEmpty(filePathTextBox.Text))
                {
                    // Check if the user input a valid image file path
                    if (File.Exists(filePathTextBox.Text) && Image.FromFile(filePathTextBox.Text) != null)
                    {
                        // Create a new Bitmap from the existing picture box image
                        var bitmap = new Bitmap(mainImage.Image);

                        // Load the new image file and draw it on top of the existing image
                        var newImage = Image.FromFile(filePathTextBox.Text);
                        var graphics = Graphics.FromImage(bitmap);
                        graphics.DrawImage(newImage, 0, 0, mainImage.Width, mainImage.Height);

                        // Set the updated image as the picture box image
                        mainImage.Image = bitmap;
                    }
                    else
                    {
                        // If the user input a text, add it as a new Label control on top of the existing image
                        var label = new System.Windows.Forms.Label
                        {
                            Text = filePathTextBox.Text,
                            Location = new Point(10, 10),
                            AutoSize = true,
                            ForeColor = Color.Red
                        };
                        mainImage.Controls.Add(label);
                    }
                }
            }
        }
    }
}
