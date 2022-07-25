using System;

namespace rpsconsole2
{
    class Program
    {
        static void Main(string[] args)
        {
            string sPlayer1Name, player2Name, sMsgStartGame, sMsgWin, sMsgLost;
            string sMsgHowToPlay, sMsgEndGame, sMsgTie, sAction, sMsgBestOfThree;
            string sMsgInputName, sMsgThis, sHandName, sHand1, sHand2, sMsg2of3Win, sMsg2of3Lost;
            int iLost, iWins, iTies, player1Hand, player1HandParsed, player2Hand, iPlayAgain;
            int rock, paper, scissors;
            bool bPlayer1HandChecked,bBestOutOfThree;
            Random rnd = new Random();

            //flag
            bBestOutOfThree = true; // sets the game to best two out of three

            sMsgStartGame = "\t\tWelcome to the RPS game!\nThis is Rock Paper Scissors!";
            sMsgWin       = "You Win this Round!";
            sMsgTie       = "You Tied this Round!";
            sMsgLost      = "You Lose this Round!";
            sMsg2of3Win   = "";
            sMsg2of3Lost  = "";
            sMsgThis      = "temp var";
            sMsgEndGame   = "Press 1 to play again or 0 to quit:";
            sMsgHowToPlay = "\nReady? Press the number:\n1 Rock \n2 Paper \n3 Scissors.\n";
            sMsgInputName = "What is your name?";
            sAction       = "beats, looses too, ties";// i assign this action for the end message
            sMsgBestOfThree="The best out of three wins!";

            sPlayer1Name    = "Player One"; // the user
            player2Name    = "Computer"; // the computer

            iWins = 0; // tally the wins
            iLost = 0; // looses
            iTies = 0; // ties

            sHand1   = "";// a temp var used to display the word instead of number for the hand
            sHand2   = "";// a temp var used to display the word instead of number for the hand
            rock    = 1;
            paper   = 2;
            scissors= 3;

            player1Hand = 0; // players choice will be 1,2,3
            player1HandParsed = 0;
            player2Hand = 0; // players choice

            //sHandName = "";

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
            sPlayer1Name = Console.ReadLine();


        while(iPlayAgain==1)
        {
            
            // instructions to play... explain game flow. which keys are used, etc.
            Console.WriteLine(sMsgHowToPlay);

            // press enter; take input to start the game
            //Console.Read();

            // take player input for player move
            Console.WriteLine($"{sPlayer1Name}, what is your choice.");
            //player1Hand = int.Parse(Console.ReadLine());
            bPlayer1HandChecked = int.TryParse(Console.ReadLine(), out player1HandParsed);
            if(bPlayer1HandChecked==true){player1Hand = player1HandParsed;}
            // nb! check on the exceptions here
            //




            
            // computer returns their result
            player2Hand = rnd.Next(1, 3);
            //player2Hand = 1;

            // results compared
            // win , tie, lose
            // if a tie then return to user input
            if(player1Hand == player2Hand){
                iTies++; // inc ties var
                sMsgThis = sMsgTie;
                sAction = "ties";
                
                // LOOP BACK ARROUND IF THERE WAS A TIE
                // tell them they tied
                Console.WriteLine(sMsgTie);
                continue;
                //break;
                //
                //

            }else{
                if(player1Hand == rock && player2Hand == scissors){
                    iWins++;
                    sMsgThis = sMsgWin + " - rock beats scissors";
                    sHand1="rock";
                    sHand2="scissors";
                    sAction = "beats";
                }
                else if(player1Hand == paper && player2Hand == rock){
                    iWins++;
                    sMsgThis = sMsgWin + " - paper beats rock";
                    sHand1="paper";
                    sHand2="rock";
                    sAction = "beats";
                }
                else if(player1Hand == scissors && player2Hand == paper){
                    iWins++;
                    sMsgThis = sMsgWin + " - scissors beats paper";
                    sHand1="scissors";
                    sHand2="paper";
                    sAction = "beats";
                }
                else{
                    iLost++;
                    sMsgThis = sMsgLost;
                    sAction = "looses against";
                }
            }
            
            //
            // determine the player1's hand name
            if(player1Hand==rock){
                sHand1="rock";
            }
            else if(player1Hand==paper){
                sHand1="paper";
            }
            else{
                sHand1="scissors";
            }
            
            // a message for when the user diddnt choose a selection
            if(player1Hand!=rock && player1Hand!=paper && player1Hand!=scissors )
            {
                sHand1="nothing choosen";
            }

            // determine the player2's hand name
            if(player2Hand==rock){
                sHand2="rock";
            }
            else if(player2Hand==paper){
                sHand2="paper";
            }
            else{
                sHand2="scissors";
            }
            //
            //

            // results displayed
            Console.WriteLine($"\n{sPlayer1Name}, {sMsgThis}\nPlayer One: {player1Hand} : {sHand1}\n{sAction} \nPlayer Two: {player2Hand} : {sHand2}\nCurrent Tally: Wins:{iWins} Ties:{iTies} Lost:{iLost}");

            // check if best two out of three
            // displays message to user on win or lose
            if((iWins>=2) || (iLost >=2) && (bBestOutOfThree)){
                // instructions to play... explain game flow. which keys are used, etc.
                Console.WriteLine($"\n{sMsgBestOfThree}\n");
                if (iWins>=2){
                    Console.WriteLine($"\n{sMsg2of3Win}\n");
                }
                else{
                    Console.WriteLine($"\n{sMsg2of3Lost}}\n");
                }
                // reset values to cycle on best of 2 out of three
                iWins=0;
                iLost=0;
                continue;
            }

            // does the user want to play again?
            Console.WriteLine(sMsgEndGame);
            iPlayAgain = int.Parse(Console.ReadLine());
        }

            // ask if want to play again & display total results
            // quit if n
            // loop to begin again if they y
        }
    }
}
