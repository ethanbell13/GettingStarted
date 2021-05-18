using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace GettingStartedLibrary.Tests
{
    [TestClass]
    public class GuessingGameTest
    {
        // Need to learn how to insert fake user input into a program call to test this properly.
        [TestMethod]
        public void BadParametersTest()
        {
            int minparam = 3;
            int maxparam = 1;
            string result = GuessingGame.GuessingGameSolution(minparam, maxparam);
            Assert.AreEqual(result, "The integer for min must be smaller than or equal to the integer for max.");
        }
    }
}
