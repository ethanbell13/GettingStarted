using System;
using System.Data;
using System.Collections.Generic;
using System.IO;


namespace GettingStartedConsole
{
    class GettingStarted
    {
#pragma warning disable IDE0060 // Remove unused parameter
        public static void Main(string[] args)
        {
            LeapYears(2250);
        }
#pragma warning restore IDE0060 // Remove unused parameter
        
        //Print "Hello World when called.
        public static void HelloWorld()
        {
            Console.WriteLine("Hello World!");
        }
        // Takes in a positive integer and outputs the sum of every number from 1 to the given integer.
        public static int SumToN(int n)
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
        /* Takes in a postive integer and a string as paremters and outputs the sum or product of all integers 
         from one to the given integer. The string must be product, Product, sum, or Sum.*/
        public static int SumOrProduct(int n, string choice)
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
        /*Takes in an integer and then puts out the multiplication table of that integer
        from o to 12.*/
        public static string MultiplicationTableForN(int n)
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
        /*Takes in a min and max numbers and then initiates a guessing game for numbers between
        and including the min and max numbers.*/
        public static string GuessingGame(int min, int max)
        {
            if (min > max)
            {
                Console.WriteLine("The integer for min must be smaller than or equal to the integer for max.");
                return "The integer for min must be smaller than or equal to the integer for max.";
            }
            else
            {
                Random random = new Random();
                int num = random.Next(min, (max + 1));
                Console.WriteLine("Enter an integer between " + min + "(inclusive) and " + max + "(inclusive):");
                bool condition = true;
                string guess;
                int guessnum;
                List<int> guesses = new List<int>();
                while (condition == true)
                {
                    guess = Console.ReadLine();
                    if ((Int32.TryParse(guess, out guessnum) == false) || (guessnum < min) || (guessnum > max))
                    {
                        Console.WriteLine("Try again with a valid integer.");
                    }
                    else if (guessnum < num)
                    {
                        if (guesses.Contains(guessnum) == false)
                        {
                            guesses.Add(guessnum);
                            Console.WriteLine("Too low.");
                        }
                        else
                        {
                            Console.WriteLine("You already tried " + guessnum + ".");
                        }

                    }
                    else if (guessnum > num)
                    {
                        if (guesses.Contains(guessnum) == false)
                        {
                            guesses.Add(guessnum);
                            Console.WriteLine("Too high.");
                        }
                        else
                        {
                            Console.WriteLine("You already tried " + guessnum + ".");
                        }
                    }
                    else
                    {
                        condition = false;
                    }
                }
                int tries = guesses.Count + 1;
                Console.WriteLine("Congratulations! You won the game in " + tries + " tries.");
                return "Congratulations! You won the game in " + tries + " tries.";
            }
        }
        public static void LeapYears(int year)
        {
            int iterationYear = year;
            List<int> leapYears = new List<int>();
            bool condition = true;
            while (condition == true)
            {
                if ((iterationYear % 4) == 0 && ((iterationYear % 100) != 0 || (iterationYear % 400) == 0))
                {
                    if (iterationYear != year)
                    {
                        leapYears.Add(iterationYear);
                        condition = false;
                    }
                    else
                    {
                        condition = false;
                    }
                }
                else
                {
                    iterationYear++;
                }
            }
            while (leapYears.Count != 20)
            {
                iterationYear += 4;
                if ((iterationYear % 100) != 0 || (iterationYear % 400) == 0)
                {
                    leapYears.Add(iterationYear);
                }
                else
                {
                    continue;
                }
            }
            Console.WriteLine("The next 20 leap years are:");
            foreach (int i in leapYears)
            {
                Console.WriteLine(i);
            }
        }
    }
}

