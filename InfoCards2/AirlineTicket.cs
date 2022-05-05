using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment
{
    public class AirlineTicket : IInfoCard
    {
        //fields
        private string _name;
        private string _passengerName;
        private string _issuingAirline;
        private string _ticketNumber;
        private string _fromAirport;
        private string _toAirport;
        private DateTime _flightDatetime;
        private string _flightCode;
        private AirlineTicketDisplay _airlineTicketDisplayForm;
        
        //get-set
        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        public string PassengerName
        {
            get { return _passengerName; }
            set { _passengerName = value; }
        }

        public string IssuingAirline
        {
            get { return _issuingAirline; }
            set { _issuingAirline = value; }
        }

        public string TicketNumber
        {
            get { return _ticketNumber; }
            set { _ticketNumber = value; }
        }
        
        public string FromAirport
        {
            get { return _fromAirport; }
            set { _fromAirport = value; }
        }

        public string ToAirport
        {
            get { return _toAirport; }
            set { _toAirport = value; }
        }
        
        public DateTime FlightDatetime
        {
            get { return _flightDatetime; }
            set { _flightDatetime = value; }
        }
        
        public string FlightCode
        {
            get { return _flightCode; }
            set { _flightCode = value; }
        }

        //constructors
        public AirlineTicket()
        {
            _name = String.Empty;
            _passengerName = String.Empty;
            _issuingAirline = String.Empty;
            _ticketNumber = String.Empty;
            _fromAirport = String.Empty;
            _toAirport = String.Empty;
            _flightDatetime = DateTime.Today;
            _flightCode = String.Empty;
        }

        public AirlineTicket(string txt)
        {
            string[] airlineTicketInfo = txt.Split('|');
            if (airlineTicketInfo.Length != 8)
            {
                throw new Exception("Invalid data for Airline Ticket InfoCard");
            }
            else
            {
                _name = airlineTicketInfo[0];
                _passengerName = airlineTicketInfo[1];
                _issuingAirline = airlineTicketInfo[2];
                _ticketNumber = airlineTicketInfo[3];
                _fromAirport = airlineTicketInfo[4];
                _toAirport = airlineTicketInfo[5];
                _flightDatetime = DateTime.ParseExact(airlineTicketInfo[6], "g", null);
                _flightCode = airlineTicketInfo[7];
            }
        }

        //methods
        public string Category => "Airline Ticket";

        public void CloseDisplay()
        {
            if (_airlineTicketDisplayForm != null)
            {
                _airlineTicketDisplayForm.Close();
                _airlineTicketDisplayForm = null;
            }
        }

        public void DisplayData(Panel displayPanel)
        {
            CloseDisplay();
            _airlineTicketDisplayForm = new AirlineTicketDisplay();
            _airlineTicketDisplayForm.AirTicket = this;
            _airlineTicketDisplayForm.Show();
        }

        public bool EditData()
        {
            AirlineTicketEdit airlineTicketEdit = new AirlineTicketEdit()
            {
                AirTicket = this
            };
            if (airlineTicketEdit.ShowDialog() == DialogResult.OK)
            {
                _name = airlineTicketEdit.AirTicket._name;
                _passengerName = airlineTicketEdit.AirTicket._passengerName;
                _issuingAirline = airlineTicketEdit.AirTicket._issuingAirline;
                _ticketNumber = airlineTicketEdit.AirTicket._ticketNumber;
                _fromAirport = airlineTicketEdit.AirTicket._fromAirport;
                _toAirport = airlineTicketEdit.AirTicket._toAirport;
                _flightDatetime = airlineTicketEdit.AirTicket._flightDatetime;
                _flightCode = airlineTicketEdit.AirTicket._flightCode;
                return false;
            }
            return true;
        }

        public string GetDataAsString()
        {
            return string.Format("Airline Ticket|{0}|{1}|{2}|{3}|{4}|{5}|{6}|{7}", _name, _passengerName, _issuingAirline, _ticketNumber, _fromAirport, _toAirport, _flightDatetime.ToString("g"), _flightCode);
        }
    }
}
