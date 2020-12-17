using System;

namespace Vehicle
{

    class BmwCar
    {
        public void Drive()
        {
        Console.WriteLine("Driving into the bus stop");
        }
        public void Park()
        {
        Console.WriteLine("Parking on as many parking lots as possible");
        }
    }

    class AnyOtherCar
    {
        public void Drive()
        {
        Console.WriteLine("Driving to the destination");
        }
        public void Park()
        {
        Console.WriteLine("Parking on a single parking spot");
        }
    }


     class Program
    {
        static public void Main(string[] args)
        {
            new BmwCar().Drive();
            new BmwCar().Park();

            new AnyOtherCar().Drive();
            new AnyOtherCar().Park();

        }
        
    }
}