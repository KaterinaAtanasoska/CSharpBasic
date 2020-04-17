using ProjectLibrary;
using System;
using System.Collections.Generic;
using System.Text;

namespace CompanyLibrary.Model
{
   public class SalesPerson : Employee
    {
        public double SuccessSaleRevenue { get; set; }
        
        public SalesPerson(string firstName, string lastName) 
        {
            FirstName = firstName;
            LastName = lastName;
            Salary = 500;
            RoleType = Role.Sales;
        }

        public void ExtendSuccessRevenue(double successValue)
        {
            SuccessSaleRevenue += successValue;
        }
        public override double GetSalary()
        {
            if (SuccessSaleRevenue <= 2080)
            {
                return Salary + 500;
            }
            else if (SuccessSaleRevenue <= 5000)
            {
                return Salary + 800;
            }
            else if (SuccessSaleRevenue > 5000)
            {
                return Salary + 2000;
            }
            else
            {
                return Salary;
            }

        }        
       
    }
}
