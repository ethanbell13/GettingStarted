using System;
using System.Collections.Generic;
using NCalc;
using System.Linq;

namespace GettingStartedLibrary
{
    //Write a program that outputs all possibilities to put + or - or nothing between the numbers 1,2,…,9 (in this order)
    //such that the result is 100. For example 1 + 2 + 3 - 4 + 5 + 6 + 78 + 9 = 100.
    public static class EquationsThatSumTo100
    {
        public static List<string> EquationsThatSumTo100Solution()
        {
            var combinations = VarCombos();
            var equationsThatSumTo100 = new List<string>();
            foreach (List<string> vars in combinations)
            {
                var equation = new String("1" + vars[0] + "2" + vars[1] + "3" + vars[2] + "4" + vars[3] + 
                "5" + vars[4] + "6" + vars[5] + "7" + vars[6] + "8" + vars[7] + "9");
                if( Convert.ToInt32(new Expression(equation).Evaluate()) == 100)
                    equationsThatSumTo100.Add(equation);
            }
            return equationsThatSumTo100;
        }
        public static List<List<string>> VarCombos()
        {
            List<List<int>> combinations = new List<List<int>>();
            var numbers = new List<int> { 1, 1, 1, 1, 1, 1, 1, 1 };
            combinations.Add(new List<int> { numbers[0], numbers[1], numbers[2], numbers[3], numbers[4], numbers[5],
            numbers[6], numbers[7]});
            var baseCase = new List<int> { 3, 3, 3, 3, 3, 3, 3, 3 };
            var varCombos = new List<List<string>>();
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
            foreach (List<int> list in combinations)
            {
                var vars = new List<string>();
                foreach (int i in list)
                {
                    if (i == 1) { vars.Add("+"); }
                    else if (i == 2) { vars.Add("-"); }
                    else { vars.Add(""); }
                }
                varCombos.Add(vars);
            }
            return varCombos;
        }
    }
}
            

