using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiceGamesResitOOP
{
    internal class Statistics
    {
        public static void StartStatistics()
        {
            int sevensOutPlays = 0; //Total plays for sevens out
            int sevensOutHighScore = 0; //High score for sevens out
            int threeOrMorePlays = 0; //Total plays for three or more
                
            Console.WriteLine("           ");
            Console.ForegroundColor = ConsoleColor.Black; //Makes the text black to look nice
            Console.BackgroundColor = ConsoleColor.White; //Makes the background white to also look nice
            Console.WriteLine(" S T A T S ");
            Console.ResetColor(); //Resets text colour
            Console.WriteLine("           ");
            Console.WriteLine("SEVENS OUT ");
            Console.WriteLine("Plays: {0}", sevensOutPlays);
            Console.WriteLine("High Score: {0}", sevensOutHighScore);
            Console.WriteLine("           ");
            Console.WriteLine("THREE OR MORE");
            Console.WriteLine("Plays: {0}", threeOrMorePlays);
            Console.WriteLine("           ");
            Program.Menu();
        }
    }
}
