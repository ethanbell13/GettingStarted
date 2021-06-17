using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace GettingStartedLibrary.Tests
{
    [TestClass]
    public class SumOfAlternatingSeriesTest
    {
        [TestMethod]
        public void CallsSumOfAlternatingSeriesAndReturnsNeg20()
        {
            double result = new SumOfAlternatingSeries().SumOfAlternatingSeriesSolution();
            Assert.AreEqual(-20, result);
        }
    }
}
