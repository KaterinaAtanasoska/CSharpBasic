using System;

namespace HeroesJourney
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {

                #region Log in the game 


                string[] email = new string[]
                {
                "bob@mail.com",
                 "mail@mail.com"
                };
                string[] password = new string[]
                {
                "aa22aa",
                "bb11bb"
                };


                int count = 0;

                while (true)
                {
                    if (count == 5)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Login failed");
                        Console.ResetColor();
                        break;
                    }
                    Console.ForegroundColor= ConsoleColor.Blue;
                    Console.WriteLine("Enter username:");
                    string username = Console.ReadLine();

                    if (String.Equals(email[0], username) && username.Length != 0 && username.Contains('@') && username.Contains('.') ||
                        String.Equals(email[1], username) && username.Length != 0 && username.Contains('@') && username.Contains('.'))
                    {

                        Console.WriteLine("Enter password:");
                        string pass = Console.ReadLine();

                        if (String.Equals(password[0], pass) && pass.Length != 0 ||
                            String.Equals(password[1], pass) && pass.Length != 0)
                        {
                            Console.WriteLine("Welcome to Heroes Journey!");
                            break;
                        }

                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Invalid e-mail or password.");
                        count++;
                        Console.ResetColor();
                    }
                }
                Console.ResetColor();

                #endregion

                #region Create a character 
                int health = 0;
                int agility = 0;
                int strength = 0;

                while (true)
                {
                    Console.WriteLine("Enter hero's name:");
                    string name = Console.ReadLine();

                    if (name.Length <= 1 || name.Length >= 20)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Error! Too long or too short name.");                        
                        Console.ResetColor();
                        continue;
                    }

                    string heroRace;

                    while (true)
                    {

                        Console.WriteLine("Choose hero's race: \n " +
                            "1 ) Dwarf \n " +
                            "2 ) Elf \n " +
                            "3 ) Human");

                        string race = Console.ReadLine();

                        if (race == "1")
                        {
                            heroRace = "Dwarf";
                            health = 100;
                            strength = 6;
                            agility = 2;
                            break;

                        }
                        if (race == "2")
                        {
                            heroRace = "Elf";
                            health = 60;
                            strength = 4;
                            agility = 6;
                            break;
                        }
                        if (race == "3")
                        {
                            heroRace = "Human";
                            health = 80;
                            strength = 5;
                            agility = 4;
                            break;
                        }

                        if (race != "1" || race != "2" || race != "3")
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("Error! Please enter valid hero.");
                            Console.ResetColor();
                            continue;
                        }

                    }
                                        
                    string heroClass;

                    while (true)
                    {
                        Console.WriteLine("Choose your class: \n " +
                            "1 ) Warrior \n " +
                            "2 ) Rogue \n " +
                            "3 ) Mage");

                        string chosenClass = Console.ReadLine();


                        if (chosenClass == "1")
                        {
                            heroClass = "Warrior";
                            health += 20;
                            agility -= 1;
                            break;
                        }

                        if (chosenClass == "2")
                        {
                            heroClass = "Rogue";
                            health -= 20;
                            agility += 1;
                            break;
                        }

                        if (chosenClass == "3")
                        {
                            heroClass = "Mage";
                            health += 20;
                            strength -= 1;
                            break;
                        }

                        if (chosenClass != "1" || chosenClass != "2" || chosenClass != "3")
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("Error! Please enter valid class.");
                            Console.ResetColor();
                            continue;
                        }

                    }

                    Console.WriteLine("Your hero was successfully created.");
                    Console.WriteLine("You are " + name + ", a " + heroRace + " " + heroClass);
                    Console.WriteLine("Your stats: " + health + "HP, " + strength + "STR, " + agility + "AGI");
                    break;

                }
                #endregion

                #region Gameplay
                           
                while (true)
                {
                    
                    Console.WriteLine("Bandits attack you out of nowhere. They seem very dangerous...");
                    Console.WriteLine("Health: " + health + "\n " +
                        "1) Fight \n " +
                        "2) Run");
                    
                    string bandits = Console.ReadLine();


                    Random num1 = new Random();
                    int number1 = num1.Next(1, 11);

                    if (bandits == "1")
                    {
                        if (number1 < strength)
                        {
                            Console.WriteLine("You won the fight");
                            break;
                        }
                        else
                        {
                            health -= 20;
                            break;
                        }
                    }


                    if (bandits == "2")
                    {
                        if (number1 < agility)
                        {
                            Console.WriteLine("You mannaged to run away");
                            break;
                        }
                        else
                        {
                            health -= 20;
                            break;
                        }
                    }

                    if (bandits != "1" || bandits != "2")
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Invalid input");
                        Console.ResetColor();
                        continue;
                    }
                }


                if (health <= 0)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("YOU LOST ! \n Do you want to start a new game ? ");
                    Console.ResetColor();

                    string newGame1;
                    while (true)
                    {
                        Console.WriteLine(
                            "1 ) Yes - Restarts the game \n " +
                            "2 ) No - Exits the application");

                        newGame1 = Console.ReadLine();

                        if (newGame1 == "1")
                        {
                            continue;
                        }
                        if (newGame1 == "2")
                        {
                            break;
                        }

                        if (newGame1 != "1" || newGame1 != "2")
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("Invalid input");
                            Console.ResetColor();
                            continue;
                        }
                        else
                        {
                            break;

                        }
                    }


                }

                
                while (true)
                {
                    Console.WriteLine("You bump in to one of the guards of the nearby village. They attack you without warning...");
                    Console.WriteLine("Health: " + health + "\n " +
                        "1) Fight \n" +
                        " 2) Run");
                    
                    string guards = Console.ReadLine();

                    Random num2 = new Random();
                    int number2 = num2.Next(1, 11);

                    if (guards == "1")
                    {
                        if (number2 < strength)
                        {
                            Console.WriteLine("You won the fight");
                            break;
                        }
                        else
                        {
                            health -= 30;
                            break;
                        }
                    }


                    if (guards == "2")
                    {
                        if (number2 < agility)
                        {
                            Console.WriteLine("You mannaged to run away");
                            break;
                        }
                        else
                        {
                            health -= 30;
                            break;
                        }
                    }

                    if (guards != "1" || guards != "2")
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Invalid input");
                        Console.ResetColor();
                        continue;
                    }

                }

                if (health <= 0)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("YOU LOST ! \n Do you want to start a new game ? ");
                    Console.ResetColor();

                    int newGame2;
                    while (true)
                    {
                        Console.WriteLine("1 ) Yes - Restarts the game \n 2 ) No - Exits the application");

                        bool parsNewGame2 = int.TryParse(Console.ReadLine(), out newGame2);

                        if (!parsNewGame2 || newGame2 < 1 || newGame2 > 2)
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("Invalid input");
                            Console.ResetColor();
                            continue;
                        }
                        else
                        {
                            break;

                        }
                    }


                    if (newGame2 == 1)
                    {
                        continue;
                    }
                    if (newGame2 == 2)
                    {
                        break;
                    }


                }


                
                while (true)
                {
                    Console.WriteLine("A Land Shark appears. It starts chasing you down to eat you...");
                    Console.WriteLine("Health: " + health + "\n 1) Fight \n 2) Run");
                    string shark = Console.ReadLine();

                    Random num3 = new Random();
                    int number3 = num3.Next(1, 11);

                    if (shark == "1")
                    {
                        if (number3 < strength)
                        {
                            Console.WriteLine("You won the fight");
                            break;
                        }
                        else
                        {
                            health -= 50;
                            break;
                        }
                    }


                    if (shark == "2")
                    {
                        if (number3 < agility)
                        {
                            Console.WriteLine("Run away");
                            break;
                        }
                        else
                        {
                            health -= 50;
                            break;
                        }
                    }

                    if (shark != "1" || shark != "2")
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Invalid input");
                        Console.ResetColor();
                        continue;
                    }

                }

                if (health <= 0)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("YOU LOST ! \n Do you want to start a new game ? ");
                    Console.ResetColor();

                    int newGame3;
                    while (true)
                    {
                        Console.WriteLine("1 ) Yes - Restarts the game \n 2 ) No - Exits the application");

                        bool parsNew3 = int.TryParse(Console.ReadLine(), out newGame3);

                        if (!parsNew3 || newGame3 < 1 || newGame3 > 2)
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("Invalid input");
                            Console.ResetColor();
                            continue;
                        }
                        else
                        {
                            break;

                        }
                    }


                    if (newGame3 == 1)
                    {
                        continue;
                    }
                    if (newGame3 == 2)
                    {
                        break;
                    }


                }

                                
                while (true)
                {
                    Console.WriteLine("You accidentally step on a rat. His friends are not happy. They attack...");
                    Console.WriteLine("Health: " + health + "\n " +
                        "1) Fight \n " +
                        "2) Run");

                    string rat = Console.ReadLine();

                    Random num4 = new Random();
                    int number4 = num4.Next(1, 11);

                    if (rat == "1")
                    {
                        if (number4 < strength)
                        {
                            Console.WriteLine("You won the fight");
                            break;
                        }
                        else
                        {
                            health -= 10;
                            break;
                        }
                    }


                    if (rat == "2")
                    {
                        if (number4 < agility)
                        {
                            Console.WriteLine("Run away");
                            break;
                        }
                        else
                        {
                            health -= 10;
                            break;
                        }
                    }


                    if (rat != "1" || rat != "2")
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Invalid input");
                        Console.ResetColor();
                        continue;
                    }

                }

                if (health <= 0)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("YOU LOST ! \n Do you want to start a new game ? ");
                    Console.ResetColor();

                    int newGame4;
                    while (true)
                    {
                        Console.WriteLine("1 )Yes - Restarts the game \n 2 ) No - Exits the application");

                        bool parsNew4 = int.TryParse(Console.ReadLine(), out newGame4);

                        if (!parsNew4 || newGame4 < 1 || newGame4 > 2)
                        {
                            Console.WriteLine("Invalid iput");
                            continue;
                        }
                        else
                        {
                            break;

                        }
                    }


                    if (newGame4 == 1)
                    {
                        continue;
                    }
                    if (newGame4 == 2)
                    {
                        break;
                    }


                }


                
                while (true)
                {
                    Console.WriteLine("You find a huge rock. It comes alive somehow and tries to smash you...");
                    Console.WriteLine("Health: " + health + "\n " +
                        "1) Fight \n " +
                        "2) Run");

                    string rock = Console.ReadLine();

                    Random num5 = new Random();
                    int number5 = num5.Next(1, 11);

                    if (rock == "1")
                    {
                        if (number5 < strength)
                        {
                            Console.WriteLine("You won the fight");
                            break;
                        }
                        else
                        {
                            health -= 30;
                            break;
                        }
                    }


                    if (rock == "2")
                    {
                        if (number5 < agility)
                        {
                            Console.WriteLine("Run away");
                            break;
                        }
                        else
                        {
                            health -= 30;
                            break;
                        }
                    }

                    if (rock != "1" || rock != "2")
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Invalid input");
                        Console.ResetColor();
                        continue;
                    }
                }

                if (health <= 0)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("YOU LOST ! \n Do you want to start a new game ? ");
                    Console.ResetColor();

                    int newGame5;
                    while (true)
                    {
                        Console.WriteLine("1 ) Yes - Restarts the game \n 2 ) No - Exits the application");

                        bool parsNew5 = int.TryParse(Console.ReadLine(), out newGame5);

                        if (!parsNew5 || newGame5 < 1 || newGame5 > 2)
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("Invalid input");
                            Console.ResetColor();
                            continue;
                        }
                        else
                        {
                            break;

                        }
                    }


                    if (newGame5 == 1)
                    {
                        continue;
                    }
                    if (newGame5 == 2)
                    {
                        break;
                    }


                }
                else
                {
                    Console.WriteLine("CONGRATULATIONS YOU WON THE GAME! \n Do you want to start a new game ? ");

                    int newGame6;
                    while (true)
                    {
                        Console.WriteLine("1 )Yes - Restarts the game \n 2 ) No - Exits the application");

                        bool parsNew6 = int.TryParse(Console.ReadLine(), out newGame6);

                        if (!parsNew6 || newGame6 < 1 || newGame6 > 2)
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("Invalid input");
                            Console.ResetColor();
                            continue;
                        }
                        else
                        {
                            break;

                        }
                    }


                    if (newGame6 == 1)
                    {
                        continue;
                    }
                    if (newGame6 == 2)
                    {
                        break;
                    }
                }
            }
            #endregion

            Console.ReadLine();
        }
    }
}
