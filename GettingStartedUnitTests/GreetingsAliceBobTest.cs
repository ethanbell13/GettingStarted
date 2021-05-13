using Microsoft.VisualStudio.TestTools.UnitTesting;
namespace GettingStartedLibrary.Tests
{
	[TestClass]
	public class GreetingsAliceBobTest
	{
		[TestMethod]
		public void AliceTest()
		{
			string input = "Alice";
			string result = GreetingsAliceBob.GreetingsAliceBobSolution(input);
			Assert.AreEqual("Nice to meet you Alice.", result);
		}
		[TestMethod]
		public void BobTest()
		{
			string input = "Bob";
			string result = GreetingsAliceBob.GreetingsAliceBobSolution(input);
			Assert.AreEqual("Nice to meet you Bob.", result);
		}
		[TestMethod]
		public void OtherTest()
        {
			string input = "Jan";
			string result = GreetingsAliceBob.GreetingsAliceBobSolution(input);
			Assert.AreEqual("I'll only speak to Alice or Bob.", result);
		}
	}
}

