using System;

namespace GettingStartedLibrary
{
    public class PrintAllPrimesForN 
    {
        public string PrintAllPrimesForNSolution(int n)
        {
            int x = 2;
            string primes = "Prime numbers up to and including " + n + ":\n" + 1;
            if (n < 1)
            {
                Console.WriteLine("You must enter a positive integer to receive a valid return value .");
                return "Invalid operation due to nonpositive arguement.";
            }
            else
            {
                while (x <= n)
                {
                    bool ContinueForLoop = true;
                    for (int i = 2; i <= x; i++)
                    {
                        if (ContinueForLoop == true)
                        {
                            if (((x % i) == 0) && (x != i))
                            {
                                x++;
                                ContinueForLoop = false;
                            }
                            else if (i == x)
                            {
                                primes += ("\n" + x);
                                x++;
                                ContinueForLoop = false;
                            }
                            else
                            {
                                continue;
                            }
                        }
                    }
                }
                Console.WriteLine(primes);
                return primes;
            }
        }
    }
}