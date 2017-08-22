using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AppointmentSetter.Exceptions
{
    public class SpecialtyNotGeriatricsException : Exception
    {
        public SpecialtyNotGeriatricsException()
        {

        }

        public SpecialtyNotGeriatricsException(string message)
            : base(message)
        {

        }

        public SpecialtyNotGeriatricsException(string message, Exception inner)
            : base(message, inner)
        {

        }
    }
}