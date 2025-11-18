using ConsoleApp4;
using System;

namespace PasswordGeneratorMVC
{
    public class Program
    {
        static void Main(string[] args)
        {
            PasswordActionController controller = new PasswordActionController();
            controller.Run();
        }
    }
}
