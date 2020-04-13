
using System;
using System.Collections.Generic;
using System.Text;

namespace AccountLibrary
{
    class Registration
    {
        public static void Register(User[] usersArray)
        {
            User registerUser = new User();

            bool registerValidation = false;
            while (!registerValidation)
            {

                Console.WriteLine("Please insert ID:");

                bool idValidation = int.TryParse(Console.ReadLine(), out int idNumber);

                if (!idValidation)
                {
                    Console.WriteLine("Please enter valid ID.");
                    registerValidation = false;
                }
                else
                {
                    registerUser.Id = idNumber;
                    registerValidation = true;
                }
            }


            Console.WriteLine("Please insert username:");
            registerUser.Username = Console.ReadLine();

            Console.WriteLine("Please insert password:");
            registerUser.Password = Console.ReadLine();
                       

            bool newUser = false;

            while (!newUser)
            {
                foreach (var user in usersArray)
                {
                    if (user.Username == registerUser.Username)
                    {
                        Console.WriteLine("Username not available, try with another username:");
                        Console.WriteLine("Please insert ID:");
                        registerUser.Id = Int32.Parse(Console.ReadLine());

                        Console.WriteLine("Please insert username:");
                        registerUser.Username = Console.ReadLine();

                        Console.WriteLine("Please insert password:");
                        registerUser.Password = Console.ReadLine();                                                
                    }
                }

                if (!newUser)
                {
                    Array.Resize(ref usersArray, usersArray.Length + 1);
                    usersArray[usersArray.Length - 1] = registerUser;

                    newUser = true;
                }

            }            

            Console.WriteLine("Registration complete!");
            foreach (var user in usersArray)
            {
                Console.WriteLine($"ID: {user.Id} Username: {user.Username} ");

            }

            string[] messagesTemp = new string[2];

            Console.WriteLine("Do you want to enter messages? (yes or no)");
            string answer = Console.ReadLine();

            bool insertMessages = false;

            while (!insertMessages) {
                if (answer.ToLower() == "yes")
                {
                    Console.WriteLine("Enter your first message here:");
                    string message1 = Console.ReadLine();
                    messagesTemp[0] = message1;

                    Console.WriteLine("Enter your first message here:");
                    string message2 = Console.ReadLine();
                    messagesTemp[1] = message2;

                    registerUser.Messages = messagesTemp;

                    Console.WriteLine($"Welcome {registerUser.Username}. Here are your messages:");
                    foreach (var message in registerUser.Messages)
                    {
                        Console.WriteLine(message);
                    }

                    UsersLibrary.Userslibrary();
                    insertMessages = true;
                }
                else if (answer.ToLower() == "no")
                {
                    Console.WriteLine("Thank you for registering");
                    insertMessages = true;
                }
                else
                {
                    Console.WriteLine("Please enter correct answer (yes or no)");
                    answer = Console.ReadLine();
                    insertMessages = false;
                }
            }
        }
    }
}
