using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Getting_Started_Library.Tests
{
    [TestClass]
    public class SumOrProductTest
    {
        [TestMethod]
        public void UpperProductTest()
        {
            int n = 4;
            string choice = "Product";
            int result = SumOrProduct.SumOrProductSolution(n, choice);
            Assert.AreEqual(result, 24);
        }   
        [TestMethod]
        public void BadStrTest()
        {
            int n = 4;
            string choice = "hi";
            int result = SumOrProduct.SumOrProductSolution(n, choice);
            Assert.AreEqual(result, -1);
        }
        [TestMethod]
        public void BadIntTest()
        {
            int n = -4;
            string choice = "Product";
            int result = SumOrProduct.SumOrProductSolution(n, choice);
            Assert.AreEqual(result, -1);
        }
        [TestMethod]
        public void LowerProductTest()
        {
            int n = 4;
            string choice = "product";
            int result = SumOrProduct.SumOrProductSolution(n, choice);
            Assert.AreEqual(result, 24);
        }
        [TestMethod]
        public void UpperSumTest()
        {
            int n = 4;
            string choice = "Sum";
            int result = SumOrProduct.SumOrProductSolution(n, choice);
            Assert.AreEqual(result, 10);
        }
        [TestMethod]
        public void LowerSumTest()
        {
            int n = 4;
            string choice = "sum";
            int result = SumOrProduct.SumOrProductSolution(n, choice);
            Assert.AreEqual(result, 10);
        }
    }
}

