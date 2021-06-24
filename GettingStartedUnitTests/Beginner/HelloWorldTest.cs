using System;
using System.IO;
using GettingStartedLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace GettingStartedUnitTests
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