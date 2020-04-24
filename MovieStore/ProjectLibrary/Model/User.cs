using ProjectLibrary.Enum;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProjectLibrary.Model
{
   public class User : Member
    {
        public int MemberNumber { get; set; }
        public Subscription TypeOfSubscription { get; set; }
        public string[] Movies { get; set; }

        public User() { }
        public User(string firstName, string lastName, int age, string userName, int phoneNumber, DateTime dateOfRegistration, int memberNumber, string[] movies)
        {
            FirstName = firstName;
            LastName = lastName;
            Age = age;
            UserName = userName;
            PhoneNumber = phoneNumber;
            DateOfRegistration = dateOfRegistration;
            RoleType = Role.User;
            MemberNumber = memberNumber;
            Movies = movies;
        }
    }
}
