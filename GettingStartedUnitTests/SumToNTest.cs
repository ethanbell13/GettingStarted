using GettingStartedLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace GettingStartedUnitTests
{
    [TestClass]
    public class SumToNTests
    {
        [TestMethod]
        public void PositiveIntTest()
        {
            int result = new SumToN().SumToNSolution(5);
            Assert.AreEqual(15, result);
        }
        [TestMethod]
        public void NonPositiveIntTest()
        {
            int result = new SumToN().SumToNSolution(-5);
            Assert.AreEqual(-14, result);
        }
    }
}
