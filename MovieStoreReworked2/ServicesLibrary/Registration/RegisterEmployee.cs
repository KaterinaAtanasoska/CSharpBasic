using ProjectLibrary.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace ServicesLibrary.Registration
{
    class RegisterEmployee
    {
        public static Employee registerEmployee()
        {
            //First Name
            string firstName = "";
            bool firstNameValidation = false;

            while (!firstNameValidation)
            {
                Console.WriteLine("Enter first name:");
                firstName = Console.ReadLine();
                if (firstName == "")
                {
                    Console.WriteLine("First name required!");
                    firstNameValidation = false;
                }
                else
                {
                    firstNameValidation = true;
                }                
            }

            //Last Name
            string lastName = "";
            bool lastNameValidation = false;

            while (!lastNameValidation)
            {
                Console.WriteLine("Enter last name:");
                lastName = Console.ReadLine();
                if (lastName == "")
                {
                    Console.WriteLine("Last name required!");
                    lastNameValidation = false;
                }
                else
                {
                    lastNameValidation = true;
                }
            }

            //Age
            int age = 0;
            bool ageValidation = false;

            while (!ageValidation)
            {
                Console.WriteLine("Enter age:");
                bool ageBool = int.TryParse(Console.ReadLine(), out age);

                if (!ageBool)
                {
                    Console.WriteLine("Age required!");
                    ageValidation = false;
                }

                if (age == 0)
                {
                    Console.WriteLine("Age required!");
                    ageValidation = false;
                }
                else if (age < 18)
                {
                    Console.WriteLine("User must be over 18!");
                    ageValidation = false;
                }
                else
                {
                    ageValidation = true;
                }                
            }

            //Username
            string username = "";
            bool usernameValidation = false;

            while (!usernameValidation)
            {
                Console.WriteLine("Enter username:");
                username = Console.ReadLine();
                if (username == "")
                {
                    Console.WriteLine("Username required!");
                    usernameValidation = false;
                }
                else
                {
                    usernameValidation = true;
                }
            }

            //Password
            string password = "";
            bool passwordValidation = false;

            while (!passwordValidation)
            {
                Console.WriteLine("Enter password:");
                password = Console.ReadLine();
                if (password == "")
                {
                    Console.WriteLine("Password required!");
                    passwordValidation = false;
                }
                else
                {
                    passwordValidation = true;
                }
            }

            //Phone number
            int phone = 0;
            bool phoneValidation = false;

            while (!phoneValidation)
            {
                Console.WriteLine("Enter phone number:");

                bool phoneBool = int.TryParse(Console.ReadLine(), out phone);

                if (!phoneBool)
                {
                    Console.WriteLine("Phone number required!");
                    phoneValidation = false;
                }

                if (phone == 0)
                {
                    Console.WriteLine("Phone number required!");
                    phoneValidation = false;
                }
                else
                {
                    phoneValidation = true;
                }                
            }

            //DateOfRegistration
            DateTime dateOfRegistration = DateTime.Now;

            //Hours per month
            double hoursPerMonth = 0.0;
            bool hoursPerMonthValidation = false;

            while (!hoursPerMonthValidation)
            {
                Console.WriteLine("Enter hours per month:");                
                bool subscriptionBool = double.TryParse(Console.ReadLine(), out hoursPerMonth);

                if (!subscriptionBool)
                {
                    Console.WriteLine("Hours per month required!");
                    hoursPerMonthValidation = false;
                }

                if (hoursPerMonth == 0.0)
                {
                    Console.WriteLine("Hours per month required!");
                    hoursPerMonthValidation = false;
                }
                else
                {
                    hoursPerMonthValidation = true;
                }                
            }

            Employee employee = new Employee();
            
            employee = new Employee(firstName, lastName, age, username, password, phone, dateOfRegistration, hoursPerMonth);

            List<Member> newEmployeeTempList = new List<Member>(MembersInfo.Members);
            newEmployeeTempList.Add(employee);
            MembersInfo.Members = newEmployeeTempList.ToArray();

            Console.WriteLine($"{employee.FirstName} {employee.LastName} is registered.");
            return employee;
        }
    }
}
