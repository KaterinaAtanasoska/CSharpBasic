using System;
using System.Collections.Generic;
using System.Text;

namespace ServicesLibrary.LogInOptions
{
    public static class LoggedInUser
    {
        public static void loggedInUser()
        {
            bool userOptionValidation = false;
                       
                while (!userOptionValidation)
                {
                    Console.WriteLine("Please choose one of the following options:");
                    Console.WriteLine("1. See info");
                    Console.WriteLine("2. Select a movie from the list");
                    Console.WriteLine("3. See all the rented movies");
                    
                    int userOption = Convert.ToInt32(Console.ReadLine());

                    if (userOption == 1)
                    {
                        MembersInfo.subsExpirationt();

                    while (true)
                    {
                        Console.WriteLine("Do you want to continue?(y/n)");
                        string continueChoice = Console.ReadLine();
                        if (continueChoice == "y" || continueChoice == "Y")
                        {
                            Console.Clear();
                            userOptionValidation = false;
                            break;
                        }
                        else if (continueChoice == "n" || continueChoice == "N")
                        {
                            userOptionValidation = true;
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
                    else if (userOption == 2)
                    {
                        MoviesInfo.SelectMovie();
                        userOptionValidation = true;

                    while (true)
                    {
                        Console.WriteLine("Do you want to continue?(y/n)");
                        string continueChoice = Console.ReadLine();
                        if (continueChoice == "y" || continueChoice == "Y")
                        {
                            Console.Clear();
                            userOptionValidation = false;
                            break;
                        }
                        else if (continueChoice == "n" || continueChoice == "N")
                        {
                            userOptionValidation = true;
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
                    else if (userOption == 3)
                    {
                        MembersInfo.RentedMovies();
                        userOptionValidation = true;

                    while (true)
                    {
                        Console.WriteLine("Do you want to continue?(y/n)");
                        string continueChoice = Console.ReadLine();
                        if (continueChoice == "y" || continueChoice == "Y")
                        {
                            Console.Clear();
                            userOptionValidation = false;
                            break;
                        }
                        else if (continueChoice == "n" || continueChoice == "N")
                        {
                            userOptionValidation = true;
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
                        userOptionValidation = false;                    
                    }                
                }            
        }
    }
}
