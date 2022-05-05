using System;
using System.Windows.Forms;

namespace Assignment
{
    public partial class CreditCardDisplay : Form
    {
        private CreditCard crCard = new CreditCard();
        public CreditCardDisplay()
        {
            InitializeComponent();
        }

        public CreditCard CrCard
        {
            set => this.crCard = value;
        }

        private void CreditCardDisplay_Load(object sender, EventArgs e)
        {
            lblName.Text = crCard.Name;
            txtCardholderName.Text = crCard.CardholderName;
            txtCsc.Text = crCard.Csc;
            txtPan.Text = crCard.Pan;
            txtExpDate.Text = crCard.ExpDate.ToString("M/yyyy");
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
