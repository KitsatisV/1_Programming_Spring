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

namespace Assignment
{
    public partial class ImageDisplay : Form
    {
        private ImageCard _image = new ImageCard();
        public ImageDisplay()
        {
            InitializeComponent();
        }

        public ImageCard _Image
        {
            get { return _image; }
            set { _image = value; }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void ImageDisplay_Load(object sender, EventArgs e)
        {
            this.Text = _image.Name;
            byte[] bytes = Convert.FromBase64String(_image.Base64string);

            using (MemoryStream ms = new MemoryStream(bytes))
            {
                pcbImage.Image = Image.FromStream(ms);
            }
        }
    }
}
