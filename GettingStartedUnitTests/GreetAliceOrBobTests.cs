using GettingStartedLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace GettingStartedUnitTests
{
    [TestClass]
    public class GreetAliceOrBobTests
    {
        [TestMethod]
        public void GreetUser_AliceGiven_GreetsAlice()
        {
            var result = GreetAliceOrBob.GreetAliceOrBobSolution("Alice");
            Assert.AreEqual("Nice to meet you Alice!", result);
        }

        [TestMethod]
        public void GreetUser_BobGiven_GreetsBob()
        {
            var result = GreetAliceOrBob.GreetAliceOrBobSolution("Bob");
            Assert.AreEqual("Nice to meet you Bob!", result);
        }

        [TestMethod]
        public void GreetUser_NeitherAliceOrBobGiven_DoesNotGreet()
        {
            var result = GreetAliceOrBob.GreetAliceOrBobSolution("Jack");
            Assert.AreEqual("Only Alice or Bob may use this program.", result);
        }
    }
}