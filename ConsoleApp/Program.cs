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
            var totalTime = new Stopwatch();
            totalTime.Start();
            var x = EquationsThatSumTo100.EquationsThatSumTo100Solution();
            totalTime.Stop();
            var time = totalTime.Elapsed;
            var y = 2;
        }
    }
}