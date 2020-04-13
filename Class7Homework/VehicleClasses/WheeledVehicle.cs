using System;
using System.Collections.Generic;
using System.Text;

namespace VehicleClasses
{
    public class WheeledVehicle : Vehicle
    {
        public int NumberOfWheels { get; set; }
        public string Type { get; set; }

        public void Repair()
        {
            Console.WriteLine("Repair completed");
        }
    }
}
