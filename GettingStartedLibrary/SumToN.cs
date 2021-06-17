using System;
namespace GettingStartedLibrary
{
    public class SumToN
    {
        public static int SumToNSolution(int n)
        {
            if (n <= 0)
            {
                int x = 0;
                for (int i = 1; i >= n; i--)
                {
                    x += i;
                }
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
