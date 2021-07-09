using GettingStartedLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace GettingStartedUnitTests
{
    [TestClass]
    public class LeapYearRuleGeneratorTests
    {
        [TestMethod]
        public void TakesInNegativeValueReturnsMeaninglessListAndTellsUserToTryAgainWithPositiveValue()
        {
            var desiredResult = new List<int> { 1, 1, 1 };
            CollectionAssert.AreEqual(desiredResult, LeapYearRuleGenerator.LeapYearRuleGeneratorSolution(new decimal(-1)));
        }
        [TestMethod]
        public void TakeInSolarYearThatAllignsPerfectlyWithCalendarDaysTellsUserLeapYearsNotNeededAndReturnsMeaninglessList()
        {
            var desiredResult = new List<int> { 0, 0, 0 };
            CollectionAssert.AreEqual(desiredResult, LeapYearRuleGenerator.LeapYearRuleGeneratorSolution(new decimal(365)));
        }
        [TestMethod]
        public void TakesInEarthsSolarYearOutputs4And132And13068()
        {
            var result = new List<int>() { 4, 132, 13068 };
            CollectionAssert.AreEqual(result, LeapYearRuleGenerator.LeapYearRuleGeneratorSolution(new decimal(365.2425)));
        }
        [TestMethod]
        public void TakesInMarsSolarYearOutputs1And2And10And200()
        {
            var result = new List<int>() { 1, 2, 10, 200 };
            CollectionAssert.AreEqual(result, LeapYearRuleGenerator.LeapYearRuleGeneratorSolution(new decimal(668.5950)));
        }
        [TestMethod]
        public void TakesInPlutosSolarYearOutputs1And3And12And96And4608()
        {
            var result = new List<int>() { 1, 3, 12, 96, 4608 };
            CollectionAssert.AreEqual(result, LeapYearRuleGenerator.LeapYearRuleGeneratorSolution(new decimal(14183.7398)));
        }
    }
}