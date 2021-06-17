using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.IO;
using System;

namespace GettingStartedLibrary.Tests
{
    [TestClass]
    public class HelloWorldTest
    {
        [TestMethod]
        public void HelloWorld_MethodCalled_PrintsHelloWorld()
        {
            using (var sw = new StringWriter())
            {
                Console.SetOut(sw);
                new HelloWorld().HelloWorldSolution();
                Assert.AreEqual("Hello World!", sw.ToString().Trim());
            }
        }
    }       
}