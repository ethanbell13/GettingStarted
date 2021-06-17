using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Moq;
using System.IO;
namespace GettingStartedLibrary.Tests
{
    [TestClass]
    public class GreetAliceOrBobTests
    {
        [TestMethod]
        public void GreetUser_AliceGiven_GreetsAlice()
        {
            var mockIUserInput = new Mock<IUserInput>();
            var _mockUserInput = new GreetAliceOrBob(mockIUserInput.Object);
            mockIUserInput.Setup(miui => miui.GetName()).Returns("Alice");
            using (var sw = new StringWriter())
            {
                Console.SetOut(sw);
                _mockUserInput.GreetAliceOrBobSolution();
                Assert.AreEqual("Nice to meet you Alice!", sw.ToString().Trim());
            }
        }
        [TestMethod]
        public void GreetUser_BobGiven_GreetsBob()
        {
            var mockIUserInput = new Mock<IUserInput>();
            var _mockUserInput = new GreetAliceOrBob(mockIUserInput.Object);
            mockIUserInput.Setup(miui => miui.GetName()).Returns("Bob");
            using (var sw = new StringWriter())
            {
                Console.SetOut(sw);
                _mockUserInput.GreetAliceOrBobSolution();
                Assert.AreEqual("Nice to meet you Bob!", sw.ToString().Trim());
            }
        }
        [TestMethod]
        public void GreetUser_NeitherAliceOrBobGiven_DoesNotGreet()
        {
            var mockIUserInput = new Mock<IUserInput>();
            var _mockUserInput = new GreetAliceOrBob(mockIUserInput.Object);
            mockIUserInput.Setup(miui => miui.GetName()).Returns("Jack");
            using (var sw = new StringWriter())
            {
                Console.SetOut(sw);
                _mockUserInput.GreetAliceOrBobSolution();
                Assert.AreEqual("Only Alice or Bob may use this program.", sw.ToString().Trim());
            }
        }
    }
}
