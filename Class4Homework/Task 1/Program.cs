using System;

namespace Task_1
{
    class Program
    {
        static void Substrings(int numbers)
        {
            string sedc = "Hello from SEDC Codecademy v7.0";

            if (numbers > sedc.Length)
            {
                Console.WriteLine($"Integer is larger than the length of the string, please enter a number lower than {sedc.Length}");

            }
            else
            {
                string sedcPrint = sedc.Substring(0, numbers);

                Console.WriteLine($"The fist characters from the string are '{sedcPrint}' and their length is {sedcPrint.Length}");
            }
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a number: ");
           
            bool number = int.TryParse(Console.ReadLine(), out int n);

            if (number)
            {
                Substrings(n);                
            }
            else
            {
                Console.WriteLine("Invalid input!");
            }
        }
    }
}
