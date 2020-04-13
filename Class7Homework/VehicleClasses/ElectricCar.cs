using System;
using System.Collections.Generic;
using System.Text;

namespace VehicleClasses
{
    public class ElectricCar : Car
    {
        public int BaterryCapacity { get; set; }
        public int BaterryPercentage { get; set; }

        public void Recharge()
        {
            Console.WriteLine("Charging");
        }
    }
}
