using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using AppointmentSetter.Classes;
using AppointmentSetter.Exceptions;

namespace AppointmentSetter.Tests
{
    [TestClass]
    public class AppointmentSetterUnitTests
    {
        [TestMethod]
        public void TestMethod1()
        {
        }

        [TestMethod]
        [ExpectedException(typeof(SpecialtyNotGeriatricsException))]
        public void CheckAge_OlderThanSeventyNotGeriatrics_Exception_Test()
        {
            DateTime clientDOB = new DateTime(1918, 01, 01);
            string specialty = "not Geriatrics";
            Setter setter = new Setter();
            setter.CheckAge(clientDOB, specialty);
        }
    }
}
