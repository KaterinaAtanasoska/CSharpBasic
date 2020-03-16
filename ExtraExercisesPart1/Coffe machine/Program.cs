using System;

namespace Coffe_machine
{
    class Program
    {
        static void Main(string[] args)
        {
            int espresso = 2;
            double macchiato = 3.5;
            int latte = 4;
            int cappuccino = 6;
            double tea = 1.5;

            Console.WriteLine("Welcome dear customer, please select a drink(enter the number):");
            Console.WriteLine("\n1. Espresso ......." + espresso + '$' +
            "\n2. Macchiato ......" + macchiato + '$' + 
            "\n3. Latte .........." + latte + '$' +
            "\n4. Cappuccino ....." + cappuccino + '$' +
            "\n5. Tea ............" + tea + '$');

            int drink = int.Parse(Console.ReadLine());
            Console.WriteLine("Choose your sweetness level: 1, 2, 3, 4, 5.");
            int sugar = int.Parse(Console.ReadLine());

            if (drink == 1)
            {
                Console.WriteLine("Espresso with " + sugar + " sweetness level, costs " + espresso + "$. Please insert the money:");
                int payment = int.Parse(Console.ReadLine());
                if (payment == espresso)
                {
                    Console.WriteLine("Thank you!");
                }
                else if (payment < espresso)
                {
                    Console.WriteLine("The drink costs " + espresso + "$, you are missing " + (espresso - payment) + "$");
                    payment = int.Parse(Console.ReadLine());
                    Console.WriteLine("Goodbye!");
                }
            }
            else if (drink == 2)
            {
                Console.WriteLine("Macchiato with " + sugar + " sweetness level, costs " + macchiato + "$. Please insert the money:");
                int payment = int.Parse(Console.ReadLine());
                if (payment == macchiato)
                {
                    Console.WriteLine("Thank you!");
                }
                else if (payment < macchiato)
                {
                    Console.WriteLine("The drink costs " + macchiato + "$, you are missing " + (macchiato - payment) + "$");
                    payment = int.Parse(Console.ReadLine());
                    Console.WriteLine("Goodbye!");
                }
            }
            else if (drink == 3)
            {
                Console.WriteLine("Latte with " + sugar + " sweetness level, costs " + latte + "$. Please insert the money:");
                int payment = int.Parse(Console.ReadLine());
                if (payment == latte)
                {
                    Console.WriteLine("Thank you!");
                }
                else if (payment < latte)
                {
                    Console.WriteLine("The drink costs " + latte + "$, you are missing " + (latte - payment) + "$");
                    payment = int.Parse(Console.ReadLine());
                    Console.WriteLine("Goodbye!");
                }
            }
            else if (drink == 4)
            {
                Console.WriteLine("Cappuccino with " + sugar + " sweetness level, costs " + cappuccino + "$. Please insert the money:");
                int payment = int.Parse(Console.ReadLine());
                if (payment == cappuccino)
                {
                    Console.WriteLine("Thank you!");
                }
                else if (payment < cappuccino)
                {
                    Console.WriteLine("The drink costs " + cappuccino + "$, you are missing " + (cappuccino - payment) + "$");
                    payment = int.Parse(Console.ReadLine());
                    Console.WriteLine("Goodbye!");
                }
            }
            else if (drink == 5)
            {
                Console.WriteLine("Tea with " + sugar + " sweetness level, costs " + tea + "$. Please insert the money:");
                int payment = int.Parse(Console.ReadLine());
                if (payment == tea)
                {
                    Console.WriteLine("Thank you!");
                }
                else if (payment < tea)
                {
                    Console.WriteLine("The drink costs " + tea + "$, you are missing " + (tea - payment) + "$");
                    payment = int.Parse(Console.ReadLine());
                    Console.WriteLine("Goodbye!");
                }
            }

            Console.ReadLine();
        }
    }
}
