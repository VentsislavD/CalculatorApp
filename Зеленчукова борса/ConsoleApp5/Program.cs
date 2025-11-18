using ConsoleApp5;
using System;

namespace VegetableMarketMVC
{
    class Program
    {
        static void Main(string[] args)
        {
            VegetableMarketActionController controller = new VegetableMarketActionController();
            controller.Run();
        }
    }
}
