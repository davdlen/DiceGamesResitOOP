using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace DiceGamesResitOOP
{
    internal class Die
    {
        private static Random rand = new Random();
        public int DiceRoll { get; private set; } //Dice roll property 

        public Die()
        {
            Roll(); //Allows other classes to call for roll
        }

        public int Roll()
        {
            DiceRoll = rand.Next(1, 7); //Picks a random number between 1 and 6 and sets that as the DiceRoll
            return DiceRoll;
        }
    }
}