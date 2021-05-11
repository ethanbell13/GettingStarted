using System;

namespace GettingStartedConsole
{
    class GettingStarted
    {
        public static void Main(string[] args)
        {
            Console.WriteLine(SumOrProduct(4, "sum"));
        }
        public static void HelloWorld()
        {
            Console.WriteLine("Hello World!");
        }
        public static int SumToN(int n)
        // Takes in a positive integer and outputs the sum of every number from 1 to the given integer.
        {
            if (n < 0)
            {
                Console.WriteLine("Please enter a positive integer to receive a valid answer.");
                return 1;
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
        public static int SumOrProduct(int n, string choice)
        /* Takes in a postive integer and a string as paremters and outputs the sum or product of all integers 
         from one to the given integer. The string must be product, Product, sum, or Sum.*/
        {
            if (n < 0)
            {   
                Console.WriteLine("Please try again with a positive integer to receive a valid answer");
                return -1;
            }
            else
            {
                if ((choice == "Product") || (choice == "product"))
                {
                    int x = 1;
                    for(int i = 1; i <= n; i++)
                    {
                        x *= i;
                    }
                    return x;     
                }
                if ((choice == "Sum") || (choice == "sum"))
                {
                    int x = 0;
                    for(int i = 1; i <= n; i++)
                    {
                        x += i;
                    }
                    return x;
                }
                else
                {
                    Console.WriteLine("To receive a valid answer," + 
                    "you must enter Product, product, Sum, or sum for the string.");
                    return -1;
                }
            }
        }
    }
}
