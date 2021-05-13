using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace GettingStartedLibrary.Tests
{
    [TestClass]
    public class MultiplicationTableForNTests
    {
        [TestMethod]
        public void BasicTest()
        {
            string output = "1\n1*0=0\n1*1=1\n1*2=2\n1*3=3\n1*4=4\n1*5=5\n1*6=6\n1*7=7\n1*8=8\n" +
                "1*9=9\n1*10=10\n1*11=11\n1*12=12\n";
            int input = 1;
            string result = MultiplicationTableForN.MultiplicationTableForNSolution(input);
            Assert.AreEqual(result, output);
        }
    }
}


