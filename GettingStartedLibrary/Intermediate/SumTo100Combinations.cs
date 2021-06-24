using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GettingStartedLibrary
{
    //Write a program that outputs all possibilities to put + or - or nothing between the numbers 1,2,…,9 (in this order)
    //such that the result is 100. For example 1 + 2 + 3 - 4 + 5 + 6 + 78 + 9 = 100.
    public static class CombinationsOf1To9WithOrWithOutPlusAndOrMinusSignsInBetweenThem
    {
        public static List<string> String123Plus45Minus67Plus8PlusOrMinus9()
        {
            List<string> combinations = new List<string>();
            var numbers = new List<int>();
            numbers.Add(123);
            numbers.Add(45);
            numbers.Add(67);
            numbers.Add(8);
            numbers.Add(9);
            numbers.Add(109);
            if ((numbers[5] + numbers[4]) == 0)
            {
                combinations.Add("123 + 45 - 67 + 8 + 9 = 100");
            }
            else if ((numbers[5] - numbers[4]) == 100)
            {
                combinations.Add("123 + 45 - 67 + 8 - 9 = 100");
            }
            return combinations;
        }
    }
}
            

