using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Хистограма
{
    public class HistogramActionController
    {
        private HistogramData data;
        private Display display;


        public HistogramActionController()
        {
            data = new HistogramData();
            display = new Display();
        }


        public void Run()
        {
            data.N = display.ReadInt("Въведете брой числа: ");
            data.Numbers = new int[data.N];


            for (int i = 0; i < data.N; i++)
            {
                data.Numbers[i] = display.ReadInt($"Число {i + 1}: ");
            }


            CalculateHistogram();
        }


        private void CalculateHistogram()
        {
            int p1 = 0, p2 = 0, p3 = 0, p4 = 0, p5 = 0;


            foreach (int num in data.Numbers)
            {
                if (num < 200) p1++;
                else if (num < 400) p2++;
                else if (num < 600) p3++;
                else if (num < 800) p4++;
                else p5++;
            }


            display.ShowPercentage((double)p1 / data.N * 100);
            display.ShowPercentage((double)p2 / data.N * 100);
            display.ShowPercentage((double)p3 / data.N * 100);
            display.ShowPercentage((double)p4 / data.N * 100);
            display.ShowPercentage((double)p5 / data.N * 100);
        }
    }
}
