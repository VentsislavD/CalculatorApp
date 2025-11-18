using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Display
    {
        public int ReadInt(string message)
        {
            Console.Write(message);
            return int.Parse(Console.ReadLine());
        }

        public void ShowNumber(string number)
        {
            Console.Write(number + " ");
        }
    }
}
