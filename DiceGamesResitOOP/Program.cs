using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace DiceGamesResitOOP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Menu();
            }
        }
        public static void Menu() //Displays main menu
        {
            string menuOption = ""; //Allows for user input
            Console.WriteLine("-----------------------------");
            Console.ForegroundColor = ConsoleColor.Magenta; //Sets text magenta to look nice
            Console.BackgroundColor = ConsoleColor.White; //Sets background white to look nice
            Console.WriteLine("    C H O O S E   G A M E   ");
            Console.ResetColor(); //Resets text colour
            Console.WriteLine("-----------------------------");
            Console.WriteLine("                            ");
            Console.WriteLine("Play Sevens Out ---- Press 1");
            Console.WriteLine("Play Three Or More - Press 2");
            Console.WriteLine("Testing Mode ------- Press 3");
            Console.WriteLine("View statistics ---- Press 4");
            Console.WriteLine("Exit Application --- Press 5");
            Console.WriteLine("                            ");
            Console.WriteLine("-----------------------------");
            menuOption = Console.ReadLine(); //User input
            switch (menuOption)
            {
                case "1": //Starts Sevens Out
                    GameSevensOut.StartSevensOut();
                    break;
                case "2": //Starts Three Or More
                    GameThreeOrMore.StartThreeOrMore();
                   break;
                case "3": //Starts testing mode
                    Testing.StartTesting();
                    break;
                case "4": //View statistics
                    Statistics.StartStatistics();
                    break;
                case "5": //Closes application
                    CloseApplication();
                    break;
                default: //Error handles invalid input
                    Console.WriteLine("Invalid input!");
                    Console.WriteLine("              ");
                    Console.WriteLine(" ------------------------------------------");
                    Console.WriteLine("              ");
                    break;
            }
        }

        static void CloseApplication() //Closes application
        {
            Console.WriteLine("Exiting the application...");
            Environment.Exit(0);
        }
    }
}