using System;

namespace SwapNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter the first number: ");
            int firstNumber = int.Parse(Console.ReadLine());

            Console.WriteLine("Please enter the second number: ");
            int secondNumber = int.Parse(Console.ReadLine());

            int temporary = firstNumber;
            firstNumber = secondNumber;
            secondNumber = temporary;

            Console.WriteLine("After swapping: First number:" + firstNumber + " Second number:" + secondNumber);
        }
    }
}
