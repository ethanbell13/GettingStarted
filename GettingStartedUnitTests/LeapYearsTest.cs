using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.IO;
using System;
namespace GettingStartedLibrary.Tests
{
    [TestClass]
    public class LeapYearsTest
    {
        [TestMethod]
        public void LeapYear_NegIntGiven_SaysToUsePosInts()
        {
            using(var sw = new StringWriter())
            {
                Console.SetOut(sw);
                new Leapyears().LeapYearsSolution(-1);
                Assert.AreEqual("Let's keep it to the AD times please(Only positive integers excepted.)", sw.ToString().Trim());
            }
        }
        [TestMethod]
        public void LeapYears_LeapYearGiven_Prints20LeapYearsAfterGivenYearAndOmitsYearDivisibleBy4And100ButNot400()
        {
            using(var sw = new StringWriter())
            {
                Console.SetOut(sw);
                new Leapyears().LeapYearsSolution(2020);
                Assert.AreEqual("The next 20 leap years are:\r\n2024\r\n2028\r\n2032\r\n2036\r\n2040\r\n2044\r\n2048\r\n2052\r\n" +
                     "2056\r\n2060\r\n2064\r\n2068\r\n2072\r\n2076\r\n2080\r\n2084\r\n2088\r\n2092\r\n2096\r\n2104", sw.ToString().Trim());
            }
        }
        [TestMethod]
        public void LeapYears_LeapYear2396Given_IncludesYear2400()
        {
            using(var sw = new StringWriter())
            {
                Console.SetOut(sw);
                new Leapyears().LeapYearsSolution(2396);
                Assert.AreEqual("The next 20 leap years are:\r\n2400\r\n2404\r\n2408\r\n2412\r\n2416\r\n2420\r\n2424\r\n2428\r\n" +
                    "2432\r\n2436\r\n2440\r\n2444\r\n2448\r\n2452\r\n2456\r\n2460\r\n2464\r\n2468\r\n2472\r\n2476", sw.ToString().Trim());
            }
        }
    }
}
