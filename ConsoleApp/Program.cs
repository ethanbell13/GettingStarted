using System;
using System.Collections.Generic;

namespace GettingStartedLibrary
{
    class Program
    {
        static void Main(string[] args)
        {
            foreach(int i in LeapYearRuleGenerator.LeapYearRuleGeneratorSolution(new decimal(14183.7398)))
            {
                Console.WriteLine(i);
            }
        }
    }
}