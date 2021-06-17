using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Moq;
using System.IO;

namespace GettingStartedLibrary.Tests
{
    [TestClass]
    public class GreetUserTests
    {
        [TestMethod]
        public void GreetUser_JoeGivenForName_GreetsJoe()
        {
            var mockIUserInput = new Mock<IUserInput>();
            var _mockUserInput = new GreetUser(mockIUserInput.Object);
            mockIUserInput.Setup(miui => miui.GetName()).Returns("Joe");
            using (var sw = new StringWriter())
            {
                Console.SetOut(sw);
                _mockUserInput.GreetUserSolution();
                Assert.AreEqual("Nice to meet you Joe!", sw.ToString().Trim());
            }
        }
        [TestMethod]
        public void GreetUser_NoInputGiven_MakeCommentOnLackOfName()
        {
            var mockIUserInput = new Mock<IUserInput>();
            var _mockUserInput = new GreetUser(mockIUserInput.Object);
            mockIUserInput.Setup(miui => miui.GetName()).Returns("");
            using (var sw = new StringWriter())
            {
                Console.SetOut(sw);
                _mockUserInput.GreetUserSolution();
                Assert.AreEqual("That's not much of a name.", sw.ToString().Trim());
            }
        }
    }
}

