using System;
using System.Collections.Generic;
namespace GettingStartedLibrary
{ 
    public class Leapyears
    {
        public void LeapYearsSolution(int year)
        {
            int iterationYear = year;
            List<int> leapYears = new List<int>();
            if(year <= 0)
            {
                Console.WriteLine("Let's keep it to the AD times please(Only positive integers excepted.)");
            }
            else
            {
                while (true) 
                {
                    if ((iterationYear % 4) == 0 && ((iterationYear % 100) != 0 || (iterationYear % 400) == 0))
                    {
                        if (iterationYear != year)
                        {
                            leapYears.Add(iterationYear);
                            break;
                        }
                        else
                        {
                            break;
                        }
                    }
                    else
                    {
                        iterationYear++;
                    }
                }
                while (leapYears.Count != 20)
                {
                    iterationYear += 4;
                    if ((iterationYear % 100) != 0 || (iterationYear % 400) == 0)
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
}




