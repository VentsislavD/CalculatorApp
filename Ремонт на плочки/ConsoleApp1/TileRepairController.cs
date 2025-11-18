using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class TileRepairController
    {
        private TileRepairData data;
        private Display display;

        public TileRepairController()
        {
            data = new TileRepairData();
            display = new Display();
        }

        public void Run()
        {
            data.N = display.ReadDouble("Размер на площадката (N): ");
            data.W = display.ReadDouble("Ширина на плочка (W): ");
            data.L = display.ReadDouble("Дължина на плочка (L): ");
            data.M = display.ReadDouble("Ширина на пейка (M): ");
            data.O = display.ReadDouble("Дължина на пейка (O): ");

            CalculateTilesAndTime();
        }

        private void CalculateTilesAndTime()
        {
            double areaTotal = data.N * data.N;
            double areaBench = data.M * data.O;
            double areaToCover = areaTotal - areaBench;

            double tileArea = data.W * data.L;
            double tilesNeeded = areaToCover / tileArea;
            double timeNeeded = tilesNeeded * 0.2;

            display.ShowResult(tilesNeeded);
            display.ShowResult(timeNeeded);
        }
    }
}
