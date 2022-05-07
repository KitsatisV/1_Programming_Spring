using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment
{
    public partial class ImageEdit : Form
    {
        private ImageCard _image = new ImageCard();
        string _temp64;
        public ImageEdit()
        {
            InitializeComponent();
        }

        public ImageCard _Image
        {
            get { return _image; }
            set { _image = value; }
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog
            {
                InitialDirectory = @"D:\",
                Title = "Browse Image Files",

                CheckFileExists = true,
                CheckPathExists = true,

                Filter = "All Images (*.BMP, *.RLE, *.JPG, *.JPEG, *.JPE, *.JFIF, *.GIF, *.TIF, *.TIFF, *.PNG) | *.BMP; *.RLE; *.JPG; *.JPEG; *.JPE; *.JFIF; *.GIF; *.TIF; *.TIFF; *.PNG",
                FilterIndex = 2,
                RestoreDirectory = true,

                ReadOnlyChecked = true,
                ShowReadOnly = true
            };

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                if(openFileDialog1.FileName != null || openFileDialog1.FileName != "")
                {
                    txtImageFilePath.Text = openFileDialog1.FileName;
                    _temp64 = Convert.ToBase64String(File.ReadAllBytes(openFileDialog1.FileName));
                    pcbPreview.Image = ImgPreview(_temp64);
                }
                else
                {
                    MessageBox.Show("Error in loading image file!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void txtName_Enter(object sender, EventArgs e)
        {
            SaveDisabled();
            if (txtName.Text.Length == 0)
            {
                txtName.BackColor = Color.MistyRose;
            }
            else
            {
                txtName.BackColor = Color.White;
            }
        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {
            SaveDisabled();
            if (txtName.Text.Length == 0)
            {
                txtName.BackColor = Color.MistyRose;
            }
            else
            {
                txtName.BackColor = Color.White;
            }
        }

        private void txtImageFilePath_TextChanged(object sender, EventArgs e)
        {
            SaveDisabled();
            if (txtImageFilePath.Text.Length == 0)
            {
                txtImageFilePath.BackColor = Color.MistyRose;
            }
            else
            {
                txtImageFilePath.BackColor = Color.White;
            }
        }

        private void txtImageFilePath_Enter(object sender, EventArgs e)
        {
            SaveDisabled();
            if (txtImageFilePath.Text.Length == 0)
            {
                txtImageFilePath.BackColor = Color.MistyRose;
            }
            else
            {
                txtImageFilePath.BackColor = Color.White;
            }
        }

        private void SaveDisabled()
        {
            if (txtName.Text.Length != 0 && ((pcbPreview.Image == null && txtImageFilePath.Text.Length != 0) || pcbPreview.Image != null))
            {
                btnSave.Enabled = true;
            }
            else
            {
                btnSave.Enabled = false;
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            _image.Name = txtName.Text;
            _image.Base64string = _temp64;
            Close();
        }

        private void ImageEdit_Load(object sender, EventArgs e)
        {
            txtName.Text = _image.Name;
            _temp64 = _image.Base64string;
            pcbPreview.Image = ImgPreview(_temp64);
        }

        private Image ImgPreview(string str64)
        {
            if (str64 != string.Empty)
            {
                byte[] bytes = Convert.FromBase64String(str64);
                using (MemoryStream ms = new MemoryStream(bytes))
                {
                    return Image.FromStream(ms);
                }
            }
            return null;
        }
    }
}
