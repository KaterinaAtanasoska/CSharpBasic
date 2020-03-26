using System;

namespace Task_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] integerArray = new int[6];
            int sum = 0;

            for (int i = 0; i < integerArray.Length; i++)
            {
                Console.WriteLine("Please enter " + i + "th number in array ");
                integerArray[i] = Convert.ToInt32(Console.ReadLine());
            }

            foreach (int number in integerArray)
            {
                if (number % 2 == 0)
                {
                    sum += number;
                }
            }

            Console.WriteLine("The sum of even numbers in this array is: " + sum);

            Console.ReadLine();
        }
    }
}
