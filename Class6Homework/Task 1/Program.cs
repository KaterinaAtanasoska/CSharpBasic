using System;

namespace Task_1
{
    class Program
    {        
         static void LogIn(User[] usersArray)
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

        static void Register(User[] usersArray)
        {
            User registerUser = new User();

            Console.WriteLine("Please insert ID:");
            registerUser.Id = Int32.Parse(Console.ReadLine());

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

        }

        static void Main(string[] args)
        {
            User[] usersArray = new User[3]
                {
                    new User(13663, "bobsky", "bob123", new string[] {"Message1", "Message2"}),
                    new User(13664, "greg", "greg123", new string[] { "Message3", "Message4"}),
                    new User(13665, "doe", "doe123", new string[] {"Message5", "Message6" })
                };

            while (true)
            {
                Console.WriteLine("Do you want to: \n 1. Log in \n 2. Register");
                string nesto = Console.ReadLine();

                if (nesto == "1")
                {
                    LogIn(usersArray);
                    break;

                }
                else if (nesto == "2")
                {
                    Register(usersArray);
                    break;
                }
                else
                {
                    Console.WriteLine("Choose correct number.");
                    continue;
                }

            }
        }
    }
}
