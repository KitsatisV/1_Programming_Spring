using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment
{
    public partial class AirlineTicketEdit : Form
    {
        private AirlineTicket airTicket = new AirlineTicket();
        private readonly Regex rx = new Regex("[A-Z]{2}[0-9]{1,3}");
        private readonly Regex rx3 = new Regex("[A-Z]{2}[0-9]{1}");
        private readonly Regex rx4 = new Regex("[A-Z]{2}[0-9]{2}");
        private readonly Regex rx5 = new Regex("[A-Z]{2}[0-9]{3}");

        public AirlineTicketEdit()
        {
            InitializeComponent();
        }

        public AirlineTicket AirTicket
        {
            get { return airTicket; }
            set { airTicket = value; }
        }

        private void txtInfoCardName_Enter(object sender, EventArgs e)
        {
            if(txtInfoCardName.Text.Length == 0)
            {
                txtInfoCardName.BackColor = Color.MistyRose;
            }
            else
            {
                txtInfoCardName.BackColor = Color.White;
            }
            SaveDisabled();
        }

        private void txtInfoCardName_TextChanged(object sender, EventArgs e)
        {
            if (txtInfoCardName.Text.Length == 0)
            {
                txtInfoCardName.BackColor = Color.MistyRose;
            }
            else
            {
                txtInfoCardName.BackColor = Color.White;
            }
            SaveDisabled();
        }

        private void txtTicketNumber_Enter(object sender, EventArgs e)
        {
            if (txtTicketNumber.Text.Length == 0)
            {
                txtTicketNumber.BackColor = Color.MistyRose;
            }
            else
            {
                txtTicketNumber.BackColor = Color.White;
            }
            SaveDisabled();
        }

        private void txtTicketNumber_TextChanged(object sender, EventArgs e)
        {
            if (txtTicketNumber.Text.Length == 0)
            {
                txtTicketNumber.BackColor = Color.MistyRose;
            }
            else
            {
                txtTicketNumber.BackColor = Color.White;
            }
            SaveDisabled();
        }

        private void txtTicketNumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(!char.IsDigit(e.KeyChar) && !(e.KeyChar == '\b'))
            {
                e.Handled = true;
            }
        }

        private void txtAirportFrom_Enter(object sender, EventArgs e)
        {
            if (txtAirportFrom.Text.Length < 3)
            {
                txtAirportFrom.BackColor = Color.MistyRose;
            }
            else
            {
                txtAirportFrom.BackColor = Color.White;
            }
            SaveDisabled();
        }

        private void txtAirportFrom_TextChanged(object sender, EventArgs e)
        {
            if (txtAirportFrom.Text.Length < 3)
            {
                txtAirportFrom.BackColor = Color.MistyRose;
            }
            else
            {
                txtAirportFrom.BackColor = Color.White;
            }
            SaveDisabled();
        }

        private void txtAirportFrom_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(!char.IsLetter(e.KeyChar) && !(e.KeyChar == '\b'))
            {
                e.Handled = true;
            }
            else if(char.IsLetter(e.KeyChar) && !(e.KeyChar == '\b'))
            {
                if (!char.IsUpper(e.KeyChar))
                {
                    e.KeyChar = char.ToUpper(e.KeyChar);
                }
            }
        }

        private void txtAirportTo_Enter(object sender, EventArgs e)
        {
            if (txtAirportTo.Text.Length < 3)
            {
                txtAirportTo.BackColor = Color.MistyRose;
            }
            else
            {
                txtAirportTo.BackColor = Color.White;
            }
            SaveDisabled();
        }

        private void txtAirportTo_TextChanged(object sender, EventArgs e)
        {
            if (txtAirportTo.Text.Length < 3)
            {
                txtAirportTo.BackColor = Color.MistyRose;
            }
            else
            {
                txtAirportTo.BackColor = Color.White;
            }
            SaveDisabled();
        }

        private void txtAirportTo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !(e.KeyChar == '\b'))
            {
                e.Handled = true;
            }
            else if (char.IsLetter(e.KeyChar) && !(e.KeyChar == '\b'))
            {
                if (!char.IsUpper(e.KeyChar))
                {
                    e.KeyChar = char.ToUpper(e.KeyChar);
                }
            }
        }

        private void txtPassengerName_Enter(object sender, EventArgs e)
        {
            if (txtPassengerName.Text.Length == 0)
            {
                txtPassengerName.BackColor = Color.MistyRose;
            }
            else
            {
                txtPassengerName.BackColor = Color.White;
            }
            SaveDisabled();
        }

        private void txtPassengerName_TextChanged(object sender, EventArgs e)
        {
            if (txtPassengerName.Text.Length == 0)
            {
                txtPassengerName.BackColor = Color.MistyRose;
            }
            else
            {
                txtPassengerName.BackColor = Color.White;
            }
            SaveDisabled();
        }

        private void txtPassengerName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !(e.KeyChar == '\b') && !(e.KeyChar == ' '))
            {
                e.Handled = true;
            }
            else if (char.IsLetter(e.KeyChar) && !(e.KeyChar == '\b') && !(e.KeyChar == ' '))
            {
                if (!char.IsUpper(e.KeyChar))
                {
                    e.KeyChar = char.ToUpper(e.KeyChar);
                }
            }
        }

        private void txtIssuingAirline_Enter(object sender, EventArgs e)
        {
            if (txtIssuingAirline.Text.Length == 0)
            {
                txtIssuingAirline.BackColor = Color.MistyRose;
            }
            else
            {
                txtIssuingAirline.BackColor = Color.White;
            }
            SaveDisabled();
        }

        private void txtIssuingAirline_TextChanged(object sender, EventArgs e)
        {
            if (txtIssuingAirline.Text.Length == 0)
            {
                txtIssuingAirline.BackColor = Color.MistyRose;
            }
            else
            {
                txtIssuingAirline.BackColor = Color.White;
            }
            SaveDisabled();
        }

        private void txtIssuingAirline_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !(e.KeyChar == '\b') && !(e.KeyChar == ' '))
            {
                e.Handled = true;
            }
            else if (char.IsLetter(e.KeyChar) && !(e.KeyChar == '\b') && !(e.KeyChar == ' '))
            {
                if (!char.IsUpper(e.KeyChar))
                {
                    e.KeyChar = char.ToUpper(e.KeyChar);
                }
            }
        }

        private void dtpDate_Enter(object sender, EventArgs e)
        {
            pnlDate.BackColor = DateTime.Compare(dtpDate.Value.Date, DateTime.Now.Date) < 0 ? Color.Red : Color.White;
            if (DateTime.Compare(GetDateTime(), DateTime.Now) < 0 && DateTime.Compare(dtpDate.Value.Date, DateTime.Now.Date) == 0)
            {
                pnlTime.BackColor = Color.Red;
            }
            else
            {
                pnlTime.BackColor = Color.White;
            }
            SaveDisabled();
        }

        private void dtpDate_ValueChanged(object sender, EventArgs e)
        {
            pnlDate.BackColor = DateTime.Compare(dtpDate.Value.Date, DateTime.Now.Date) < 0 ? Color.Red : Color.White;
            if (DateTime.Compare(GetDateTime(), DateTime.Now) < 0 && DateTime.Compare(dtpDate.Value.Date, DateTime.Now.Date) == 0)
            {
                pnlTime.BackColor = Color.Red;
            }
            else
            {
                pnlTime.BackColor = Color.White;
            }
            SaveDisabled();
        }

        private void dtpTime_Enter(object sender, EventArgs e)
        {
            if(DateTime.Compare(GetDateTime(), DateTime.Now) < 0 && DateTime.Compare(dtpDate.Value.Date, DateTime.Now.Date) == 0)
            {
                pnlTime.BackColor = Color.Red;
            }
            else
            {
                pnlTime.BackColor = Color.White;
            }
            SaveDisabled();
        }

        private void dtpTime_ValueChanged(object sender, EventArgs e)
        {
            if (DateTime.Compare(GetDateTime(), DateTime.Now) < 0 && DateTime.Compare(dtpDate.Value.Date, DateTime.Now.Date) == 0)
            {
                pnlTime.BackColor = Color.Red;
            }
            else
            {
                pnlTime.BackColor = Color.White;
            }
            SaveDisabled();
        }

        private void txtFlightCode_Enter(object sender, EventArgs e)
        {
            if(txtFlightCode.Text.Length < 3 || !rx.IsMatch(txtFlightCode.Text))
            {
                txtFlightCode.BackColor = Color.MistyRose;
            }
            else
            {
                txtFlightCode.BackColor= Color.White;
            }
            SaveDisabled();
        }

        private void txtFlightCode_TextChanged(object sender, EventArgs e)
        {
            if (txtFlightCode.Text.Length < 3)
            {
                if(!rx.IsMatch(txtFlightCode.Text))
                {
                    txtFlightCode.BackColor = Color.MistyRose;
                }
            }
            else if(txtFlightCode.Text.Length >= 3)
            {
                switch(txtFlightCode.Text.Length)
                {
                    case 3:
                        {
                            if(!rx3.IsMatch(txtFlightCode.Text))
                            {
                                if (!char.IsLetter(txtFlightCode.Text[0]))
                                {
                                    txtFlightCode.Text = txtFlightCode.Text.Remove(0, 1);
                                    txtFlightCode.Select(txtFlightCode.Text.Length, 0);
                                }
                                else if (!char.IsLetter(txtFlightCode.Text[1]))
                                {
                                    txtFlightCode.Text = txtFlightCode.Text.Remove(1, 1);
                                    txtFlightCode.Select(txtFlightCode.Text.Length, 0);
                                }
                                else if (!char.IsDigit(txtFlightCode.Text[2]))
                                {
                                    txtFlightCode.Text = txtFlightCode.Text.Remove(2, 1);
                                    txtFlightCode.Select(txtFlightCode.Text.Length, 0);
                                }
                            }
                            else
                            {
                                txtFlightCode.BackColor = Color.White;
                            }
                        }
                            break;
                    case 4:
                        {
                            if (!rx4.IsMatch(txtFlightCode.Text))
                            {
                                if (!char.IsLetter(txtFlightCode.Text[0]))
                                {
                                    txtFlightCode.Text = txtFlightCode.Text.Remove(0, 1);
                                    txtFlightCode.Select(txtFlightCode.Text.Length, 0);
                                }
                                else if (!char.IsLetter(txtFlightCode.Text[1]))
                                {
                                    txtFlightCode.Text = txtFlightCode.Text.Remove(1, 1);
                                    txtFlightCode.Select(txtFlightCode.Text.Length, 0);
                                }
                                else if (!char.IsDigit(txtFlightCode.Text[2]))
                                {
                                    txtFlightCode.Text = txtFlightCode.Text.Remove(2, 1);
                                    txtFlightCode.Select(txtFlightCode.Text.Length, 0);
                                }
                                else if (!char.IsDigit(txtFlightCode.Text[3]))
                                {
                                    txtFlightCode.Text = txtFlightCode.Text.Remove(3, 1);
                                    txtFlightCode.Select(txtFlightCode.Text.Length, 0);
                                }
                            }
                            else
                            {
                                txtFlightCode.BackColor = Color.White;
                            }
                        }
                        break;
                    case 5:
                        {
                            if(!rx5.IsMatch(txtFlightCode.Text))
                            {
                                if (!char.IsLetter(txtFlightCode.Text[0]))
                                {
                                    txtFlightCode.Text = txtFlightCode.Text.Remove(0, 1);
                                    txtFlightCode.Select(txtFlightCode.Text.Length, 0);
                                }
                                else if (!char.IsLetter(txtFlightCode.Text[1]))
                                {
                                    txtFlightCode.Text = txtFlightCode.Text.Remove(1, 1);
                                    txtFlightCode.Select(txtFlightCode.Text.Length, 0);
                                }
                                else if (!char.IsDigit(txtFlightCode.Text[2]))
                                {
                                    txtFlightCode.Text = txtFlightCode.Text.Remove(2, 1);
                                    txtFlightCode.Select(txtFlightCode.Text.Length, 0);
                                }
                                else if (!char.IsDigit(txtFlightCode.Text[3]))
                                {
                                    txtFlightCode.Text = txtFlightCode.Text.Remove(3, 1);
                                    txtFlightCode.Select(txtFlightCode.Text.Length, 0);
                                }
                                else if (!char.IsDigit(txtFlightCode.Text[4]))
                                {
                                    txtFlightCode.Text = txtFlightCode.Text.Remove(4, 1);
                                    txtFlightCode.Select(txtFlightCode.Text.Length, 0);
                                }
                            }
                            else
                            {
                                txtFlightCode.BackColor = Color.White;
                            }
                        }
                        break;
                }
            }
            else
            {
                txtFlightCode.BackColor = Color.White;
            }
            SaveDisabled();
        }

        private void txtFlightCode_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(txtFlightCode.Text.Length < 2)
            {
                if(!char.IsLetter(e.KeyChar) && e.KeyChar != '\b')
                {
                    e.Handled = true;
                }
                else if(char.IsLetter(e.KeyChar) && !char.IsUpper(e.KeyChar))
                {
                    e.KeyChar = char.ToUpper(e.KeyChar);
                }
            }
        }

        private DateTime GetDateTime()
        {
            return dtpDate.Value.Date + dtpTime.Value.TimeOfDay;
        }

        private void SaveDisabled()
        {
            if(txtAirportFrom.BackColor == Color.MistyRose || txtAirportFrom.Text.Length == 0 || txtAirportTo.BackColor == Color.MistyRose || txtAirportTo.Text.Length == 0 || txtFlightCode.BackColor == Color.MistyRose || txtFlightCode.Text.Length == 0 || txtInfoCardName.BackColor == Color.MistyRose || txtInfoCardName.Text.Length == 0 || txtIssuingAirline.BackColor == Color.MistyRose || txtIssuingAirline.Text.Length == 0 || txtPassengerName.BackColor == Color.MistyRose || txtPassengerName.Text.Length == 0 || txtTicketNumber.BackColor == Color.MistyRose || txtTicketNumber.Text.Length == 0 || pnlDate.BackColor == Color.MistyRose || pnlTime.BackColor == Color.MistyRose || DateTime.Compare(GetDateTime(), DateTime.Now) <= 0)
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
            airTicket.Name = txtInfoCardName.Text;
            airTicket.PassengerName = txtPassengerName.Text;
            airTicket.IssuingAirline = txtIssuingAirline.Text;
            airTicket.TicketNumber = txtTicketNumber.Text;
            airTicket.FromAirport = txtAirportFrom.Text;
            airTicket.ToAirport = txtAirportTo.Text;
            airTicket.FlightCode = txtFlightCode.Text;
            airTicket.FlightDatetime = GetDateTime();
            Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void AirlineTicketEdit_Load(object sender, EventArgs e)
        {
            txtAirportFrom.Text = airTicket.FromAirport;
            txtAirportTo.Text = airTicket.ToAirport;
            txtFlightCode.Text = airTicket.FlightCode;
            txtInfoCardName.Text = airTicket.Name;
            txtIssuingAirline.Text = airTicket.IssuingAirline;
            txtTicketNumber.Text = airTicket.TicketNumber;
            txtPassengerName.Text = airTicket.PassengerName;
            dtpDate.Value = airTicket.FlightDatetime.Date;
            dtpTime.Value = airTicket.FlightDatetime;
        }
    }
}
