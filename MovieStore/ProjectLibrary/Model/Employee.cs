using System;
using System.Collections.Generic;
using System.Text;

namespace ProjectLibrary.Model
{
    public class Employee : Member
    {
        protected double Salary { get; set; }
        public double HoursPerMonth { get; set; }
        protected double? Bonus { get; set; }

        public Employee() { }
        public Employee(string firstName, string lastName, int age, string userName, int phoneNumber, DateTime dateOfRegistration, double hoursPerMonth)
        {
            FirstName = firstName;
            LastName = lastName;
            Age = age;
            UserName = userName;
            PhoneNumber = phoneNumber;
            DateOfRegistration = dateOfRegistration;
            HoursPerMonth = hoursPerMonth;
            RoleType = Enum.Role.Employee;
        }

        public void SetBonus()
        {
            if (HoursPerMonth > 160)
            {
                Bonus = 0.3;
            }
            else if (HoursPerMonth < 160)
            {
                Bonus = null;
            }
        }

        public void SetSalary()
        {
            double bonus = Convert.ToDouble(Bonus);
            Salary = 300 + HoursPerMonth * bonus;
        }
    }
}
