using System;

namespace AverageNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter the first number: ");
            int firstNumber = int.Parse(Console.ReadLine());

            Console.WriteLine("Please enter the second number: ");
            int secondNumber = int.Parse(Console.ReadLine());

            Console.WriteLine("Please enter the third number: ");
            int thirdNumber = int.Parse(Console.ReadLine());

            Console.WriteLine("Please enter the fourth number: ");
            int fourthNumber = int.Parse(Console.ReadLine());

            int averageNumber = (firstNumber + secondNumber + thirdNumber + fourthNumber) / 4;

            Console.WriteLine("The average number of " + firstNumber + ", " + secondNumber + ", " + thirdNumber + ", " + fourthNumber + " is " + averageNumber);
        }
    }
}
