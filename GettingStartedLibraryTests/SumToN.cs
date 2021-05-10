using System;
namespace Getting_Started_Library
{
    public class SumToN
    // Takes in a positive integer and outputs the sum of every number from 1 to the given integer.
    {
        public static int SumToNSolution(int n)
        {
            if (n < 0)
            {
                Console.WriteLine("Please enter a positive integer to receive a valid answer.");
                int x = 1;
                return x;
            }
            else
            {
                int x = 0;
                for (int i = 1; i <= n; i++)
                {
                    x += i;
                }
                return x;
            }
        }
    }
}
