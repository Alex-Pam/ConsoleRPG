using System;
using System.Collections.Generic;
namespace ConsoleRPG
{


    class Program

    {
        static void  Main(string[] args)
        {
            Console.Title = "RPG";
            Console.Write("Greetings wanderer, what is your name ?\n* ");
            Player player = new Player(Console.ReadLine());
            Console.WriteLine("----------------------------------------");
            bool Flag = false;
            while (Flag != true)
            {
                Console.WriteLine("Do you want to go on a trip ? Yes/No");
                string userResponse = Console.ReadLine().ToLower();
                switch (userResponse)
                {
                    case "yes":
                        Flag = true;
                        break;
                    case "no":
                        Console.WriteLine("You have no choice xD");
                        Console.WriteLine("----------------------------------------");
                        break;
                    default:
                        Console.WriteLine("Incorrect input ! Try again");
                        Console.WriteLine("----------------------------------------");
                        break;
                }
                }
            Console.WriteLine("Ok,let's get started");
            Console.WriteLine("----------------------------------------");
            Menu(player);

            
        }
        static void Menu(Player player)
        {
            Console.WriteLine("Choose action");
            Console.WriteLine("----------------------------------------");
            Console.WriteLine("1: Get information about a character ");
            Console.WriteLine("2: Get inventory information  ");
            int playersChoice = Int32.Parse(Console.ReadLine());
            Console.Clear();
            switch (playersChoice)
            {
                case 1:
                    player.GetInfo();
                    Console.WriteLine("----------------------------------------");
                    Console.WriteLine("Press any button to return to the menu");
                    Console.ReadKey();
                    Console.Clear();
                    Menu(player);
                    break;
                case 2:
                    player.GetInentory();
                    Console.WriteLine("----------------------------------------");
                    Console.WriteLine("Press any button to return to the menu");
                    Console.ReadKey();
                    Console.Clear();
                    Menu(player);
                    break;
                case 3:
                    Console.WriteLine("----------------------------------------");
                    //Console.WriteLine("");
                    Menu(player);

                    break;
            }

            Console.ReadKey();
        }
        }
   }

