using System;
using System.Collections.Generic;
using System.Linq;
using NCalc;
using System.Diagnostics;
namespace GettingStartedLibrary
{
    class Program
    {
        static void Main(string[] args)
        {
            var test = StringToMorseCode.StringToMorseCodeTranslator("Hello my name is Bob. End of Work", StringToMorseCode.morseCodeDict);
            Console.WriteLine(test);
        }
    }
}

//"Hello my name is Bob. End of Work"