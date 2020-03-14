using System;

namespace Exercise_5
{
    class Program
    {
        static void Main(string[] args)
        {
                   
            int i;
            int[] arrayOfNumbers = new int[5];
            int sum = 0;

            for (i = 0; i < 5; i++)
            {
                Console.Write("\nEnter your number:");
                arrayOfNumbers[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("\n\n");
            
            for (i = 0; i < 5; i++)
            {
                sum += arrayOfNumbers[i];                
            }
            
            Console.WriteLine("The sum of values is: " + sum);
            Console.ReadLine();
        }
    }
}
