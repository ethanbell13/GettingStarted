using System;
using System.Data;


namespace GettingStartedConsole
{
    class GettingStarted
    {
#pragma warning disable IDE0060 // Remove unused parameter
        public static void Main(string[] args)
#pragma warning restore IDE0060 // Remove unused parameter
        {
            int n = 30;
            PrintAllPrimesForN(n);
            
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
                    for (int i = 1; i <= n; i++)
                    {
                        x *= i;
                    }
                    return x;
                }
                if ((choice == "Sum") || (choice == "sum"))
                {
                    int x = 0;
                    for (int i = 1; i <= n; i++)
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
        public static string MultiplicationTableForN(int n)
        /*Takes in an integer and then puts out the multiplication table of that integer
        from o to 12.*/
        {
            string mt = n + "" + "\n";
            for (int i = 0; i <= 12; i++)
            {
                mt += n + "*" + i + "=" + (n * i) + "\n";
            }
            Console.WriteLine(mt);
            return mt;
        }
        public static string PrintAllPrimesForN(int n)
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
            
 
