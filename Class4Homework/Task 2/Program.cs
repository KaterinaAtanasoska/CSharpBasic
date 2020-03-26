using System;

namespace Task_2
{
    class Program
    {
        static int Sum(int number1, int number2)
        {
            int sum = number1 + number2;
            return sum;
        }

        static  int Subtract(int number1, int number2)
        {
            int subtract = number1 - number2;
            return subtract;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Please enter - or + :");
            char operation = char.Parse(Console.ReadLine());

            if (operation != '-' && operation != '+')
            {
                Console.WriteLine("Invalit input!");
            }
            else
            {
                Console.WriteLine("Please enter first number:");
                int num1 = int.Parse(Console.ReadLine());

                Console.WriteLine("Please enter second number:");
                int num2 = int.Parse(Console.ReadLine());

                switch (operation)
                {
                    case '+':
                        Console.WriteLine($"Sum of {num1} and {num2} is {Sum(num1, num2)}");
                        break;
                    case '-':
                        Console.WriteLine($"Difference of {num1} and {num2} is {Subtract(num1, num2)}");
                        break;
                }
            }
            
        }
    }
}
