using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ConsoleApp1
{
    public class MagicNumbersController
    {
        private MagicNumberData data;
        private Display display;

        public MagicNumbersController()
        {
            data = new MagicNumberData();
            display = new Display();
        }

        public void Run()
        {
            data.MagicNumber = display.ReadInt("Въведете магическо число: ");
            GenerateMagicNumbers();
        }

        private void GenerateMagicNumbers()
        {
            for (int a = 1; a <= 9; a++)
                for (int b = 1; b <= 9; b++)
                    for (int c = 1; c <= 9; c++)
                        for (int d = 1; d <= 9; d++)
                            for (int e = 1; e <= 9; e++)
                                for (int f = 1; f <= 9; f++)
                                {
                                    if (a * b * c * d * e * f == data.MagicNumber)
                                    {
                                        display.ShowNumber($"{a}{b}{c}{d}{e}{f}");
                                    }
                                }
        }
    }
}