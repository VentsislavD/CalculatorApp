using ConsoleApp2;
using System;

namespace ExamTimeMVC
{
    class Program
    {
        static void Main(string[] args)
        {
            ExamActionController controller = new ExamActionController();
            controller.Run();
        }
    }
}