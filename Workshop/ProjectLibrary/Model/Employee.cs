using System;
using System.Collections.Generic;
using System.Text;

namespace ProjectLibrary
{
    public class Employee
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public Role RoleType { get; set; }
        protected double Salary { get; set; }

        public void PrintInfo()
        {
            Console.WriteLine($"First name: {FirstName} Last name: {LastName} Role: {RoleType}");
        }

        public virtual double GetSalary()
        {
            return Salary;
        }
    }
}
