using System;
using System.Collections.Generic;
using System.Linq;

namespace GettingStartedLibrary
{
    //Write a program that outputs all possibilities to put + or - or nothing between the numbers 1,2,…,9 (in this order) 
    //such that the result is 100. For example 1 + 2 + 3 - 4 + 5 + 6 + 78 + 9 = 100. 
    public static class EquationsThatSumTo100LongVersion
    {
        
        public static List<string> EquationsThatSumTo100LongVersionSolution()
        {
            var combinations = VarCombos();
            var equations = new List<List<int>>();
            var eqsThatSumTo100 = new List<string>();
            foreach (List<int> list in combinations)
            {
                var equation = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
                for (int i = 0; i <= 7; i++)
                {
                    if (list[i] == 2)
                    {
                        equation[i + 1] *= -1;
                    }
                    else if (list[i] == 3)
                    {
                        var conjoinedDigits = "" + equation[i] + equation[i + 1];
                        equation[i + 1] = Int32.Parse(conjoinedDigits);
                        equation[i] = 0;
                    }
                }
                if (equation.Sum() == 100)
                {
                    var eqStr = "";
                    equation.RemoveAll(i => i == 0);
                    foreach (int i in equation)
                    {
                        if (i == equation[0])
                        {
                            eqStr += i;
                        }
                        else if (i < 0)
                        {
                            eqStr = eqStr + "-" + (i * -1);
                        }
                        else
                        {
                            eqStr = eqStr + "+" + i;
                        }
                    }
                    eqsThatSumTo100.Add(eqStr);
                }
            }
            return eqsThatSumTo100;
        }
        public static List<List<int>> VarCombos()
        {
            List<List<int>> combinations = new List<List<int>>();
            var numbers = new List<int> { 1, 1, 1, 1, 1, 1, 1, 1 };
            combinations.Add(new List<int> { numbers[0], numbers[1], numbers[2], numbers[3], numbers[4], numbers[5],
            numbers[6], numbers[7]});
            var baseCase = new List<int> { 3, 3, 3, 3, 3, 3, 3, 3 };
            while (!combinations.Any(c => c.SequenceEqual(baseCase)))
            {
                numbers[7] += 1;
                combinations.Add(new List<int> { numbers[0], numbers[1], numbers[2], numbers[3], numbers[4], numbers[5],
                numbers[6], numbers[7]});
                if (numbers[6] != 3 && numbers[7] == 3)
                {
                    numbers[6] += 1;
                    numbers[7] = 1;
                    combinations.Add(new List<int> { numbers[0], numbers[1], numbers[2], numbers[3], numbers[4], numbers[5],
                    numbers[6], numbers[7]});
                }
                else if (numbers[5] != 3 && numbers[6] == 3 && numbers[7] == 3)
                {
                    numbers[5] += 1;
                    numbers[6] = 1;
                    numbers[7] = 1;
                    combinations.Add(new List<int> { numbers[0], numbers[1], numbers[2], numbers[3], numbers[4], numbers[5],
                    numbers[6], numbers[7]});
                }
                else if (numbers[4] != 3 && numbers[5] == 3 && numbers[6] == 3 && numbers[7] == 3)
                {
                    numbers[4] += 1;
                    numbers[5] = 1;
                    numbers[6] = 1;
                    numbers[7] = 1;
                    combinations.Add(new List<int> { numbers[0], numbers[1], numbers[2], numbers[3], numbers[4], numbers[5],
                    numbers[6], numbers[7]});
                }
                else if (numbers[3] != 3 && numbers[4] == 3 && numbers[5] == 3 && numbers[6] == 3 && numbers[7] == 3)
                {
                    numbers[3] += 1;
                    numbers[4] = 1;
                    numbers[5] = 1;
                    numbers[6] = 1;
                    numbers[7] = 1;
                    combinations.Add(new List<int> { numbers[0], numbers[1], numbers[2], numbers[3], numbers[4], numbers[5],
                    numbers[6], numbers[7]});
                }
                else if (numbers[2] != 3 && numbers[3] == 3 && numbers[4] == 3 && numbers[5] == 3 && numbers[6] == 3 && numbers[7] == 3)
                {
                    numbers[2] += 1;
                    numbers[3] = 1;
                    numbers[4] = 1;
                    numbers[5] = 1;
                    numbers[6] = 1;
                    numbers[7] = 1;
                    combinations.Add(new List<int> { numbers[0], numbers[1], numbers[2], numbers[3], numbers[4], numbers[5],
                    numbers[6], numbers[7]});
                }
                else if (numbers[1] != 3 && numbers[2] == 3 && numbers[3] == 3 && numbers[4] == 3 && numbers[5] == 3 && numbers[6] == 3
                    && numbers[7] == 3)
                {
                    numbers[1] += 1;
                    numbers[2] = 1;
                    numbers[3] = 1;
                    numbers[4] = 1;
                    numbers[5] = 1;
                    numbers[6] = 1;
                    numbers[7] = 1;
                    combinations.Add(new List<int> { numbers[0], numbers[1], numbers[2], numbers[3], numbers[4], numbers[5],
                    numbers[6], numbers[7]});
                }
                else if (numbers[0] != 3 && numbers[1] == 3 && numbers[2] == 3 && numbers[3] == 3 && numbers[4] == 3 &&
                    numbers[5] == 3 && numbers[6] == 3 && numbers[7] == 3)
                {
                    numbers[0] += 1;
                    numbers[1] = 1;
                    numbers[2] = 1;
                    numbers[3] = 1;
                    numbers[4] = 1;
                    numbers[5] = 1;
                    numbers[6] = 1;
                    numbers[7] = 1;
                    combinations.Add(new List<int> { numbers[0], numbers[1], numbers[2], numbers[3], numbers[4], numbers[5],
                    numbers[6], numbers[7]});
                }
            }
            return combinations;
        }
    }
}