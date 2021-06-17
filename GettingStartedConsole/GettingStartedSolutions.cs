using System;
using System.Collections.Generic;
using System.IO;
using System.Data;


namespace GettingStartedConsole
{
    class GettingStarted
    {
        
        public static void HelloWorld()
        {
            Console.WriteLine("Hello World!");
        }
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

namespace GreetUser
{
    public interface IUserInput
    {
        string GetName();
    }
    public class UserInput : IUserInput
    {
        public string GetName()

        {
            Console.WriteLine("What is your name?");
            return Console.ReadLine();
        }
    }
    public class GreetUser
    {
        private IUserInput _userInput;
        public GreetUser(IUserInput userInput = null)
        {
            _userInput = userInput ?? new UserInput();
        }
        public void GreetUserSolution()
        {
            string name = _userInput.GetName();
            if (name == "")
            {
                Console.WriteLine("That's not much of a name.");
            }
            else
            {
                Console.WriteLine("Nice to meet you {0}!", name);
            }
        }
    }
    public static class MultiplicationTableForN
    {
        public static void MultiplicationTableForNSolution()
        {
            var multiplicationTable = new DataTable();
            multiplicationTable.Columns.Add("x");
            for (int i = 0; i <= 12; i++)
            {
                var iString = i.ToString();
                multiplicationTable.Columns.Add((iString));
            }
            for (int i = 0; i <= 12; i++)
            {
                List<int> multiplicationRow = new List<int>();
                multiplicationRow.Add(i);
                for (int j = 0; i <= 12; i++)
                {
                    multiplicationRow.Add(i * j);
                }
                multiplicationTable.Rows.Add(multiplicationRow);
            }
            Console.WriteLine(multiplicationTable);
        }
        public class MultiplicationTable
        {
            public void MultiplicationTableSolution()
            {
                Console.WriteLine(" --------------------------------------------\n" +
                                  "| x|0|1 |2 |3 |4 |5 |6 |7 |8 |9  |10 |11 |12 |");
                for (int i = 0; i <= 12; i++)
                {
                    var multiplicationRow = new List<string>();
                    if (i <= 9)
                    {
                        multiplicationRow.Add(" " + i.ToString());
                    }
                    else
                    {
                        multiplicationRow.Add(i.ToString());
                    }
                    for (int j = 0; j <= 12; j++)
                    {
                        string result = (i * j).ToString();
                        if (j >= 1 && j < 9 && result.Length < 2)
                        {
                            result = " " + result;
                        }
                        else if (j >= 9 && result.Length < 3)
                        {
                            if (result.Length < 2)
                            {
                                result = "  " + result;
                            }
                            else
                            {
                                result = " " + result;
                            }
                        }
                        multiplicationRow.Add(result);
                    }
                    Console.WriteLine("|{0}|{1}|{2}|{3}|{4}|{5}|{6}|{7}|{8}|{9}|{10}|{11}|{12}|{13}|",
                        multiplicationRow[0], multiplicationRow[1], multiplicationRow[2], multiplicationRow[3], multiplicationRow[4],
                        multiplicationRow[5], multiplicationRow[6], multiplicationRow[7], multiplicationRow[8], multiplicationRow[9],
                        multiplicationRow[10], multiplicationRow[11], multiplicationRow[12], multiplicationRow[13]);
                }
                Console.WriteLine(" --------------------------------------------");
            }
            static void Main(string[] args)
            {
                Console.WriteLine(new SumOfAlternatingSeries().SumOfAlternatingSeriesSolution());
            }
        }
        class SumOfAlternatingSeries
        {
            public double SumOfAlternatingSeriesSolution()
            {
                double total = 0;
                for (int k = 1; k <= 1000000; k++)
                {
                    total += 4 * ((-1 ^ (k + 1)) / (2 * k - 1));
                }
                return total;
            }
        }
        public class Leapyears
        {
            public void LeapYearsSolution(int year)
            {
                int iterationYear = year;
                List<int> leapYears = new List<int>();
                if (year <= 0)
                {
                    Console.WriteLine("Let's keep it to the AD times please(Only positive integers excepted.)");
                }
                else
                {
                    while (true)
                    {
                        if ((iterationYear % 4) == 0 && ((iterationYear % 100) != 0 || (iterationYear % 400) == 0))
                        {
                            if (iterationYear != year)
                            {
                                leapYears.Add(iterationYear);
                                break;
                            }
                            else
                            {
                                break;
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
    }
}
namespace GuessingGame
{
    public interface IRandomInt
    {
        int GetRandomInt(int min, int max);
    }
    public interface IUserGuess
    {
        int GetUserGuess(int min, int max);
    }
    public class RandomInt : IRandomInt
    {
        public int GetRandomInt(int min, int max)
        {
            var random = new Random();
            return random.Next(min, (max + 1));
        }
    }
    public class UserGuess : IUserGuess
    {
        public int GetUserGuess(int min, int max)
        {
            Console.WriteLine("Enter a number between {0} and {1}:", min, max);
            var guess = Console.ReadLine();
            int guessNum;
            while (true)
            {
                while (Int32.TryParse(guess, out guessNum) == false)
                {
                    Console.WriteLine("Your last input was invalid. Enter a number between {0} and {1}:", min, max);
                    guess = Console.ReadLine();
                }
                if (guessNum >= min && guessNum <= max)
                {
                    break;
                }
                else
                {
                    guess = "abc";
                }
            }
            return guessNum;
        }
    }
    public class GuessingGame
    {
        private IRandomInt _randomInt;
        private IUserGuess _userGuess;
        public GuessingGame(IRandomInt randomInt = null, IUserGuess userGuess = null)
        {
            _randomInt = randomInt ?? new RandomInt();
            _userGuess = userGuess ?? new UserGuess();
        }
        public class MockClasses : IRandomInt, IUserGuess
        {
            public int guessInt = 1;
            public int GetUserGuess(int min, int max)
            {
                if (guessInt == 1)
                {
                    guessInt = 2;
                    return 1;
                }
                else if (guessInt == 2)
                {
                    guessInt += 1;
                    return 4;
                }
                else
                {
                    return 3;
                }
            }
            public int GetRandomInt(int min, int max)
            {
                return 3;
            }
        }
        public void GuessingGameSolution(int min, int max)
        {
            if (min > max)
            {
                Console.WriteLine("The integer for min must be smaller than or equal to the integer for max.");
            }
            else
            {
                var randomNum = _randomInt.GetRandomInt(min, max);
                var guessNum = _userGuess.GetUserGuess(min, max);
                List<int> guesses = new List<int>();
                guesses.Add(guessNum);
                while (guessNum != randomNum)
                {
                    if (guessNum < randomNum)
                    {
                        if (guesses.Contains(guessNum) == false)
                        {
                            guesses.Add(guessNum);
                        }
                        Console.WriteLine(guessNum + " is too low.");
                    }
                    else
                    {
                        if (guesses.Contains(guessNum) == false)
                        {
                            guesses.Add(guessNum);
                        }
                        Console.WriteLine(guessNum + " is too high.");
                    }
                    guessNum = _userGuess.GetUserGuess(min, max);
                }
                int tries = guesses.Count + 1;
                Console.WriteLine("Congratulations! You won the game in {0} tries.", tries);
            }
        }
        
    }
}


