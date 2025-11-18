using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PublicTransportTicketPrice
{
    class TransportActionController
    {
        private TransportData data;
        private Display display;


        public TransportActionController()
        {
            data = new TransportData();
            display = new Display();
        }


        public void Run()
        {
            data.Kilometers = display.ReadKilometers();
            data.DayPeriod = display.ReadPeriod();


            double cheapestPrice = CalculateCheapestTransport(data.Kilometers, data.DayPeriod);


            display.ShowResult(cheapestPrice);
        }


        private double CalculateCheapestTransport(int n, string period)
        {
            double taxiPrice = 0.70 + n * (period == "day" ? 0.79 : 0.90);


            double busPrice = n >= 20 ? n * 0.09 : double.MaxValue;


            double trainPrice = n >= 100 ? n * 0.06 : double.MaxValue;


            return Math.Min(taxiPrice, Math.Min(busPrice, trainPrice));
        }
    }
}
