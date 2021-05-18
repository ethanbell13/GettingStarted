using System;
using System.Collections.Generic;
namespace GettingStartedLibrary
{
    //Takes in a year and then prints out the next 20 leap years.
    public class Leapyears
    {
        public static void LeapYearsSolution(int year)
        {
            int iterationYear = year;
            List<int> leapYears = new List<int>();
            bool condition = true;
            while(condition == true)
            {
                if((iterationYear % 4) == 0 && ((iterationYear % 100) != 0 || (iterationYear % 400) == 0))
                {
                    if(iterationYear != year)
                    {
                        leapYears.Add(iterationYear);
                        condition = false;
                    }
                    else
                    {
                        condition = false;
                    }
                }
                else
                {
                    iterationYear++;
                }
            }
            while(leapYears.Count != 20)
            {
                iterationYear += 4;
                if((iterationYear % 100) != 0 || (iterationYear % 400) == 0)
                {
                    leapYears.Add(iterationYear);
                }
                else
                {
                    continue;
                }
            }
            Console.WriteLine("The next 20 leap years are:");
            foreach (int i in leapYears)
            {
                Console.WriteLine(i);
            }
        }
    }
}




