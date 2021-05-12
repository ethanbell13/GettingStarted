using System;

namespace Getting_Started_Library
{
    public class PrintAllPrimesForN 
    {
        public static string PrintAllPrimesForNSolution(int n)
        // Prints all the given integer and all primes up to the given positive integer.
        {
            int x = 2;
            string primes = n + "\n" + 1;
            if (n < 1)
            {
                Console.WriteLine("Pleaase enter a positive integer.");
                return "Please enter a positive integer.";
            }
            else if (n == 1)
            {
                Console.WriteLine(primes);
                return primes;
            }
            else
            {
                while (x <= n)
                // While loop is infinite for reasons that I don't understand.
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