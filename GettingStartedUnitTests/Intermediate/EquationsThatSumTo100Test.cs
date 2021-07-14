using GettingStartedLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace GettingStartedUnitTests
{
    [TestClass]
    public class EquationsThatSumTo100Test
    {
        [TestMethod]
        public void ShortVersionTest()
        {
            var result = EquationsThatSumTo100.EquationsThatSumTo100Solution();
            var desiredResult = new List<string> { "1+2+3-4+5+6+78+9" , "1+2+34-5+67-8+9" , "1+23-4+5+6+78-9", "1+23-4+56+7+8+9",
            "12+3+4+5-6-7+89", "12+3-4+5+67+8+9", "12-3-4+5-6+7+89", "123+4-5+67-89", "123+45-67+8-9", "123-4-5-6-7+8-9", "123-45-67+89"};
            CollectionAssert.AreEqual(result, desiredResult);
        }
        [TestMethod]
        public void LongVersionTest()
        {
            var result = EquationsThatSumTo100LongVersion.EquationsThatSumTo100LongVersionSolution();
            var desiredResult = new List<string> { "1+2+3-4+5+6+78+9" , "1+2+34-5+67-8+9" , "1+23-4+5+6+78-9", "1+23-4+56+7+8+9",
            "12+3+4+5-6-7+89", "12+3-4+5+67+8+9", "12-3-4+5-6+7+89", "123+4-5+67-89", "123+45-67+8-9", "123-4-5-6-7+8-9", "123-45-67+89"};
            CollectionAssert.AreEqual(result, desiredResult);
        }
    }
    
}


