using System;
using System.Drawing;
using System.Windows.Forms;

namespace Assignment
{
    public partial class CreditCardEdit : Form
    {
        private CreditCard crCard = new CreditCard();
        public CreditCardEdit()
        {
            InitializeComponent();
        }

        public CreditCard CrCard
        {
            get => crCard;
            set => crCard = value;
        }

        #region CardholderNameChecks
        private void txtCardholderName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(e.KeyChar == char.ToUpper(e.KeyChar)))
            {
                e.KeyChar = char.ToUpper(e.KeyChar);
            }
        }

        private void txtCardholderName_TextChanged(object sender, EventArgs e)
        {
            SaveDisabled();
            if (txtCardholderName.Text.Length == 0)
            {
                txtCardholderName.BackColor = Color.MistyRose;
            }
            else
            {
                txtCardholderName.BackColor = Color.White;
            }
        }

        private void txtCardholderName_Enter(object sender, EventArgs e)
        {
            SaveDisabled();
            if (txtCardholderName.Text.Length == 0)
            {
                txtCardholderName.BackColor = Color.MistyRose;
            }
            else
            {
                txtCardholderName.BackColor = Color.White;
            }
        }
        #endregion

        #region PanChecks
        private void txtPan_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsDigit(e.KeyChar)) && !(e.KeyChar == '\b'))
            {
                e.Handled = true;
            }
        }

        private void txtPan_TextChanged(object sender, EventArgs e)
        {
            SaveDisabled();
            if (txtPan.Text.Length < 10)
            {
                txtPan.BackColor = Color.MistyRose;
            }
            else
            {
                txtPan.BackColor = Color.White;
            }
        }

        private void txtPan_Enter(object sender, EventArgs e)
        {
            SaveDisabled();
            if (txtPan.Text.Length < 10)
            {
                txtPan.BackColor = Color.MistyRose;
            }
            else
            {
                txtPan.BackColor = Color.White;
            }
        }
        #endregion

        #region CSCChecks
        private void txtCSC_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsDigit(e.KeyChar)) && !(e.KeyChar == '\b'))
            {
                e.Handled = true;
            }
        }

        private void txtCSC_TextChanged(object sender, EventArgs e)
        {
            SaveDisabled();
            if (txtCSC.Text.Length < 3)
            {
                txtCSC.BackColor = Color.MistyRose;
            }
            else
            {
                txtCSC.BackColor = Color.White;
            }
        }

        private void txtCSC_Enter(object sender, EventArgs e)
        {
            SaveDisabled();
            if (txtCSC.Text.Length < 3)
            {
                txtCSC.BackColor = Color.MistyRose;
            }
            else
            {
                txtCSC.BackColor = Color.White;
            }
        }
        #endregion

        #region NameChecks
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
        #endregion

        #region DateChecks
        private void cmbExpMonth_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbDateCheck();
        }

        private void cmbExpYear_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbDateCheck();
        }

        private void cmbExpYear_Enter(object sender, EventArgs e)
        {
            cmbDateCheck();
        }

        private void cmbExpMonth_Enter(object sender, EventArgs e)
        {
            cmbDateCheck();
        }

        private void cmbDateCheck()
        {
            SaveDisabled();
            if (cmbExpMonth.SelectedItem == null || cmbExpYear.SelectedItem == null)
            {
                return;
            }
            else if (int.Parse(cmbExpYear.SelectedItem.ToString()) < DateTime.Today.Year || (int.Parse(cmbExpYear.SelectedItem.ToString()) >= DateTime.Today.Year && cmbExpMonth.SelectedIndex + 1 < DateTime.Today.Month))
            {
                if (int.Parse(cmbExpYear.SelectedItem.ToString()) < DateTime.Today.Year)
                {
                    pnlYear.BackColor = Color.Red;
                    pnlMonth.BackColor = Color.White;
                }
                else if (int.Parse(cmbExpYear.SelectedItem.ToString()) >= DateTime.Today.Year && cmbExpMonth.SelectedIndex + 1 < DateTime.Today.Month)
                {
                    pnlYear.BackColor = Color.White;
                    pnlMonth.BackColor = Color.Red;
                }
            }
            else
            {
                pnlYear.BackColor = Color.White;
                pnlMonth.BackColor = Color.White;
            }
        }

        private string ExpDate()
        {
            return string.Format("{0}/{1}", cmbExpMonth.SelectedIndex + 1, cmbExpYear.SelectedItem);
        }
        #endregion

        private void SaveDisabled()
        {
            if (txtName.TextLength == 0 || txtCardholderName.TextLength == 0 || txtPan.TextLength < 10 || txtCSC.TextLength < 3)
            {
                btnSave.Enabled = false;
            }
            else if (cmbExpYear.SelectedItem == null || cmbExpMonth.SelectedItem == null)
            {
                btnSave.Enabled = false;
            }
            else if (int.Parse(cmbExpYear.SelectedItem.ToString()) < DateTime.Today.Year || (int.Parse(cmbExpYear.SelectedItem.ToString()) >= DateTime.Today.Year && cmbExpMonth.SelectedIndex + 1 < DateTime.Today.Month))
            {
                btnSave.Enabled = false;
            }
            else
            {
                btnSave.Enabled = true;
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
                crCard.ExpDate = DateTime.ParseExact(ExpDate(), "M/yyyy", null);
                crCard.Name = txtName.Text;
                crCard.CardholderName = txtCardholderName.Text;
                crCard.Pan = txtPan.Text;
                crCard.Csc = txtCSC.Text;
                Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void CreditCardEdit_Load(object sender, EventArgs e)
        {
            txtName.Text = crCard.Name;
            txtCardholderName.Text = crCard.CardholderName;
            txtPan.Text = crCard.Pan.ToString();
            txtCSC.Text = crCard.Csc.ToString();
            cmbExpMonth.SelectedIndex = Int32.Parse(crCard.ExpDate.ToString("M/yyyy").Split('/')[0]) - 1;
            cmbExpYear.SelectedItem = crCard.ExpDate.ToString("M/yyyy").Split('/')[1];
        }
    }
}
