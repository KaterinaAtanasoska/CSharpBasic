using ProjectLibrary.Model;
using ServicesLibrary.Registration;
using System;
using System.Collections.Generic;
using System.Text;

namespace ServicesLibrary
{
    public static class LoggedInEmployee
    {        
        public static void loggedInEmployee ()
        {
            bool employeeOptionValidation = false;

            while (!employeeOptionValidation) {
                Console.WriteLine("Please choose one of the following options:");
                Console.WriteLine("1. See all the registered members in the movie store");
                Console.WriteLine("2. See all the movies available for renting");
                Console.WriteLine("3. Add new members");
                Console.WriteLine("4. Delete existing members");
                
                int employeeOption = Convert.ToInt32(Console.ReadLine());

                if (employeeOption == 1)
                {                    
                    MembersInfo.PrintMembers();

                    while (true)
                    {
                        Console.WriteLine("Do you want to continue?(y/n)");
                        string continueChoice = Console.ReadLine();
                        if (continueChoice == "y" || continueChoice == "Y")
                        {
                            Console.Clear();
                            employeeOptionValidation = false;
                            break;
                        }
                        else if (continueChoice == "n" || continueChoice == "N")
                        {
                            employeeOptionValidation = true;
                            break;
                        }
                        else
                        {
                            Console.WriteLine("Incorrect input. Try again.");
                            Console.ReadLine();
                            Console.Clear();
                            continue;
                        }
                    }
                }
                else if (employeeOption == 2)
                {
                    MoviesInfo.ShowMovies();

                    while (true)
                    {
                        Console.WriteLine("Do you want to continue?(y/n)");
                        string continueChoice = Console.ReadLine();
                        if (continueChoice == "y" || continueChoice == "Y")
                        {
                            Console.Clear();
                            employeeOptionValidation = false;
                            break;
                        }
                        else if (continueChoice == "n" || continueChoice == "N")
                        {
                            employeeOptionValidation = true;
                            break;
                        }
                        else
                        {
                            Console.WriteLine("Incorrect input. Try again.");
                            Console.ReadLine();
                            Console.Clear();
                            continue;
                        }
                    }
                }
                else if (employeeOption == 3)
                {                    
                    int registerType = 0;
                    bool registerTypeValidation = false;

                    while (!registerTypeValidation)
                    {
                        Console.WriteLine("1. Register new user.");
                        Console.WriteLine("2. Register new employee.");
                        bool ageBool = int.TryParse(Console.ReadLine(), out registerType);

                        if (!ageBool)
                        {
                            Console.WriteLine("Incorrect input");
                            registerTypeValidation = false;
                        }

                        if (registerType == 0 || registerType > 2)
                        {
                            Console.WriteLine("Incorrect input");
                            registerTypeValidation = false;
                        }

                        registerTypeValidation = true;
                    }

                    if (registerType == 1)
                    {
                        RegisterUser.registerUser();
                    }

                    if (registerType == 2)
                    {
                        RegisterEmployee.registerEmployee();
                    }

                    while (true)
                    {
                        Console.WriteLine("Do you want to continue?(y/n)");
                        string continueChoice = Console.ReadLine();
                        if (continueChoice == "y" || continueChoice == "Y")
                        {
                            Console.Clear();
                            employeeOptionValidation = false;
                            break;
                        }
                        else if (continueChoice == "n" || continueChoice == "N")
                        {
                            employeeOptionValidation = true;
                            break;
                        }
                        else
                        {
                            Console.WriteLine("Incorrect input. Try again.");
                            Console.ReadLine();
                            Console.Clear();
                            continue;
                        }
                    }
                }
                else if (employeeOption == 4)
                {
                    MembersInfo.DeleteMember();

                    while (true)
                    {
                        Console.WriteLine("Do you want to continue?(y/n)");
                        string continueChoice = Console.ReadLine();
                        if (continueChoice == "y" || continueChoice == "Y")
                        {
                            Console.Clear();
                            employeeOptionValidation = false;
                            break;
                        }
                        else if (continueChoice == "n" || continueChoice == "N")
                        {
                            employeeOptionValidation = true;
                            break;
                        }
                        else
                        {
                            Console.WriteLine("Incorrect input. Try again.");
                            Console.ReadLine();
                            Console.Clear();
                            continue;
                        }
                    }                    
                }
                else
                {
                    Console.WriteLine("Incorrect input. Press enter to try again!");
                    Console.ReadLine();
                    Console.Clear();
                    employeeOptionValidation = false;
                }
            }
        }
    }
}
