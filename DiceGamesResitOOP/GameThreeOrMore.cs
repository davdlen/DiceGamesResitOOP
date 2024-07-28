using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiceGamesResitOOP
{
    internal class GameThreeOrMore
    {
        public static void StartThreeOrMore()
        {
            Console.WriteLine("                       ");
            Console.WriteLine("                       ");
            Console.ForegroundColor = ConsoleColor.DarkBlue; //Makes title dark blue to look cool
            Console.BackgroundColor = ConsoleColor.Cyan; //Makes title background cyan to look cool
            Console.WriteLine("  T H R E E   O R   M O R E  "); //Title UI
            Console.ResetColor(); //Resets text colour to default
            Console.WriteLine("                       ");

            bool gameOver = false;
            int totalScore = 0; //Total points across the whole game
            int currentScore = 0; //Score given after dice rolls ended

            while (!gameOver)
            {
                Console.WriteLine("---------------------------");
                Console.WriteLine("Rolling five dice...  ");
                Console.WriteLine("---------------------------");

                Die die1 = new Die(); //First die
                Die die2 = new Die(); //Second die
                Die die3 = new Die(); //Third die
                Die die4 = new Die(); //Fourth die
                Die die5 = new Die(); //Fifth die

                int roll1 = die1.Roll(); //Rolls the first die
                int roll2 = die2.Roll(); //Rolls the second die
                int roll3 = die3.Roll(); //Rolls the third die
                int roll4 = die4.Roll(); //Rolls the fourth die
                int roll5 = die5.Roll(); //Rolls the fifth die


                Thread.Sleep(1000); //Wait a few seconds to simulate rolling dice
                Console.WriteLine("                       ");
                Console.WriteLine("  -------------------  ");
                Console.WriteLine(" | {0} | {1} | {2} | {3} | {4} | ", roll1, roll2, roll3, roll4, roll5); //Displays the rolled dice values to player
                Console.WriteLine("  -------------------  ");
                Console.WriteLine("                       ");
                Console.WriteLine("Would you like to reroll?");
                Console.WriteLine("Reroll all ------------ Press 1");
                Console.WriteLine("Reroll specific dice -- Press 2");
                Console.WriteLine("Don't reroll ---------- Press 3");
                string userInput = Console.ReadLine();
                switch (userInput)
                {
                    case "1":
                        Console.WriteLine("Rerolling all 5 dice...");
                        rerollAll(); //Calls the reroll all function
                        break;
                    case "2":
                        Console.WriteLine("         ");
                        rerollCustom(); //Calls the reroll custom die function
                        break;
                    case "3":
                        noReroll(); //No reroll
                        break;
                    default: //Error handling for invalid input
                        Console.WriteLine("              ");
                        Console.WriteLine("Invalid input.");
                        Console.WriteLine("Reroll all ------------ Press 1");
                        Console.WriteLine("Reroll specific dice -- Press 2");
                        Console.WriteLine("Don't reroll ---------- Press 3");
                        break;
                }

                void rerollAll() //Called when the user wants to reroll all 5 dice
                {
                    int roll1 = die1.Roll(); //Rolls the first die again
                    int roll2 = die2.Roll(); //Rolls the second die again
                    int roll3 = die3.Roll(); //Rolls the third die again
                    int roll4 = die4.Roll(); //Rolls the fourth die again
                    int roll5 = die5.Roll(); //Rolls the fifth die again
                    Thread.Sleep(1000); //Wait a few seconds to simulate rolling dice
                    Console.WriteLine("                       ");
                    Console.WriteLine("  -------------------  ");
                    Console.WriteLine(" | {0} | {1} | {2} | {3} | {4} | ", roll1, roll2, roll3, roll4, roll5); //Displays the rolled dice values to player
                    Console.WriteLine("  -------------------  ");
                    Console.WriteLine("                       ");
                    scoreCalculation();
                }

                void rerollCustom() //Called when the user wants to only reroll specific dice
                {
                    Console.WriteLine("Which dice would you like to reroll?");
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("YES = 1");
                    Console.WriteLine("NO = ANY OTHER KEY");
                    Console.ResetColor();
                    Console.WriteLine("       ");
                    Console.WriteLine("Dice 1?");
                    string dice1Reroll = Console.ReadLine();
                    Console.WriteLine("Dice 2?");
                    string dice2Reroll = Console.ReadLine();
                    Console.WriteLine("Dice 3?");
                    string dice3Reroll = Console.ReadLine();
                    Console.WriteLine("Dice 4?");
                    string dice4Reroll = Console.ReadLine();
                    Console.WriteLine("Dice 5?");
                    string dice5Reroll = Console.ReadLine();
                    Console.WriteLine("Rerolling selected dice...");

                    if (dice1Reroll == "1")
                    {
                        int roll1 = die1.Roll();
                    }
                    if (dice2Reroll == "1")
                    {
                        int roll2 = die2.Roll();
                    }
                    if (dice3Reroll == "1")
                    {
                        int roll3 = die3.Roll();
                    }
                    if (dice4Reroll == "1")
                    {
                        int roll4 = die4.Roll();
                    }
                    if (dice5Reroll == "1")
                    {
                        int roll5 = die5.Roll();
                    }
                    Thread.Sleep(1000); //Wait a few seconds to simulate rolling dice
                    Console.WriteLine("                       ");
                    Console.WriteLine("  -------------------  ");
                    Console.WriteLine(" | {0} | {1} | {2} | {3} | {4} | ", roll1, roll2, roll3, roll4, roll5); //Displays the rolled dice values to player
                    Console.WriteLine("  -------------------  ");
                    Console.WriteLine("                       ");
                    scoreCalculation();
                }

                void noReroll() //Called when the user doesn't want to reroll any dice
                {
                    scoreCalculation();
                }

                void scoreCalculation() //Called to end the game and count the score
                {
                    Console.WriteLine("Game ended!");
                    bool fiveEqual = (roll1 == roll2 && roll2 == roll3 && roll3 == roll4 && roll4 == roll5); //All 5 rolls are equal.

                    bool fourEqual = ((roll1 == roll2 && roll2 == roll3 && roll3 == roll4 && roll4 != roll5) || //4 of 5 equal: roll5 is not
                                     (roll1 == roll2 && roll2 == roll3 && roll3 == roll5 && roll5 != roll4) ||  //4 of 5 equal: roll4 is not
                                     (roll1 == roll2 && roll2 == roll4 && roll4 == roll5 && roll5 != roll3) ||  //4 of 5 equal: roll3 is not
                                     (roll1 == roll3 && roll3 == roll4 && roll4 == roll5 && roll5 != roll2) ||  //4 of 5 equal: roll2 is not
                                     (roll2 == roll3 && roll3 == roll4 && roll4 == roll5 && roll5 != roll1));   //4 of 5 equal: roll1 is not

                    bool threeEqual = ((roll1 == roll2 && roll2 == roll3 && roll3 != roll4 && roll3 != roll5) || //3 of 5 equal: roll4 and roll5 not
                                      (roll1 == roll2 && roll2 == roll4 && roll4 != roll3 && roll4 != roll5) ||  //3 of 5 equal: roll3 and roll5 not
                                      (roll1 == roll2 && roll2 == roll5 && roll5 != roll3 && roll5 != roll4) ||  //3 of 5 equal: roll3 and roll4 not
                                      (roll1 == roll3 && roll3 == roll4 && roll4 != roll2 && roll4 != roll5) ||  //3 of 5 equal: roll2 and roll5 not
                                      (roll1 == roll3 && roll3 == roll5 && roll5 != roll2 && roll5 != roll4) ||  //3 of 5 equal: roll2 and roll4 not
                                      (roll1 == roll4 && roll4 == roll5 && roll5 != roll2 && roll5 != roll3) ||  //3 of 5 equal: roll2 and roll3 not
                                      (roll2 == roll3 && roll3 == roll4 && roll4 != roll1 && roll4 != roll5) ||  //3 of 5 equal: roll1 and roll5 not
                                      (roll2 == roll3 && roll3 == roll5 && roll5 != roll1 && roll5 != roll4) ||  //3 of 5 equal: roll1 and roll4 not
                                      (roll2 == roll4 && roll4 == roll5 && roll5 != roll1 && roll5 != roll3) ||  //3 of 5 equal: roll1 and roll3 not
                                      (roll3 == roll4 && roll4 == roll5 && roll5 != roll1 && roll5 != roll2));   //3 of 5 equal: roll1 and roll2 not

                    bool underThreeEqual = (threeEqual == false && fourEqual == false && fiveEqual == false); //All unique, or only 2 equal

                    if (fiveEqual == true)
                    {
                        currentScore = 12; //Five matching gives score of 12
                        gameEnd();
                    }
                    else if (fourEqual == true)
                    {
                        currentScore = 6; //Four matching gives score of 6
                        gameEnd();
                    }
                    else if (threeEqual == true)
                    {
                        currentScore = 3; //Three matching gives score of 3
                        gameEnd();
                    }
                    else
                    {
                        currentScore = 0; //Two or no matches gives score of 0
                        gameEnd();
                    }

                    void gameEnd()
                    {
                        totalScore += currentScore;
                        Console.WriteLine("This round's score was: {0}", currentScore);
                        Console.WriteLine("Your total score is: {0}", totalScore);
                        while (totalScore < 20)
                        {
                            StartThreeOrMore();
                        }
                        Console.WriteLine("You win!");
                        Console.WriteLine("Final score: {0}", totalScore);
                        Console.WriteLine("        ");
                        Console.WriteLine("Do you want to play again?");
                        Console.WriteLine("Play Again! ------ Press 1");
                        Console.WriteLine("Main Menu -------- Press 2");
                        string playAgainInput = Console.ReadLine();
                        switch (playAgainInput)
                        {
                            case "1":
                                Console.WriteLine("---------------------------");
                                StartThreeOrMore(); //Restarts game
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
    }
}
