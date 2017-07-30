using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MilitaryTimeConversion;

namespace MilitaryTimeConversion_UnitTests
{
    [TestClass]
    public class MilitaryTimeConversionUpperAndlowerBoundsUnitTests
    {
        [TestMethod]
        public void TestMethod1()
        {
        }

        [TestMethod]
        [ExpectedException(typeof(IndexOutOfRangeException))]
        public void Number_Greater_Than_TwentyFourHundred_Throws_IndexOutOfRangeException()
        {
            var converter = new MilitaryTimeConverter();
            converter.ConvertTime(24);
        }

        [TestMethod]
        [ExpectedException(typeof(IndexOutOfRangeException))]
        public void Number_Less_Than_Zero_Throws_IndexOutOfRangeException()
        {
            var converter = new MilitaryTimeConverter();
            converter.ConvertTime(-1);
        }
    }
}
