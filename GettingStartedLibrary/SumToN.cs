using System;
namespace Getting_Started_Library
{
    public class SumToN
    // Takes in a positive integer and outputs the sum of every number from 1 to the given integer.
    {
        public static int SumToNSolution(int n)
        {
            int x = 0;
            for( int i = 1; i <= n; i++)
            {
                x += i;
            }
            return x;
        }
    }
}
