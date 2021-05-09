using System;
namespace Getting_Started_Library
{
    public class SumToN
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
