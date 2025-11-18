using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PublicTransportTicketPrice
{
    class Display
    {
        public int ReadKilometers()
        {
            Console.Write("Въведете километри: ");
            return int.Parse(Console.ReadLine());
        }


        public string ReadPeriod()
        {
            Console.Write("Въведете период (day/night): ");
            return Console.ReadLine();
        }


        public void ShowResult(double price)
        {
            Console.WriteLine($"Най-евтина цена: {price:F2} лв.");
        }
    }
}
