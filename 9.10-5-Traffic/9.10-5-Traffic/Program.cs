using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _9._10_4_Vehicles.dll;

namespace _9._10_5_Traffic
{
    class Program
    {
        static void AddPassenger(IPassengerCarrier Vehicle)
        {
            Console.WriteLine("{0}", Vehicle.ToString());
        }
        static void Main(string[] args)
        {
            AddPassenger(new Compact());
            AddPassenger(new PassengerTrain());
            AddPassenger(new SUV());
            Console.ReadKey();
        }
    }
}
