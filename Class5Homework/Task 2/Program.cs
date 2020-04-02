using System;

namespace Task_2
{

   public class Dog
    {
        public string Name { get; set; }
        public string Race { get; set; }
        public string Color { get; set; }

        public void DogStatus()
        {
            Console.WriteLine($"The dogs name is {Name}, its race is {Race} in {Color} color.");
        } 
        public void Eat()
        {
            Console.WriteLine("The dog is now eating.");
        }
        public void Play ()
        {
            Console.WriteLine("The dog is now playing.");
        }
        public void ChaseTail()
        {
            Console.WriteLine("Dog is now chasing its tail.");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Dog dog1 = new Dog();

                Console.WriteLine("Enter name of the dog:");
                dog1.Name = Console.ReadLine();

                if (dog1.Name == "")
                {
                    Console.WriteLine("Enter name");                    
                    continue;
                }
               

                while (true)
                {
                    Console.WriteLine("Enter race of the dog:");
                    dog1.Race = Console.ReadLine();

                    if (dog1.Race == "")
                    {
                        Console.WriteLine("Enter race");
                        continue;
                    }
                    break;
                }

                while (true)
                {
                    Console.WriteLine("Enter color of the dog:");
                    dog1.Color = Console.ReadLine();

                    if (dog1.Color == "")
                    {
                        Console.WriteLine("Enter color");
                        continue;
                    }
                    break;
                }

                dog1.DogStatus();

                while (true)
                {
                    Console.WriteLine("Choose one of the actions: \n 1. Dog eating \n 2. Dog playing \n 3. Dog chasing its tail");
                   
                    bool actionValidation = int.TryParse(Console.ReadLine(), out int action);

                    if (!actionValidation)
                    {
                        Console.WriteLine("Please enter valid number.");
                    }

                    switch (action)
                    {
                        case 1:
                            dog1.Eat();
                            break;
                        case 2:
                            dog1.Play();
                            break;
                        case 3:
                            dog1.ChaseTail();
                            break;
                        default:
                            Console.WriteLine("Choose a correct number");
                            continue;
                    }
                    break;
                }

                break;
                               
            }

           

        }
    }
}
