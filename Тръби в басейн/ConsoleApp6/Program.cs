using ConsoleApp6;
using System;

namespace PoolPipesMVC
{
    public class Program
    {
        static void Main(string[] args)
        {
            PoolActionController controller = new PoolActionController();
            controller.Run();
        }
    }
}