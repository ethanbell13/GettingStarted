using System;
using System.Collections.Generic;

namespace GettingStartedLibrary
{
    public class MultiplicationTable
    {
        private const int Height = 12;
        private const int Width = 12;

        public void MultiplicationTableSolution()
        {
            // TODO: Try this approach
            // var matrix = new int[Height + 1, Width + 1];
            //
            // for (int i = 1; i < Width + 1; i++) 
            //     matrix[i, 0] = i;
            //
            // for (int i = 1; i < Height + 1; i++) 
            //     matrix[0, i] = i;

            Console.WriteLine(" --------------------------------------------\n" +
                              "| x|0| 1| 2| 3| 4| 5| 6| 7| 8|  9| 10| 11| 12|");
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
    }
}