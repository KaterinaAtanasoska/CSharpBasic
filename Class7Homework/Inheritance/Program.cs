using System;
using VehicleClasses;
using VehicleClasses.EnumEngineType;

namespace Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            Vehicle mercedes = new Vehicle()
            {
                Id = 1,
                Manufacturer = "Mercedes Benz",
                Model = "C 63 AMG"

            };
            mercedes.PrintInfo();
            Console.WriteLine("--------------------------------------------------------");

            WheeledVehicle ford = new WheeledVehicle()
            {
                Id = 2,
                Manufacturer = "Ford Motor Company",
                Model = "Focus",
                NumberOfWheels = 4,
                Type = "Car"
            };
            ford.PrintInfo();
            ford.Repair();
            Console.WriteLine("--------------------------------------------------------");

            Bicycle scott = new Bicycle()
            {
                Id = 3,
                Manufacturer = "Scott Sports SA",
                Model = "Sub Cross",
                NumberOfWheels = 2,
                Type = "Bicycle",
                NumberOfSpeedLevels = 21,
                IsElectric = false
            };
            scott.PrintInfo();
            scott.Repair();
            scott.Ride();
            Console.WriteLine("--------------------------------------------------------");

            Car audi = new Car()
            {
                Id = 4,
                Manufacturer = "Audi",
                Model = "RS2",
                NumberOfWheels = 4,
                Type = "Car",
                TypeOfEngin = EngineType.Petrol,
                FuelConsumption = "17l/100km",
                NumberOfDoors = 5,
                MaxSpeed = 262
            };
            audi.PrintInfo();
            audi.Repair();
            audi.Drive();
            Console.WriteLine("--------------------------------------------------------");

            ElectricCar tesla = new ElectricCar()
            {
                Id = 5,
                Manufacturer = "Tesla",
                Model = "Model S",
                NumberOfWheels = 4,
                Type = "Car",
                TypeOfEngin = EngineType.Electric,
                FuelConsumption = "0.0l/100km",
                NumberOfDoors = 5,
                MaxSpeed = 249,
                BaterryCapacity = 100,
                BaterryPercentage = 97,
            };
            tesla.PrintInfo();
            tesla.Repair();
            tesla.Drive();
            tesla.Recharge();

            Console.ReadLine();
        }
    }
}
