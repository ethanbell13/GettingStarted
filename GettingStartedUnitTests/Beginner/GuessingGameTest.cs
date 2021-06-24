using System;
using System.IO;
using GettingStartedLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;

namespace GettingStartedUnitTests
{
    [TestClass]
    public class GuessingGameTest
    {
        // Need to learn how to insert fake user input into a program call to test this properly.
        [TestMethod]
        public void BadParametersTest()
        {
            var mockIRandomInt = new Mock<IRandomInt>();
            var mockIUserGuess = new Mock<IUserGuess>();
            var _mockGuessingGameObject = new GuessingGame(mockIRandomInt.Object, mockIUserGuess.Object);
            using (var sw = new StringWriter())
            {
                Console.SetOut(sw);
                _mockGuessingGameObject.GuessingGameSolution(3, 1);
                Assert.AreEqual("The integer for min must be smaller than or equal to the integer for max.", sw.ToString().Trim());
            }
        }
        [TestMethod]
        public void GuessingGameWithParametersOf1And5_RandomIntOf3And3GuessesOf1And4And3Given_ProvidesProperOutPutToUser()
        {
            var mockIRandomInt = new Mock<IRandomInt>();
            mockIRandomInt.Setup(miri => miri.GetRandomInt(1, 5)).Returns(3);
            var mockIUserGuess = new Mock<IUserGuess>();
            mockIUserGuess.SetupSequence(miug => miug.GetUserGuess(1, 5))
                .Returns(1)
                .Returns(4)
                .Returns(3);
            var _mockGuessingGameObject = new GuessingGame(mockIRandomInt.Object, mockIUserGuess.Object);
            using (var sw = new StringWriter())
            {
                Console.SetOut(sw);
                _mockGuessingGameObject.GuessingGameSolution(1, 5);
                Assert.AreEqual(("1 is too low.\r\n4 is too high.\r\nCongratulations! You won the game in 3 tries."), 
                    sw.ToString().Trim());
            }
        }
    }
}
