using System;

namespace Task_3
{
    public class Driver
    {
        public string Name { get; set; }
        public int Skill { get; set; }
    }

    public class Car
    {
        public string Model { get; set; }
        public int Speed { get; set; }
        public Driver Driverclass { get; set; }

        public int CalculateSpeed(Driver driverSkill)
        {
            int resultSpeed = driverSkill.Skill * Speed;
            return resultSpeed;
        }

    }
    
    class Program
    {
        static void RaceCars(Car carFirst, Car carSecond)
        {
            int firstCarRaceSpeed = carFirst.CalculateSpeed(carFirst.Driverclass);
            int secondCarRaceSpeed = carSecond.CalculateSpeed(carSecond.Driverclass);

            if (firstCarRaceSpeed > secondCarRaceSpeed)
            {
                Console.WriteLine($"First car model {carFirst.Model} will win, the driver is {carFirst.Driverclass.Name}. Total speed is {carFirst.Speed}");
            }
            else if (firstCarRaceSpeed < secondCarRaceSpeed)
            {
                Console.WriteLine($"Second car model {carSecond.Model} will win, the driver is {carSecond.Driverclass.Name}. Total speed is {carSecond.Speed}");
            }
            else
            {
                Console.WriteLine($"Both cars {carFirst.Model} and {carSecond.Model} are equal.");
            }
        }

        public static Car chosenCarMethod()
        {
            Car chosenCar = new Car();

            Car car1 = new Car()
            {
                Model = "Audi",
                Speed = 240
            };
            Car car2 = new Car()
            {
                Model = "Mazda",
                Speed = 190
            };
            Car car3 = new Car()
            {
                Model = "Ferrari",
                Speed = 380
            };
            Car car4 = new Car()
            {
                Model = "Porsche",
                Speed = 330
            };

            Console.WriteLine("Please select car: \n 1. Audi \n 2. Mazda \n 3. Ferrari \n 4. Porsche");
            bool carValidation = int.TryParse(Console.ReadLine(), out int carNumber);

            if (!carValidation)
            {
                Console.WriteLine("Choose valid number.");
            }            

            switch (carNumber)
            {
                case 1:
                    chosenCar = car1;
                    break;
                case 2:
                    chosenCar = car2;
                    break;
                case 3:
                    chosenCar = car3;
                    break;
                case 4:
                    chosenCar = car4;
                    break;
                default:
                    Console.WriteLine("There is no such a car.");
                    break;
            }
            return chosenCar;
        }
        
        public static Driver ChoosingDriver()
        {
            Driver chosenDriver = new Driver();

            Driver driver1 = new Driver()
            {
                Name = "Bob",
                Skill = 7
            };
            Driver driver2 = new Driver()
            {
                Name = "Greg",
                Skill = 4
            };
            Driver driver3 = new Driver()
            {
                Name = "Jill",
                Skill = 9
            };
            Driver driver4 = new Driver()
            {
                Name = "Anne",
                Skill = 6
            };

            Console.WriteLine("Please select driver: \n 1. Bob \n 2. Greg \n 3. Jill \n 4. Anne");
            bool driverValidation = int.TryParse(Console.ReadLine(), out int driverNumber);

            if (!driverValidation)
            {
                Console.WriteLine("Choose valid number.");
            }
           
            switch (driverNumber)
            {
                case 1:
                    chosenDriver = driver1;
                    break;
                case 2:
                    chosenDriver = driver2;
                    break;
                case 3:
                    chosenDriver = driver3;
                    break;
                case 4:
                    chosenDriver = driver4;
                    break;
                default:
                    Console.WriteLine("There is no such a driver.");
                    break;
            }

            return chosenDriver;

        }
        static void Main(string[] args)
        {
            while (true)
            {
                Car CarOne = new Car();
                Car CarTwo = new Car();
                Console.WriteLine("First Car");
                CarOne = chosenCarMethod();
                while (true)
                {                 
                    Console.WriteLine("Second Car");
                    CarTwo = chosenCarMethod();

                    if (CarOne.Model == CarTwo.Model)
                    {
                        Console.WriteLine("Can't select this car. Try again.");
                        continue;
                    }
                    
                    break;
                }
                

                Driver DriverOne = new Driver();
                Driver DriverTwo = new Driver();
                Console.WriteLine("First Driver");
                DriverOne = ChoosingDriver();
                
                while (true)
                {
                    Console.WriteLine("Second Driver");
                    DriverTwo = ChoosingDriver();

                    if (DriverOne.Name == DriverTwo.Name)
                    {
                        Console.WriteLine("Can't select this driver. Try again.");
                        continue;
                    }
                    break;
                }

                CarOne.Driverclass = DriverOne;
                CarTwo.Driverclass = DriverTwo;

                RaceCars(CarOne, CarTwo);

                Console.WriteLine("Would you like to race again? \n 1. Yes \n 2. No");
                bool raceAgainValidation = int.TryParse(Console.ReadLine(), out int raceAgain);

                if (!raceAgainValidation)
                {
                    Console.WriteLine("Choose valid answer.");
                }

                if (raceAgain == 1)
                {
                    Console.WriteLine("Let's get started");
                    continue;
                }
                else if (raceAgain == 2)
                {
                    Console.WriteLine("Goodbye");
                    break;
                }
            }            
        }
    }
}
