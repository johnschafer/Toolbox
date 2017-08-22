using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using AppointmentSetter.Interface;

namespace AppointmentSetter.Classes
{
    public class Staff : IPerson
    {
        public string firstname { get; set; }
        public string lastname { get; set; }
        public string specialty { get; set; }
    }
}