using System;
namespace PublicTransportTicketPrice
{
    class Program
    {
        static void Main(string[] args)
        {
            TransportActionController controller = new TransportActionController();
            controller.Run();
        }
    }
}
