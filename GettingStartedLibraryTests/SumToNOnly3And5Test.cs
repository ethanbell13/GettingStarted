using Microsoft.VisualStudio.TestTools.UnitTesting;
namespace Getting_Started_Library.Tests
{
    [TestClass]
    public class SumToNOnly3And5Test
    {
        [TestMethod]
        public void BasicTest()
        {
            int input = 10;
            int result = SumtonOnly3And5.SumToNOnly3And5Solution(input);
            Assert.AreEqual(result, 33);
        }
        [TestMethod]
        public void LowIntTest()
        {
            int input = 2;
            int result = SumtonOnly3And5.SumToNOnly3And5Solution(input);
            Assert.AreEqual(result, 1);
        }
    }
}

