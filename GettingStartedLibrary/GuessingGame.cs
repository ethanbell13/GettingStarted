using System;
using System.Collections.Generic;

namespace GettingStartedLibrary
{
    public class GuessingGame
    {
        /*Takes in a min and max numbers and then initiates a guessing game for numbers between
        and including the min and max numbers.*/
        public static string GuessingGameSolution(int min, int max)
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
    }
}