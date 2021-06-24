using System;

namespace GettingStartedLibrary
{
    public class SumOfAlternatingSeries
    {
        public double SumOfAlternatingSeriesSolution()
        {
            double total = 0;
            for(int k = 1; k <= 1000000; k++)
            {
                total += 4 * ((-1 ^ (k + 1)) / (2 * k - 1));
            }
            return total;
        }
    }
}
