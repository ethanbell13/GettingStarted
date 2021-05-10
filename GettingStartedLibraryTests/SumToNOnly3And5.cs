﻿using System;
namespace Getting_Started_Library
{
    public class SumtonOnly3And5 
    {
        public static int SumToNOnly3And5Solution(int n)
        /*takes an integer that is no less than 3 and outputs the sum of all multiples of 3 and 5 up to and including
        the integer.*/
        {
            if (n < 3)
            {
                Console.WriteLine("Please enter a positive integer that is no less than 3 to receive a valid answer.");
                int x = 1;
                return x;
            }
            else
            {
                int x = 0;
                for (int i = 1; i <= n; i++)
                {
                    int y = i % 3;
                    int z = i % 5; 
                    if (y == 0)
                    {
                        x += i;
                    }
                    else if (z == 0)
                    {
                        x += i;
                    }
                }
                return x;
            }
        }
    }
}