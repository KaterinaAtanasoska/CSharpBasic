using ProjectLibrary.Enum;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProjectLibrary.Model
{
   public class Member
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public string UserName { get; set; }
        private string Password { get; set; }
        public int PhoneNumber { get; set; }
        public DateTime DateOfRegistration { get; set; }
        public Role RoleType { get; set; }

        public Member() { }
        public void DisplayInfo()
        {
            Console.WriteLine($"{FirstName} {LastName} | Registered on: {DateOfRegistration}");
        }

        public void password(string pass)
        {
            Password = pass;
        }
    }
}
