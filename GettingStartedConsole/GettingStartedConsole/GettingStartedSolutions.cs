using System;

namespace GettingStartedConsole
{
    class GettingStarted
    {
        public static void Main(string[] args)
        {
            HelloWorld();
            Console.WriteLine("Type a positive integer: ");
            int n = Int32.Parse(Console.ReadLine());
            Console.WriteLine(SumToN(n));
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
    }
}
