using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment
{
    public partial class AirlineTicketDisplay : Form
    {
        private AirlineTicket airTicket = new AirlineTicket();
        public AirlineTicketDisplay()
        {
            InitializeComponent();
        }

        public AirlineTicket AirTicket
        {
            get { return airTicket; }
            set { airTicket = value; }
        }

        private void AirlineTicketDisplay_Load(object sender, EventArgs e)
        {
            txtFromAirport.Text = airTicket.FromAirport;
            txtToAirport.Text = airTicket.ToAirport;
            txtFlightCode.Text = airTicket.FlightCode;
            txtIssuingAirline.Text = airTicket.IssuingAirline;
            txtTicketNumber.Text = airTicket.TicketNumber;
            txtPassengerName.Text = airTicket.PassengerName;
            txtFlightDateTime.Text = airTicket.FlightDatetime.ToString("dd/MM/yyyy  HH:mm");
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
