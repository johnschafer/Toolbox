using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MilitaryTimeConversion;

namespace MilitaryTimeConversion_UnitTests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
        }

        [TestMethod]
        public void Number_Greater_Than_TwentyFourHundred_Throws_IndexOutOfRangeException()
        {
            var converter = new MilitaryTimeConverter();
            converter.ConvertTime(2400);
        }

        [TestMethod]
        public void Number_Less_Than_Zero_Throws_IndexOutOfRangeException()
        {
            var converter = new MilitaryTimeConverter();
            converter.ConvertTime(-0001);
        }
    }
}
