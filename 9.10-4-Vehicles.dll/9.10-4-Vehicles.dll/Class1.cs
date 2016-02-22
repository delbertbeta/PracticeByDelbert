using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9._10_4_Vehicles.dll
{
    public class Vehicles
    {
        //Something here...
    }
    public class Car:Vehicles
    {
        //Something here...
    }
    public class Train:Vehicles
    {
        //Something here...
    }
    public class Compact:Car,IPassengerCarrier
    {
        //Something here...
    }
    public class SUV : Car,IPassengerCarrier
    {
        //Something here...
    }
    public class Pickup : Car,IHeavyLoadCarrier
    {
        //Something here...
    }
    public class PassengerTrain : Train,IPassengerCarrier
    {
        //Something here...
    }
    public class FreightTrain : Train,IHeavyLoadCarrier
    {
        //Something here...
    }
    public class _424DoubleBogey : Train
    {
        //Something here...
    }
    public interface IPassengerCarrier
    {

    }
    public interface IHeavyLoadCarrier
    {

    }
}
