using System;
using System.Collections.Generic;

namespace GettingStartedLibrary
{
    public static class LeapYearRuleGenerator
    {
        //Years divisible by the first integer leap years. Leapyears divisible by the seond integer are normal years.
        //Integers divisible by the second integer and also divisible by the third integer are leapyears. Any additional integers follow
        //this pattern. https://www.mathworks.com/matlabcentral/cody/problems/1319-leap-years-on-other-planets
        public static List<int> LeapYearRuleGeneratorSolution(decimal solaryeardurationinfractionaldays)
        {
            if (solaryeardurationinfractionaldays <= 0)
            {
                Console.WriteLine("Parameter must be a positive number.");
                return new List<int> { 1, 1, 1 };
            }
            decimal yearlyDifference = solaryeardurationinfractionaldays % 1;
            if (yearlyDifference == 0)
            {
                Console.WriteLine("This planet doesn't need leapyears.");
                return new List<int> { 0, 0, 0 };
            }
            var schedule = new List<int>();
            var dividingNumber = 1;
            var leapYear = true;
            decimal fraction;
            while(Math.Round(yearlyDifference, 4) != Math.Round(new decimal(0), 4))
            {
                int counter = 1;
                var incrementingDifference = yearlyDifference;
                while(Math.Abs(incrementingDifference) <= 1)
                {
                    counter += 1;
                    incrementingDifference += yearlyDifference; 
                }
                counter -= 1;
                while((counter % dividingNumber) != 0)
                {
                    counter -= 1;
                }
                dividingNumber = counter;
                schedule.Add(counter);
                fraction = 1 / new decimal(counter);
                if (leapYear == true)
                {
                    leapYear = false;
                    yearlyDifference -= fraction;
                }
                else
                {
                    leapYear = true;
                    yearlyDifference += fraction;
                }
            }
            return schedule;
        }
    }
}



