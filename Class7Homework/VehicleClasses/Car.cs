using System;
using System.Collections.Generic;
using System.Text;
using VehicleClasses.EnumEngineType;

namespace VehicleClasses
{
    public class Car : WheeledVehicle
    {
        public EngineType TypeOfEngin { get; set; }
        public string FuelConsumption { get; set; }
        public int NumberOfDoors { get; set; }
        public int MaxSpeed { get; set; }

        public void Drive()
        {
            Console.WriteLine("Driving");
        }
    }
}
