using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace rpsconsole2
{
    public class Game
    {
        public int rock    = 1;
        public int paper   = 2;
        public int scissors= 3;
        public int iWins = 0;
        public int iLost = 0;
        public int iTies = 0;

        //flag
        public bool     bBestOutOfThree = true; // sets the game to best two out of three
        public string     sMsgStartGame = "\t\tWelcome to the RPS game!\nThis is Rock Paper Scissors!";
        public string     sMsgWin       = "You Win this Round!";
        public string     sMsgTie       = "You Tied this Round!";
        public string     sMsgLost      = "You Lose this Round!";
        public string     sMsg2of3Win   = "You WIN 2 out of 3";
        public string     sMsg2of3Lost  = "You LOSE 2 out of 3";
        public string     sMsgThis      = "temp var";
        public string     sMsgEndGame   = "Press 1 to play again or 0 to quit:";
        public string     sMsgHowToPlay = "\nReady? Press the number:\n1 Rock \n2 Paper \n3 Scissors.\n";
        public string     sMsgInputName = "What is your name?";
        public string     sAction       = "beats, looses too, ties";// i assign this action for the end message
        public string     sMsgBestOfThree="The best out of three wins!";
    }
}