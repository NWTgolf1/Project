using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TreasureSeekerFirstGame
{ 
    class Program
    {
        public static void Main(string[] args)
        {
            //Game Intro
            Console.WriteLine("Welcome to the first Treasure Seeker game! What is your name, Treasure Seeker?");
            string player_Name = Console.ReadLine();
            Console.WriteLine("Welcome " + player_Name + "!");
            Console.WriteLine("Your treasure quest awaits you! [Press any key to proceed...]");
            Console.ReadKey();

            Console.WriteLine("You come accross an old temple");
            Console.WriteLine("You walk up to the entrance of the temple, do you Enter: [Yes or No?]");
            string FirstAnswer = Console.ReadLine();
            if (FirstAnswer == "Yes")
            {
                Console.WriteLine(player_Name + " entered into the first Room");
            }
            else if (FirstAnswer == "No")
            {
                Console.WriteLine(player_Name + " chickened out and turned around, GAME OVER!");
                Console.ReadLine();
                return;
            }
            else
            {
                Console.WriteLine("Invalid Entry, GAME OVER!");
                Console.ReadKey();
                return;
            }

            Console.WriteLine("You are in Room 1. You see two doors ahead of you, one marked 2 and one marked 3.  Door 2 looks old and and smells of death while door 3 looks very inviting, type in your selection.  [Type 2 or 3 and hit enter to proceed]: ");
            string Room = Console.ReadLine();

            switch (Room)
            {
                //Choose Wrong Room from the start
                case ("2"):
                    {
                        Console.WriteLine("You are in Room 2, You fall into a bottomless pit. Game Over!");
                        Room = Console.ReadLine();
                        break;
                    }
                case ("3"):
                    {
                        Console.WriteLine("You are in Room 3, and safe, choose you see two more doors marked 4 and 5.  Door 4 looks like a very old door, red in color.  Door 5 looks very new and shiny and green in color.  [Type 4 or 5 to proceed]: ");
                        Room = Console.ReadLine();
                        //Right room, we continue...
                        switch (Room)
                        {
                            case ("4"):
                                {
                                    Console.WriteLine("You are in Room 4, Your quests continues.  You see two more doors marked 6 and 7.  They both look the same except room 6 appears to have red eyes if you look underneath and room 7 appears dark on the other side. [Type 6 or 7 to proceed]: ");
                                    Room = Console.ReadLine();
                                    switch (Room)
                                    {
                                        //Chose Wrong Room
                                        case ("6"):
                                            {
                                                Console.WriteLine("You are in Room 6, You fall into a pit of poisonous snakes. Game Over!");
                                                Room = Console.ReadLine();
                                                break;
                                            }
                                        case ("7"):
                                            {
                                                Console.WriteLine("You are in Room 7, Your current quest still continues. How many Rooms are there?  [Type in 8 or 9]");
                                                Room = Console.ReadLine();
                                                switch (Room)
                                                {
                                                    case ("8"):
                                                        {
                                                            Console.WriteLine("You are in Room 8. You found the Treasure Room! You see there is an abundance of treasure. Congrats You WON!");
                                                            Console.ReadKey();
                                                            break;
                                                        }
                                                    case ("9"):
                                                        {
                                                            Console.WriteLine("You are in Room 9. You have fallen in a lava pit and burned alive, You LOSE!");
                                                            Console.ReadKey();
                                                            break;
                                                        }
                                                    default:
                                                        {
                                                            Console.WriteLine("Invalid Entry, GAME OVER!");
                                                            Console.ReadKey();
                                                            break;
                                                        }
                                                }
                                                break;
                                            }
                                        default:
                                            {
                                                Console.WriteLine("Invalid Entry, GAME OVER!");
                                                Console.ReadKey();
                                                break;
                                            }
                                    }
                                    break;
                                }
                            case ("5"):
                                {
                                    Console.WriteLine("You are in Room 5, Hidden arrows impale you. Game Over!");
                                    Console.ReadKey();
                                    break;
                                }
                            default:
                                {
                                    Console.WriteLine("Invalid Entry, GAME OVER!");
                                    Console.ReadKey();
                                    break;
                                }
                        }
                        break;
                    }
            }
        }
    }
}
