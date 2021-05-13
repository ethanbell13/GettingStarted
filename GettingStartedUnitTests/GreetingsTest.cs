using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace GettingStartedLibrary.Tests
{
    [TestClass]
    public class GreetingsTest
    {
        [TestMethod]
        public void BasicTest()
        {
            string input = "Joe";
            string result = Greetings.GreetingsSolution(input);
            Assert.AreEqual("Nice to meet you Joe.", result);
        }
    }
}
