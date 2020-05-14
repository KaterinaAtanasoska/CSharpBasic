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
        public Movie[] Movies { get; set; }

        public User() { }
        public User(string firstName, string lastName, int age, string userName,string pass, int phoneNumber, DateTime dateOfRegistration, int memberNumber, Subscription type ,Movie[] movies)
        {
            FirstName = firstName;
            LastName = lastName;
            Age = age;
            UserName = userName;
            Password = pass;
            PhoneNumber = phoneNumber;
            DateOfRegistration = dateOfRegistration;
            RoleType = Role.User;
            MemberNumber = memberNumber;
            TypeOfSubscription = type;
            Movies = movies;
        }

        public User(string firstName, string lastName, int age, string userName, string pass, int phoneNumber, DateTime dateOfRegistration, int memberNumber, Subscription type)
        {
            FirstName = firstName;
            LastName = lastName;
            Age = age;
            UserName = userName;
            Password = pass;
            PhoneNumber = phoneNumber;
            DateOfRegistration = dateOfRegistration;
            RoleType = Role.User;
            MemberNumber = memberNumber;
            TypeOfSubscription = type;            
        }               
        
    }
}
