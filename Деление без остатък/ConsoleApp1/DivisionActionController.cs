using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class DivisionActionController
    {
        private DivisionData data;
        private Display display;

        public DivisionActionController()
        {
            data = new DivisionData();
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

            CalculatePercentages();
        }

        private void CalculatePercentages()
        {
            int count2 = 0, count3 = 0, count4 = 0;

            foreach (int num in data.Numbers)
            {
                if (num % 2 == 0) count2++;
                if (num % 3 == 0) count3++;
                if (num % 4 == 0) count4++;
            }

            display.ShowPercentage((double)count2 / data.N * 100);
            display.ShowPercentage((double)count3 / data.N * 100);
            display.ShowPercentage((double)count4 / data.N * 100);
        }
    }
}
