using System;
using System.Collections.Generic;
using System.Text;

namespace VehicleClasses
{
    public class Vehicle
    {
        public int Id { get; set; }
        public string Manufacturer { get; set; }
        public string Model { get; set; }

        public void PrintInfo()
        {
            Console.WriteLine($"Id: {Id}, Manifacturer: {Manufacturer}, Model: {Model}");
        }
    }
}
