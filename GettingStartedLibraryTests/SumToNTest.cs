using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Getting_Started_Library.Tests
{
    [TestClass]
    public class SumToNTest
    {
        [TestMethod]
        public void BasicTest()
        {
            int input = 5;
            int result = SumToN.SumToNSolution(input);
            Assert.AreEqual(15, result);
        }
        [TestMethod]
        public void NegIntTest()
        {
            int input = -1;
            int result = SumToN.SumToNSolution(input);
            Assert.AreEqual(1, result);
        }
    }
}
