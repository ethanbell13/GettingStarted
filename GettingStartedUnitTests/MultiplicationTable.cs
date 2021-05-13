using System;

namespace GettingStartedLibrary
{
    public static class MultiplicationTableForN
    {
        public static string MultiplicationTableForNSolution(int n)
        /*Takes in an integer and then puts out the multiplication table of that integer
        from o to 12.*/
        {
            string mt = n + "" + "\n";
            for (int i = 0; i <= 12; i++)
            {
                mt += n + "*" + i + "=" + (n * i) + "\n";
            }
            Console.WriteLine(mt);
            return mt;
        }
    }
}