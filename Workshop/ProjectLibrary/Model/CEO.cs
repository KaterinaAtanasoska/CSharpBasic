using ProjectLibrary;
using System;
using System.Collections.Generic;
using System.Text;

namespace CompanyLibrary.Model
{
    public class CEO : Employee   
    {
        public Employee[] Employees { get; set; }
        public int Shares { get; set; }
        private double SharesPrice { get; set; }

        public void AddSharesPrice(double sharesPrice)
        {
            SharesPrice = sharesPrice;            
        }

        public void PrintEmployees()
        {
            foreach (Employee employee in Employees)
            {
                Console.WriteLine($"Name: {employee.FirstName} {employee.LastName}, Role: {employee.RoleType}");
            }
        }

        public override double GetSalary()
        {
            return Salary + Shares * SharesPrice;
        }

        public CEO() { }
        public CEO (string firstName, string lastName, Employee[] employees, int shares)
        {
            FirstName = firstName;
            LastName = lastName;
            Employees = employees;
            Shares = shares;
            RoleType = Role.Other;
        }
    }
}
