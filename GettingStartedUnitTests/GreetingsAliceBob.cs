﻿using System;
namespace GettingStartedLibrary
{
    public class GreetingsAliceBob
    {
        public static string GreetingsAliceBobSolution(string name)
        // Takes user name and greets them if they are Alice or Bob
        {
            if (String.Equals(name, "Alice"))
            {
                return "Nice to meet you Alice.";
            }
            else if (String.Equals(name, "Bob"))
            {
                return "Nice to meet you Bob.";
            }
            else
            {
                return "I'll only speak to Alice or Bob.";
            }
        }
    }
}


