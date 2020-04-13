using System;
using System.Collections.Generic;
using System.Text;

namespace AccountLibrary
{
    public class UsersLibrary
    {
        public static void Userslibrary()
        {
            User[] usersArray = new User[3]
                {
                    new User(13663, "bobsky", "bob123", new string[] {"Message1", "Message2"}),
                    new User(13664, "greg", "greg123", new string[] { "Message3", "Message4"}),
                    new User(13665, "doe", "doe123", new string[] {"Message5", "Message6" })
                };

            bool accountValidation = false;
            while (!accountValidation)
            {
                Console.WriteLine("Do you want to: \n 1. Log in \n 2. Register");
                string account = Console.ReadLine();

                if (account == "1")
                {
                    Login.LogIn(usersArray);
                    accountValidation = true;

                }
                else if (account == "2")
                {
                    Registration.Register(usersArray);
                    accountValidation = true;
                }
                else
                {
                    Console.WriteLine("Choose correct option.");
                    accountValidation = false;
                }

            }
        }
    }
}
