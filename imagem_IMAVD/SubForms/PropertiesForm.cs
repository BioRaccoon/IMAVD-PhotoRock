using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PhotoRock
{
    public partial class PropertiesForm : Form
    {
        public string FilePath { get; set; }
        public PropertiesForm()
        {
            InitializeComponent();
        }

        private void propertiesForm_Load(object sender, EventArgs e)
        {
            string fileName = Path.GetFileNameWithoutExtension(FilePath);
            string fileExtension = Path.GetExtension(FilePath);
            Image image = Image.FromFile(FilePath);
            int width = image.Width;
            int height = image.Height;
            string resolution = width.ToString() + " x " + height.ToString();
            long sizeInBytes = new FileInfo(FilePath).Length;
            double sizeInKb = sizeInBytes / 1024.0;
            int sizeInKbInt = Convert.ToInt32(sizeInKb);
            DateTime creationTime = File.GetCreationTime(FilePath);

            image_name.Text = fileName;
            image_extension.Text = fileExtension;
            image_location.Text = FilePath;
            image_dimension.Text = resolution;
            image_size.Text = sizeInKbInt.ToString() + " KB";
            image_createdon.Text = creationTime.ToString();
        }

    }
}
