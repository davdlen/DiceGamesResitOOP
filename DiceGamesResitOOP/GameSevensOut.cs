using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Net;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace DiceGamesResitOOP
{
    public class GameSevensOut
    {
        public static void StartSevensOut()
        {
            int sevensOutTotalScore = 0; //Keeps track of total running score across the game
            int highScore = 0; //Keeps track of high score across all games

            Console.WriteLine("                       ");
            Console.WriteLine("                       ");
            Console.ForegroundColor = ConsoleColor.Magenta; //Makes title magenta to look cool
            Console.BackgroundColor = ConsoleColor.Yellow; //Makes title background yellow to look cool
            Console.WriteLine("  S E V E N S   O U T  "); // Title UI
            Console.ResetColor(); //Resets text colour to default
            Console.WriteLine("                       ");

            bool gameOver = false;

            while (!gameOver)
            {
                Console.WriteLine("---------------------------");
                Console.WriteLine("Rolling two dice...  ");
                Console.WriteLine("---------------------------");

                Die die1 = new Die(); //First die
                Die die2 = new Die(); //Second die

                int roll1 = die1.Roll(); //Roll the first die
                int roll2 = die2.Roll(); //Roll the second die
                int sevensOutScore = roll1 + roll2; // Calculate this round's score

                Thread.Sleep(1000); //Wait a few seconds to simulate rolling dice
                Console.WriteLine("Die 1 rolled a {0}", die1.DiceRoll); //Outputting results of rolls to user
                Console.WriteLine("Die 2 rolled a {0}", die2.DiceRoll);
                if (die1.DiceRoll == die2.DiceRoll) //Accounting for doubles rolled
                {
                    sevensOutScore = sevensOutScore * 2; //Doubles this rounds score
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("DOUBLE!");
                    Console.ResetColor();
                }
                sevensOutTotalScore += sevensOutScore; //Adds this round's score to the total game score
                Console.WriteLine("This scores you {0}", sevensOutScore); //Outputs this round's score to user
                Console.WriteLine("Current total score: {0}", sevensOutTotalScore); //Output current total score
                Console.WriteLine("              ");
                
                if (sevensOutScore == 7) //Checks if a 7 has been rolled
                {
                    sevenRolled(); //Calls for game over
                }

                Console.WriteLine("---------------------------");
                Console.WriteLine("Roll Again --- Press 1");
                Console.WriteLine("End Game ----- Press 2");
                Console.WriteLine("---------------------------");
                string userInput = Console.ReadLine();
                switch (userInput)
                {
                    case "1":
                        Console.WriteLine("            "); //Continues the game loop
                        break;
                    case "2":
                        gameEnd(); //Triggers game end
                        break;
                    default:
                        Console.WriteLine("Invalid input."); //Handling incorrect input
                        Console.WriteLine("Roll Again --- Press 1");
                        Console.WriteLine("End Game ----- Press 2");
                        break;
                }
                
                void sevenRolled() //Called when a 7 is rolled
                {
                    sevensOutTotalScore = 0; //They rolled a 7, so all score is lost
                    Console.WriteLine("                      ");
                    Console.ForegroundColor = ConsoleColor.Red; //Makes game over text red 
                    Console.WriteLine("  G A M E   O V E R !  ");
                    Console.ResetColor(); //Resets text colour to default
                    Console.WriteLine("                       ");
                    Console.WriteLine("You rolled a 7!");
                    Console.WriteLine("You lost all your score.");
                    Console.WriteLine("                       ");
                    gameOver = true;
                    AskPlayAgain(); //Play again option
                }

                void gameEnd()
                {
                    Console.WriteLine("            ");
                    Console.WriteLine("Ending game.");
                    Console.WriteLine("Current high score: {0}", highScore);
                    Console.WriteLine("Your final score was {0}", sevensOutTotalScore);
                    if (sevensOutTotalScore > highScore)
                    {
                        highScore = sevensOutTotalScore; //Updates high score if total score is higher
                        Console.ForegroundColor = ConsoleColor.Green; //Colours new high score in green to stand out
                        Console.WriteLine("NEW HIGH SCORE!");
                        Console.ResetColor(); //Resets text colour to default
                    }
                    gameOver = true; //Exits loop and ends the game
                    AskPlayAgain(); //Play again option
                }
            }

            void AskPlayAgain()
            {
                Console.WriteLine("                        ");
                Console.WriteLine("Do you want to play again?");
                Console.WriteLine("Play Again! ------ Press 1");
                Console.WriteLine("Main Menu -------- Press 2");
                string playAgainInput = Console.ReadLine();
                switch (playAgainInput)
                {
                    case "1":
                        Console.WriteLine("---------------------------");
                        StartSevensOut(); //Restarts game
                        break;
                    case "2":
                        Console.WriteLine("---------------------------");
                        Console.WriteLine("                           ");
                        Program.Menu(); //Returns to main menu
                        break;
                    default: // Error handles invalid input
                        Console.WriteLine("Invalid input!");
                        Console.WriteLine("              ");
                        Console.WriteLine(" ------------------------------------------");
                        Console.WriteLine("              ");
                        break;
                }
            }
        }
    }
}
