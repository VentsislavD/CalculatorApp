using ConsoleApp1;
using System;

namespace DivisionWithoutRemainderMVC
{
    public class Program
    {
        static void Main(string[] args)
        {
            DivisionActionController controller = new DivisionActionController();
            controller.Run();
        }
    }
}