using System;

namespace homeworkClass2
{
    class Program
    {
        static void Main(string[] args)
        {
           //Task 1
            Console.WriteLine("Please enter the first number: ");
            int firstNumber = int.Parse(Console.ReadLine());

            Console.WriteLine("Please enter the second number: ");
            int secondNumber = int.Parse(Console.ReadLine());

            Console.WriteLine("Please enter the operation: ");
            char operation = char.Parse(Console.ReadLine());

            int result;

            if (operation == '+') 
            {
                result = firstNumber + secondNumber;
                Console.WriteLine(firstNumber + "+" + secondNumber + "=" + result);
            } 
            else if( operation == '-' )
            {
                result = firstNumber - secondNumber;
                Console.WriteLine(firstNumber + "-" + secondNumber + "=" + result);
            }
            else if (operation == '*')
            {
                result = firstNumber * secondNumber;
                Console.WriteLine(firstNumber + "*" + secondNumber + "=" + result);
            }
            else if (operation == '/')
            {
                result = firstNumber / secondNumber;
                Console.WriteLine(firstNumber + "/" + secondNumber + "=" + result);
            }
            else
            {
                Console.WriteLine("Incorrect input.");
            }

        }
    }
}
