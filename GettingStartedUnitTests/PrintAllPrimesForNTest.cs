using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.IO;

namespace GettingStartedLibrary.Tests
{
    [TestClass]
    public class PrintAllPrimesForNTest
    {
        [TestMethod]
        public void NonPositiveTest()
        {
            string result = PrintAllPrimesForN.PrintAllPrimesForNSolution(-1);
            Assert.AreEqual(result, "Invalid operation due to nonpositive arguement.");
        }
        [TestMethod]
        public void PositiveIntTest()
        {
            string result = PrintAllPrimesForN.PrintAllPrimesForNSolution(7);
            Assert.AreEqual(result, "Prime numbers up to and including 7:\n1\n2\n3\n5\n7");
        }
    }
}
