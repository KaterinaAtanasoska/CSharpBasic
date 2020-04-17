using CompanyLibrary.Model;
using ProjectLibrary;
using System;

namespace Task
{
    class Program
    {
        static void Main(string[] args)
        {                          
            SalesPerson john = new SalesPerson("John", "Doe");
            john.PrintInfo();
            john.ExtendSuccessRevenue(1000);
            Console.WriteLine(john.GetSalary());
            Console.WriteLine("----------------------------------------");

            Manager bob = new Manager("Bob", "Bobsky");
            bob.PrintInfo();
            bob.AddBonus(500);
            Console.WriteLine(bob.GetSalary());
            Console.WriteLine("----------------------------------------");

            Employee[] company = new Employee[]
            {
                new Contructor("Bob ", "Bobert", 42, 15),
                new Contructor("Rick", "Rickert", 40, 20),
                new Manager("Mona ", "Monalisa"),
                new Manager("Igor", "Igorsky"),
                new SalesPerson("Lea", "Leova")
            };

            CEO greg = new CEO("Greg", "Gregsky", company, 80);
            greg.PrintInfo();
            greg.AddSharesPrice(88);
            Console.WriteLine(greg.GetSalary());
            greg.PrintEmployees();

            Console.ReadLine();
        }
    }
}
