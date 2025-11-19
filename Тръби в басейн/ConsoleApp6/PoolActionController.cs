using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    public class PoolActionController
    {
        private PoolData data;
        private Display display;

        public PoolActionController()
        {
            data = new PoolData();
            display = new Display();
        }

        public void Run()
        {
            data.V = display.ReadInt("Обем на басейна (V): ");
            data.P1 = display.ReadInt("Дебит на тръба 1 (P1): ");
            data.P2 = display.ReadInt("Дебит на тръба 2 (P2): ");
            data.H = display.ReadDouble("Часове отсъствие (H): ");

            CalculatePoolStatus();
        }

        public void CalculatePoolStatus()
        {
            double waterFromP1 = data.P1 * data.H;
            double waterFromP2 = data.P2 * data.H;
            double totalWater = waterFromP1 + waterFromP2;

            if (totalWater <= data.V)
            {
                int percentFull = (int)(totalWater / data.V * 100);
                int percentP1 = (int)(waterFromP1 / totalWater * 100);
                int percentP2 = (int)(waterFromP2 / totalWater * 100);

                display.ShowMessage($"The pool is {percentFull}% full. Pipe 1: {percentP1}%. Pipe 2: {percentP2}%.");
            }
            else
            {
                double overflow = totalWater - data.V;
                display.ShowMessage($"For {data.H} hours the pool overflows with {overflow} liters.");
            }
        }
    }
}
