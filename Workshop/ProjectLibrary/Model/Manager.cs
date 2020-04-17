using ProjectLibrary;
using System;
using System.Collections.Generic;
using System.Text;

namespace CompanyLibrary.Model
{
    public class Manager : Employee
    {
        private double Bonus { get; set; }

        public Manager()
        {

        }
        public Manager(string firstName, string lastName)
        {
            FirstName = firstName;
            LastName = lastName;
            Salary = 1000; 
            RoleType = Role.Manager;
        }        
        public void AddBonus(double bonus)
        {
            Bonus = bonus;
        }

        public override double GetSalary()
        {
            return Salary += Bonus;
        }
    }
}
