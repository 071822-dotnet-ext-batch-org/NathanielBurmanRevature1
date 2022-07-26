using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace rpsconsole2
{
    public class Round
    {
        public int iPlayer1Hand = 0; // players choice will be 1,2,3
        public int iPlayer1HandParsed = 0;
        public int iPlayer2Hand = 0; // players choice
        public int iPlayAgain = 1; // a flag to track if we play again
        public int iWins = 0;
        public int iLost = 0;
        public int iTies = 0;
    }
}