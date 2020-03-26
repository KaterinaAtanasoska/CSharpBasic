using System;

namespace StudentGroup
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] studentsG1 = new string[] { "Zdravko", "Petko", "Stanko", "Branko", "Trajko" };
            string[] studentsG2 = new string[] { "Zoran", "Milan", "Tome", "Bogdan", "Stevan" };
            string studentGroup;

            Console.WriteLine("Enter student group: ( there are 1 and 2 )");
            studentGroup = Console.ReadLine();

            if (studentGroup != "2" && studentGroup != "1")
            {
                Console.WriteLine(studentGroup + " group does not exist");
            }
            else if (studentGroup == "1")
            {
                Console.WriteLine("The Students in G1 are: ");
                foreach (string name in studentsG1)
                {
                    Console.Write(name + ", ");
                }
            }
            else if (studentGroup == "2")
            {
                Console.WriteLine("The Students in G2 are: ");
                foreach (string name in studentsG2)
                {
                    Console.Write(name + ", ");
                }
            }
            Console.ReadLine();
        }
    }
}
