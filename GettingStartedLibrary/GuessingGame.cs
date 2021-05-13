using System;

namespace GettingStartedLibrary
{
    public class GuessingGame
    {
        public static string GuessingGameSolutiion()
        {
            Random random = new Random();
            int num = random.Next(1, 101);
            string guess = Console.ReadLine();
            return "i";
        }
    }
}