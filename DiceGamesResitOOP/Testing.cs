using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Diagnostics;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace DiceGamesResitOOP
{
    internal class Testing
    {
        public static void StartTesting()
        {
            Die testSevensDie1 = new Die();
            Die testSevensDie2 = new Die();
            int testSevensRoll1 = testSevensDie1.Roll();
            int testSevensRoll2 = testSevensDie2.Roll();
            
            Die testThreeDie1 = new Die();
            Die testThreeDie2 = new Die();
            Die testThreeDie3 = new Die();
            Die testThreeDie4 = new Die();
            Die testThreeDie5 = new Die();
            int testThreeRoll1 = testThreeDie1.Roll();
            int testThreeRoll2 = testThreeDie2.Roll();
            int testThreeRoll3 = testThreeDie3.Roll();
            int testThreeRoll4 = testThreeDie4.Roll();
            int testThreeRoll5 = testThreeDie5.Roll();
            int testThreeScore = 0;

            string testInput = ""; //Allows for user input
            Console.WriteLine("              ");
            Console.ForegroundColor = ConsoleColor.DarkYellow; //Makes the text orange to look cool
            Console.BackgroundColor = ConsoleColor.DarkMagenta; //Makes the background of the text purple to look cool
            Console.WriteLine(" T E S T I N G   M O D E ");
            Console.ResetColor();
            Console.WriteLine("              ");
            Console.WriteLine("Test Sevens Out ----- Press 1");
            Console.WriteLine("Test Three Or More -- Press 2");
            Console.WriteLine("Main Menu ----------- Press 3");
            Console.WriteLine("                             ");
            testInput = Console.ReadLine();
            switch (testInput)
            {
                case "1":
                    testSevensOut();
                    break;

                case "2":
                    testThreeOrMore();
                    break;

                case "3":
                    Program.Menu();
                    break;

                default:
                    Console.WriteLine("Invalid input.");
                    break;
            }

            void testSevensOut()
            {
                Debug.Assert(totalChecker(), "Sum is incorrect.");
                Debug.Assert(sevenChecker(), "Seven rolled but game continued.");
            }

            bool totalChecker()
            {
                int rollsSum = testSevensRoll1 + testSevensRoll2;
                return rollsSum == (testSevensDie1.DiceRoll + testSevensDie2.DiceRoll);
            }

            bool sevenChecker()
            {
                int isSeven = testSevensRoll1 + testSevensRoll2;
                return isSeven == (isSeven = 7);
            }

            void testThreeOrMore()
            {
                Debug.Assert(scoreChecker(), "Score allocation is incorrect.");
                Debug.Assert(twentyChecker(), "Total is over 20");
            }
            
            bool scoreChecker()
            {
                if (testThreeRoll1 == testThreeRoll2 && testThreeRoll2 == testThreeRoll3 && testThreeRoll3 == testThreeRoll4 && testThreeRoll4 == testThreeRoll5) //Testing for all 5 equal
                {
                    testThreeScore = 12;
                }

                else if ((testThreeRoll1 == testThreeRoll2 && testThreeRoll2 == testThreeRoll3 && testThreeRoll3 == testThreeRoll4 && testThreeRoll4 != testThreeRoll5) || //Four of five, roll5 not the same
                        (testThreeRoll1 == testThreeRoll2 && testThreeRoll2 == testThreeRoll3 && testThreeRoll3 == testThreeRoll5 && testThreeRoll5 != testThreeRoll4) ||  //Four of five, roll4 not the same
                        (testThreeRoll1 == testThreeRoll2 && testThreeRoll2 == testThreeRoll4 && testThreeRoll4 == testThreeRoll5 && testThreeRoll5 != testThreeRoll3) ||  //Four of five, roll3 not the same
                        (testThreeRoll1 == testThreeRoll3 && testThreeRoll3 == testThreeRoll4 && testThreeRoll4 == testThreeRoll5 && testThreeRoll5 != testThreeRoll2) ||  //Four of five, roll2 not the same
                        (testThreeRoll2 == testThreeRoll3 && testThreeRoll3 == testThreeRoll4 && testThreeRoll4 == testThreeRoll5 && testThreeRoll5 != testThreeRoll1))    //Four of five, roll1 not the same
                {
                    testThreeScore = 6;
                }

                else if ((testThreeRoll1 == testThreeRoll2 && testThreeRoll2 == testThreeRoll3 && testThreeRoll3 != testThreeRoll4 && testThreeRoll3 != testThreeRoll5) || //Three of five, 4&5 different
                        (testThreeRoll1 == testThreeRoll2 && testThreeRoll2 == testThreeRoll4 && testThreeRoll4 != testThreeRoll3 && testThreeRoll4 != testThreeRoll5) ||  //Three of five, 3&5 different
                        (testThreeRoll1 == testThreeRoll3 && testThreeRoll3 == testThreeRoll4 && testThreeRoll4 != testThreeRoll2 && testThreeRoll4 != testThreeRoll5) ||  //Three of five, 2&5 different
                        (testThreeRoll2 == testThreeRoll3 && testThreeRoll3 == testThreeRoll4 && testThreeRoll4 != testThreeRoll1 && testThreeRoll4 != testThreeRoll5) ||  //Three of five, 1&5 different
                        (testThreeRoll1 == testThreeRoll2 && testThreeRoll2 == testThreeRoll5 && testThreeRoll5 != testThreeRoll3 && testThreeRoll5 != testThreeRoll4) ||  //Three of five, 3&4 different
                        (testThreeRoll1 == testThreeRoll3 && testThreeRoll3 == testThreeRoll5 && testThreeRoll5 != testThreeRoll2 && testThreeRoll5 != testThreeRoll4) ||  //Three of five, 2&4 different
                        (testThreeRoll2 == testThreeRoll3 && testThreeRoll3 == testThreeRoll5 && testThreeRoll5 != testThreeRoll1 && testThreeRoll5 != testThreeRoll4) ||  //Three of five, 1&4 different
                        (testThreeRoll1 == testThreeRoll4 && testThreeRoll4 == testThreeRoll5 && testThreeRoll5 != testThreeRoll2 && testThreeRoll5 != testThreeRoll3) ||  //Three of five, 2&3 different
                        (testThreeRoll2 == testThreeRoll4 && testThreeRoll4 == testThreeRoll5 && testThreeRoll5 != testThreeRoll1 && testThreeRoll5 != testThreeRoll3) ||  //Three of five, 1&3 different
                        (testThreeRoll3 == testThreeRoll4 && testThreeRoll4 == testThreeRoll5 && testThreeRoll5 != testThreeRoll1 && testThreeRoll5 != testThreeRoll2))    //Three of five, 1&2 different
                {
                    testThreeScore = 3;
                }

                else
                {
                    testThreeScore = 0;
                }

                if (testThreeScore != 0 && testThreeScore != 3 && testThreeScore != 6 && testThreeScore != 12)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }

            bool twentyChecker()
                {
                    if (testThreeScore > 20)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }
    }
}
