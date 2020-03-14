using System;

namespace Exercise_6
{
    class Program
    {
        static void Main(string[] args)
        {
            
            string[] namesArray = new string[1];

            Console.Write("\n Enter name: ");
            namesArray[0] = Console.ReadLine();
            Console.WriteLine(namesArray[0]);



            do
            {
                Console.WriteLine("Do you want to enter new name?(yes or no)");
                string newName = Console.ReadLine();

                if (newName == "yes" || newName == "Yes" || newName == "YES")
                {
                    Console.WriteLine("\n Enter name:");
                    Array.Resize(ref namesArray, namesArray.Length + 1);
                    namesArray[namesArray.Length - 1] = Console.ReadLine();
                }
                else if (newName == "no" || newName == "No" || newName == "NO")
                {
                    Console.WriteLine("Have a good day");
                    break;
                }
                else
                {
                    Console.WriteLine("Please enter correct answer!");
                }
            } while (true);

            for (int i = 0; i < namesArray.Length; i++)
            {
                Console.WriteLine(namesArray[i]);
            }
        }
    }
}
