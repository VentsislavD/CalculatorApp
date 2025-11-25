using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Хистограма
{
    public static class HistogramLogic
    {
        public static double[] CalculatePercentages(int[] numbers)
        {
            int n = numbers.Length;

            int p1 = 0, p2 = 0, p3 = 0, p4 = 0, p5 = 0;

            foreach (int num in numbers)
            {
                if (num < 200) p1++;
                else if (num < 400) p2++;
                else if (num < 600) p3++;
                else if (num < 800) p4++;
                else p5++;
            }

            return new double[]
            {
                (double)p1 / n * 100,
                (double)p2 / n * 100,
                (double)p3 / n * 100,
                (double)p4 / n * 100,
                (double)p5 / n * 100
            };
        }
    }
}
