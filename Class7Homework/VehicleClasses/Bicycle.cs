using System;
using System.Collections.Generic;
using System.Text;

namespace VehicleClasses
{
    public class Bicycle : WheeledVehicle
    {
        public int NumberOfSpeedLevels { get; set; }
        public bool IsElectric { get; set; }

        public void Ride()
        {
            Console.WriteLine("Riding");
        }
    }
}
