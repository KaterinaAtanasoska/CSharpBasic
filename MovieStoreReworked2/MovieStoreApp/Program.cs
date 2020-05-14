using ProjectLibrary.Enum;
using ProjectLibrary.Model;
using ServicesLibrary;
using ServicesLibrary.LogInOptions;
using System;

namespace MovieStoreApp
{
   class Program
    {
        static void Main(string[] args)
        {                     
            bool logInValidate = false;

            while (!logInValidate)
            {
                Console.WriteLine("Enter username:");
                string username = Console.ReadLine();

                Console.WriteLine("Enter password:");
                string pass = Console.ReadLine();
               
                foreach (Member member in MembersInfo.Members)
                {
                    if (member.UserName == username && member.SetPassword() == pass)
                    {
                        Console.WriteLine($"Welcome {member.FirstName}");
                        MembersInfo.MemberLogged = member;
                        logInValidate = true;
                    }                    
                }
                               
                    if (MembersInfo.MemberLogged.RoleType == Role.Employee)
                    {
                        MembersInfo.EmployeeLogged = (Employee)MembersInfo.MemberLogged;
                        LoggedInEmployee.loggedInEmployee();
                    }
                    else if (MembersInfo.MemberLogged.RoleType == Role.User)
                    {
                        MembersInfo.UserLogged = (User)MembersInfo.MemberLogged;
                        LoggedInUser.loggedInUser();
                    }
                
            }
                Console.ReadLine();
        }
    }
}
