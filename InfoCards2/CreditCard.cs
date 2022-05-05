using System;
using System.Windows.Forms;

namespace Assignment
{
    public class CreditCard : IInfoCard
    {
        //fields    
        private string _pan;
        private string _cardholderName;
        private string _csc;
        private DateTime _expDate;
        private string _name;
        private CreditCardDisplay _creditCardDisplayForm;

        //get-set
        public DateTime ExpDate
        {
            get { return _expDate; }
            set { _expDate = value; }
        }

        public string Csc
        {
            get { return _csc; }
            set { _csc = value; }
        }

        public string CardholderName
        {
            get { return _cardholderName; }
            set { _cardholderName = value; }
        }

        public string Pan
        {
            get { return _pan; }
            set { _pan = value; }
        }

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        public string Category
        {
            get { return "Credit Card"; }
        }

        //constructors
        public CreditCard()
        {
            this._pan = String.Empty;
            this._cardholderName = String.Empty;
            this._csc = String.Empty;
            this._expDate = DateTime.ParseExact(DateTime.Today.ToString("M/yyyy"), "M/yyyy", null);
            this._name = String.Empty;
        }
        public CreditCard(string txt)
        {
            string[] CreditCardInfo = txt.Split('|');
            if (CreditCardInfo.Length != 5)
            {
                throw new Exception("Invalid data for Credit Card InfoCard");
            }
            else
            {
                _pan = (CreditCardInfo[1]);
                _cardholderName = CreditCardInfo[2];
                _csc = (CreditCardInfo[3]);
                _expDate = DateTime.ParseExact(CreditCardInfo[4], "M/yyyy", null);
                _name = CreditCardInfo[0];
            }
        }

        //methods
        public string GetDataAsString()
        {
            return string.Format("Credit Card|{0}|{1}|{2}|{3}|{4}", _name, _pan, _cardholderName, _csc, _expDate.ToString("M/yyyy"));
        }

        public void DisplayData(Panel displayPanel)
        {
            CloseDisplay();
            _creditCardDisplayForm = new CreditCardDisplay();
            _creditCardDisplayForm.CrCard = this;
            _creditCardDisplayForm = new CreditCardDisplay()
            {
                Dock = DockStyle.Fill,
                TopLevel = false,
                Parent = displayPanel,
                CrCard = this,
                FormBorderStyle = FormBorderStyle.None,
                Height = displayPanel.Height,
                Width = displayPanel.Width,
                Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right
            };
            _creditCardDisplayForm.Show();
        }

        public void CloseDisplay()
        {
            if (_creditCardDisplayForm != null)
            {
                _creditCardDisplayForm.Close();
                _creditCardDisplayForm = null;
            }
        }

        public bool EditData()
        {
            CreditCardEdit creditCardEdit = new CreditCardEdit()
            {
                CrCard = this
            };
            if (creditCardEdit.ShowDialog() == DialogResult.OK)
            {
                _cardholderName = creditCardEdit.CrCard._cardholderName;
                _pan = creditCardEdit.CrCard.Pan;
                _csc = creditCardEdit.CrCard._csc;
                _expDate = creditCardEdit.CrCard._expDate;
                _name = creditCardEdit.CrCard._name;
                return false;
            }
            return true;
        }
    }
}
