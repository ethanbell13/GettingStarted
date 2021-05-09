using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Getting_Started_Library.Tests
{
    [TestClass]
    public class HelloWorldTest
    {
        [TestMethod]
        public void BasicTest()
        {
            string result = HelloWorld.HelloWorldSolution();
            Assert.AreEqual("Hello World", result);
        }
    }
}