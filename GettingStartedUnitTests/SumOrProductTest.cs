using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Moq;

namespace GettingStartedLibrary.Tests
{
    [TestClass]
    public class SumOrProductTest
    {
        [TestMethod]
        public void PositiveIntProductTest()
        {
            var mockIUserChoice = new Mock<IUserChoice>();
            var _mockUserChoice = new SumOrProduct(mockIUserChoice.Object);
            mockIUserChoice.Setup(miuc => miuc.GetUserChoice()).Returns("p");
            var result = _mockUserChoice.SumOrProductSolution(4);
            Assert.AreEqual(24, result);
        }
        [TestMethod]
        public void NegIntProductTest()
        {
            var mockIUserChoice = new Mock<IUserChoice>();
            var _mockUserChoice = new SumOrProduct(mockIUserChoice.Object);
            mockIUserChoice.Setup(miuc => miuc.GetUserChoice()).Returns("p");
            var result = _mockUserChoice.SumOrProductSolution(-4);
            Assert.AreEqual(0, result);
        }
        [TestMethod]
        public void NegIntSumtTest()
        {
            var mockIUserChoice = new Mock<IUserChoice>();
            var _mockUserChoice = new SumOrProduct(mockIUserChoice.Object);
            mockIUserChoice.Setup(miuc => miuc.GetUserChoice()).Returns("s");
            var result = _mockUserChoice.SumOrProductSolution(-4);
            Assert.AreEqual(-9, result);
        }
        [TestMethod]
        public void PositiveIntSumTest()
        {
            var mockIUserChoice = new Mock<IUserChoice>();
            var _mockUserChoice = new SumOrProduct(mockIUserChoice.Object);
            mockIUserChoice.Setup(miuc => miuc.GetUserChoice()).Returns("s");
            var result = _mockUserChoice.SumOrProductSolution(4);
            Assert.AreEqual(10, result);
        }
    }
}

