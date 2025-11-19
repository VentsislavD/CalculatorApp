using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    public class VegetableMarketActionController
    {
        private VegetableMarketData data;
        private Display display;

        public VegetableMarketActionController()
        {
            data = new VegetableMarketData();
            display = new Display();
        }

        public void Run()
        {
            data.VegetablePrice = display.ReadDouble("Цена за кг зеленчуци: ");
            data.FruitPrice = display.ReadDouble("Цена за кг плодове: ");
            data.VegetableKg = display.ReadInt("Килограми зеленчуци: ");
            data.FruitKg = display.ReadInt("Килограми плодове: ");

            double revenueEuro = CalculateRevenueInEuro();
            display.ShowResult(revenueEuro);
        }

        public double CalculateRevenueInEuro()
        {
            double totalLeva = data.VegetablePrice * data.VegetableKg + data.FruitPrice * data.FruitKg;
            return totalLeva / 1.94;
        }
    }
}
