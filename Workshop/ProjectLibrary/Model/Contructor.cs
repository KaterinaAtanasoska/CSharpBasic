using ProjectLibrary;
using System;
using System.Collections.Generic;
using System.Text;

namespace CompanyLibrary.Model
{
    public class Contructor : Employee
    {
        public double WorkHours { get; set; }
        public int PayPerHour { get; set; }
        public Manager Responsible { get; set; }

        public override double GetSalary()
        {
            Salary = WorkHours * PayPerHour;
            return Salary;
        }

        Contructor() { }
        public Contructor(string firstName, string lastName, double workHours, int payPerHour) 
        {
            FirstName = firstName;
            LastName = lastName;
            WorkHours = workHours;
            PayPerHour = payPerHour;
            RoleType = Role.Other;
        }
    }
}
