using Microsoft.VisualStudio.TestTools.UnitTesting;
namespace GettingStartedLibrary.Tests
{
    [TestClass]
    public class SumToNOnly3And5Test
    {
        [TestMethod]
        public void PositiveIntTest()
        {
            int result = new SumtoNOnly3And5().SumToNOnly3And5Solution(10);
            Assert.AreEqual(result, 33);
        }
        [TestMethod]
        public void NegativeIntTest()
        {
            int result = new SumtoNOnly3And5().SumToNOnly3And5Solution(-10);
            Assert.AreEqual(result, -33);
        }
    }
}

