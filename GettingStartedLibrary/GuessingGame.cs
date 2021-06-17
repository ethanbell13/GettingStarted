using System;
using System.Collections.Generic;

namespace GettingStartedLibrary
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
            return new Random().Next(min, (max + 1));
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
                if(guessNum >= min && guessNum <= max)
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