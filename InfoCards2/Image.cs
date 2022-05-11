using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment
{
    public class Image : IInfoCard
    {
        #region fields
        private string _name;
        private string _base64string;
        private ImageDisplay _imageDisplayForm;
        #endregion

        #region get-sets
        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        public string Base64string
        {
            get { return _base64string; }
            set { _base64string = value; }
        }
        #endregion

        #region constructors
        public Image()
        {
            _name = String.Empty;
            _base64string = String.Empty;
        }

        public Image(string txt)
        {
            string[] imageInfo = txt.Split('|');
            if (imageInfo.Length != 2)
            {
                throw new Exception("Invalid data for Image InfoCard");
            }
            else
            {
                _name = imageInfo[0];
                _base64string = imageInfo[1];
            }
        }
        #endregion

        #region methods
        public string Category => "Image";

        public void CloseDisplay()
        {
            if (_imageDisplayForm != null)
            {
                _imageDisplayForm.Close();
                _imageDisplayForm.Dispose();
            }
        }

        public void DisplayData(Panel displayPanel)
        {
            CloseDisplay();
            _imageDisplayForm = new ImageDisplay
            {
                _Image = this
            };
            _imageDisplayForm.Show();
        }

        public bool EditData()
        {
            ImageEdit _imageEdit = new ImageEdit()
            {
                _Image = this
            };
            if (_imageEdit.ShowDialog() == DialogResult.OK)
            {
                _name = _imageEdit._Image._name;
                _base64string = _imageEdit._Image._base64string;
                return true;
            }
            return false;
        }

        public string GetDataAsString()
        {
            return string.Format("Image|{0}|{1}", _name, _base64string);
        }
        #endregion
    }
}
