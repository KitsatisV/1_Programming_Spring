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

        //public string GetImageFilter()
        //{
        //    StringBuilder allImageExtensions = new StringBuilder();
        //    string separator = "";
        //    ImageCodecInfo[] codecs = ImageCodecInfo.GetImageEncoders();
        //    Dictionary<string, string> images = new Dictionary<string, string>();
        //    foreach (ImageCodecInfo codec in codecs)
        //    {
        //        allImageExtensions.Append(separator);
        //        allImageExtensions.Append(codec.FilenameExtension);
        //        separator = ";";
        //        images.Add(string.Format("{0} Files: ({1})", codec.FormatDescription, codec.FilenameExtension),
        //                   codec.FilenameExtension);
        //    }
        //    StringBuilder sb = new StringBuilder();
        //    if (allImageExtensions.Length > 0)
        //    {
        //        sb.AppendFormat("{0}|{1}", "All Images", allImageExtensions.ToString());
        //    }
        //    foreach (KeyValuePair<string, string> image in images)
        //    {
        //        sb.AppendFormat("|{0}|{1}", image.Key, image.Value);
        //    }
        //    return sb.ToString();
        //}

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog
            {
                InitialDirectory = @"D:\",
                Title = "Browse Image Files",

                CheckFileExists = true,
                CheckPathExists = true,

                Filter = "All Images | *.BMP; *.RLE; *.JPG; *.JPEG; *.JPE; *.JFIF; *.GIF; *.TIF; *.TIFF; *.PNG",
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
            if (txtName.Text.Length != 0 && txtImageFilePath.Text.Length != 0)
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
            //add preview and figure out how to edit -> (use _temp64 instead of txtFilePath)
        }
    }
}
