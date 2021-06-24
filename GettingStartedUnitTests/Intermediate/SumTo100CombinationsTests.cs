using GettingStartedLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace GettingStartedUnitTests
{
    //Write a program that outputs all possibilities to put + or - or nothing between the numbers 1,2,…,9 (in this order)
    //such that the result is 100. For example 1 + 2 + 3 - 4 + 5 + 6 + 78 + 9 = 100.
    [TestClass]
    public class CombinationsOf1To9WithOrWithOutPlusAndOrMinusSignsInBetweenThemTest
    {
        [TestMethod]
        public void CallsString123Plus45Minus67Plus8PlusOrMinus9ReturnsListWithOneString()
        {
            var result = CombinationsOf1To9WithOrWithOutPlusAndOrMinusSignsInBetweenThem.String123Plus45Minus67Plus8PlusOrMinus9();
            CollectionAssert.AreEqual(new List<string> { "123 + 45 - 67 + 8 - 9 = 100" }, result);
        }
    }
}


