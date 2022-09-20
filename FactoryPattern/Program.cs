using System;
using System.Collections.Generic;

namespace FactoryPattern
{
    class program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("What type of vehicle do you want to create");

            string vehicle = Console.ReadLine();    

            IVehicle phone = VehicleFactory.GetVehicle(vehicle);
            phone.Drive();
            Console.ReadLine();

        }
    }
}