using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.IO;
namespace GettingStartedLibrary.Tests
{
    [TestClass]
    public class SumToNTests
    {
        [TestMethod]
        public void PositiveIntTest()
        {
            int result = SumToN.SumToNSolution(5);
            Assert.AreEqual(15, result);
        }
        [TestMethod]
        public void NonPositiveIntTest()
        {
            int result = SumToN.SumToNSolution(-5);
            Assert.AreEqual(-14, result);
        }
    }
}
