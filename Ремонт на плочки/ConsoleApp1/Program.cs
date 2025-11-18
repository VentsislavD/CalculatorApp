using ConsoleApp1;
using System;

namespace TileRepairMVC
{
    public class Program
    {
        static void Main(string[] args)
        {
            TileRepairController controller = new TileRepairController();
            controller.Run();
        }
    }
}