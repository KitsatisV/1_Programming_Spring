using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment
{
    public class ImageCard : IInfoCard
    {
        //fields
        private string _name;
        private string _base64string;
        private ImageDisplay _imageDisplayForm;

        //gets-sets
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

        //constructors
        public ImageCard()
        {
            _name = String.Empty;
            _base64string = String.Empty;
        }

        public ImageCard(string txt)
        {
            string[] imageInfo = txt.Split('|');
            if (imageInfo.Length != 2)
            {
                throw new Exception("Invalid data for Airline Ticket InfoCard");
            }
            else
            {
                _name = imageInfo[0];
                _base64string = imageInfo[1];
            }
        }

        //methods
        public string Category => "Image";

        public void CloseDisplay()
        {
            if (_imageDisplayForm != null)
            {
                _imageDisplayForm.Close();
                _imageDisplayForm = null;
            }
        }

        public void DisplayData(Panel displayPanel)
        {
            CloseDisplay();
            _imageDisplayForm = new ImageDisplay();
            _imageDisplayForm._Image = this;
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
                return false;
            }
            return true;
        }

        public string GetDataAsString()
        {
            return string.Format("Image|{0}|{1}", _name, _base64string);
        }
    }
}
