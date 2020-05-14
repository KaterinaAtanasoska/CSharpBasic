using ProjectLibrary.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace ServicesLibrary
{
    class RegisterUser
    {
        public static User registerUser()
        {
            //First Name
            string firstName = "";
            bool firstNameValidation = false;

            while(!firstNameValidation) { 
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

            while(!usernameValidation)
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

            while (!phoneValidation)            {
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

            //Subscription type
            int subscriptionInput = 0;
            bool subscriptionValidation = false;
            
            while (!subscriptionValidation)
            {
                Console.WriteLine("Enter  type Of subscription:");
                Console.WriteLine("1. Monthly");
                Console.WriteLine("2. Annually");               
                bool subscriptionBool = int.TryParse(Console.ReadLine(), out subscriptionInput);

                if (!subscriptionBool)
                {
                    Console.WriteLine("Subscription type required!");
                    subscriptionValidation = false;
                }

                if (subscriptionInput == 0)
                {
                    Console.WriteLine("Subscription type required!");
                    subscriptionValidation = false;
                }
                else
                {
                    subscriptionValidation = true;
                }                
            }

            //Member Number
            int memberNumber = 0;
            bool memberNumberValidation = false;

            while (!memberNumberValidation)
            {
                Console.WriteLine("Enter member number:");                
                bool memberNumberBool = int.TryParse(Console.ReadLine(), out memberNumber);

                if (!memberNumberBool)
                {
                    Console.WriteLine("Member number required!");
                    memberNumberValidation = false;
                }

                if (memberNumber == 0)
                {
                    Console.WriteLine("Member number required!");
                    memberNumberValidation = false;
                }
                else
                {
                    memberNumberValidation = true;
                }              
            }

            User user = new User();

            if (subscriptionInput == 1)
            {
                user = new User(firstName, lastName, age, username, password, phone, dateOfRegistration, memberNumber, ProjectLibrary.Enum.Subscription.Monthly);                
            }

            if (subscriptionInput == 2)
            {
                user = new User(firstName, lastName, age, username, password, phone, dateOfRegistration, memberNumber, ProjectLibrary.Enum.Subscription.Annually);
            }

            List<Member> newUserTempList = new List<Member>(MembersInfo.Members);
            newUserTempList.Add(user);
            MembersInfo.Members = newUserTempList.ToArray();

            Console.WriteLine($"{user.FirstName} {user.LastName} is registered.");
            return user;
        }
    }
}
