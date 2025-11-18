using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    public class Display
    {
        public int ReadInt(string message)
        {
            Console.Write(message);
            return int.Parse(Console.ReadLine());
        }

        public void ShowStatus(string status)
        {
            Console.WriteLine(status);
        }

        public void ShowDifference(string diff)
        {
            Console.WriteLine(diff);
        }
    }
}
