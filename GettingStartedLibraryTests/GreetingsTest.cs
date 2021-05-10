using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Getting_Started_Library.Tests
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
