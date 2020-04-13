using System;
using System.Collections.Generic;
using System.Text;

namespace AccountLibrary
{
    class Login
    {
        public static void LogIn(User[] usersArray)
        {
            Console.WriteLine("Insert username:");
            string username = Console.ReadLine();

            Console.WriteLine("Insert password:");
            string password = Console.ReadLine();

            bool userFound = false;

            while (!userFound)
            {
                foreach (var user in usersArray)
                {
                    if (user.Username == username && user.Password == password)
                    {
                        Console.WriteLine($"Welcome {user.Username}. Here are your messages:");
                        foreach (var message in user.Messages)
                        {
                            Console.WriteLine(message);
                            userFound = true;
                        }
                    }

                    if (!userFound)
                    {
                        Console.WriteLine("Invalid username or password, please try again");
                        Console.WriteLine("Insert username:");
                        username = Console.ReadLine();
                        Console.WriteLine("Insert password:");
                        password = Console.ReadLine();
                    }
                }
            }

        }
    }
}
