using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AppointmentSetter.Classes
{
    public class Appointment
    {
        private Client _Client = null;

        public Client client
        {
            get
            {
                if (_Client == null) _Client = new Client();
                return _Client;
            }
        }

        private Staff _Staff = null;

        public Staff staff
        {
            get
            {
                if (_Staff == null) _Staff = new Staff();
                return _Staff;
            }
        }

        private List<ServiceLine> _ServiceLines = null;

        public List<ServiceLine> servicelines
        {
            get
            {
                if (_ServiceLines == null) _ServiceLines = new List<ServiceLine>();
                return _ServiceLines;
            }
        }
    }
}