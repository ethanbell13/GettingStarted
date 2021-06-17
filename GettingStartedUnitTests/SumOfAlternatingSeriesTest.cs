using GettingStartedLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace GettingStartedUnitTests
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
