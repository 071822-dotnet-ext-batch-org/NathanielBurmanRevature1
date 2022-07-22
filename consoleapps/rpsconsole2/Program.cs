using System;

namespace rpsconsole2
{
    class Program
    {
        static void Main(string[] args)
        {
            string player1Name, player2Name, sMsgStartGame, sMsgWin, sMsgLost;
            string sMsgHowToPlay, sMsgEndGame, sMsgTie;
            string sMsgInputName, sMsgThis, sHandName;
            int iLost, iWins, iTies, player1Hand, player2Hand, iPlayAgain;
            int rock, paper, scissors;

            Random rnd = new Random();

            sMsgStartGame = "\t\tWelcome to the RPS game!\nThis is Rock Paper Scissors!";
            sMsgWin       = "You Win!";
            sMsgTie       = "You Tied!";
            sMsgLost      = "You Lose!";
            sMsgThis      = "temp var";
            sMsgEndGame   = "Press 1 to play again or 0 to quit:";
            sMsgHowToPlay = "\nReady? Press the number for 1 Rock, 2 Paper, or 3 Scissors.\n";
            sMsgInputName = "What is your name?";

            player1Name    = "Player One"; // the user
            player2Name    = "Computer"; // the computer

            iWins = 0; // tally the wins
            iLost = 0; // looses
            iTies = 0; // ties

            rock    = 1;
            paper   = 2;
            scissors= 3;

            player1Hand = 0; // players choice will be 1,2,3
            player2Hand = 0; // players choice

            sHandName = "";

            iPlayAgain = 1; // a flag to track if we play again

            Console.WriteLine("rps is running...");
            Console.WriteLine("...");
            Console.WriteLine("...");
            Console.WriteLine("...");

            // display a welcome message to the screen
            Console.WriteLine(sMsgStartGame);

            // ReadLine returns a string
            // set the player name to their input
            Console.WriteLine(sMsgInputName);
            player1Name = Console.ReadLine();

        while(iPlayAgain==1)
        {
            // instructions to play... explain game flow. which keys are used, etc.
            Console.WriteLine(sMsgHowToPlay);

            // press enter; take input to start the game
            //Console.Read();

            // take player input for player move
            Console.WriteLine($"{player1Name}, what is your choice.");
            player1Hand = int.Parse(Console.ReadLine());
            
            // computer returns their result
            player2Hand = rnd.Next(1, 3);
            //player2Hand = 1;

            // results compared
            // win , tie, lose
            // if a tie then return to user input
            if(player1Hand == player2Hand){
                iTies++; // inc ties var
                sMsgThis = sMsgTie;
            }else{
                if(player1Hand == rock && player2Hand == scissors){
                    iWins++;
                    sMsgThis = sMsgWin + " - rock beats scissors";
                }
                else if(player1Hand == paper && player2Hand == rock){
                    iWins++;
                    sMsgThis = sMsgWin + " - paper beats rock";
                }
                else if(player1Hand == scissors && player2Hand == paper){
                    iWins++;
                    sMsgThis = sMsgWin + " - scissors beats paper";
                }
                else{
                    iLost++;
                    sMsgThis = sMsgLost;
                }
            }
            
            // results displayed 
            Console.WriteLine($"{player1Name}, {sMsgThis}\nPlayer One: {player1Hand}\nPlayer Two: {player2Hand}\nCurrent Tally: Wins:{iWins} Ties:{iTies} Lost:{iLost}");

            Console.WriteLine(sMsgEndGame);
            iPlayAgain = int.Parse(Console.ReadLine());
        }

            // ask if want to play again & display total results
            // quit if n
            // loop to begin again if they y
        }
    }
}
