using System;
using System.Collections.Generic;
using System.Linq;

namespace GettingStartedLibrary
{
    class Program
    {
        static void Main(string[] args)
        {
            var test = LeapYearRuleGenerator.LeapYearRuleGeneratorSolution(new decimal (365.123456));
            foreach(int i in test)
            {
                Console.WriteLine(i);
            }
        }
    }
}