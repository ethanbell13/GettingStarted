using System;
namespace GettingStartedLibrary
{
    public class SumtonOnly3And5 
    {
        public static int SumToNOnly3And5Solution(int n)
        {
            if (n <= 0)
            {
                int x = 0;
                for (int i = 1; i >= n; i--)
                {
                    if ((i % 3) == 0)
                    {
                        x += i;
                    }
                    else if ((i % 5) == 0)
                    {
                        x += i;
                    }
                }
                return x;
            }
            else
            {
                int x = 0;
                for (int i = 1; i <= n; i++)
                {
                    if ((i % 3) == 0)
                    {
                        x += i;
                    }
                    else if ((i % 5) == 0)
                    {
                        x += i;
                    }
                }
                return x;
            }
        }
    }
}