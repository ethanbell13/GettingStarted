using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Getting_Started_Library.Tests
{
    [TestClass]
    public class PrintAllPrimesForNTest
    {
        [TestMethod]
        public void NonPositiveTest()
        {
            int input = -1;
            string result = PrintAllPrimesForN.PrintAllPrimesForNSolution(input);
            Assert.AreEqual(result, "Please enter a positive integer.");
        }
        [TestMethod]
        public void IntOf1()
        {
            int input = 1;
            string result = PrintAllPrimesForN.PrintAllPrimesForNSolution(input);
            Assert.AreEqual(result, "1\n1");
        }
        [TestMethod]
        public void BasicTest()
        {
            int input = 7;
            string result = PrintAllPrimesForN.PrintAllPrimesForNSolution(input);
            Assert.AreEqual(result, "7\n1\n2\n3\n5\n7");
        }
    }
}
