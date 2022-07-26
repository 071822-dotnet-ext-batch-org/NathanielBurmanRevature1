using System;

namespace rpsconsole2
{
    class Program
    {
        static void Main(string[] args)
        {
            // // create an instance of a Player
            // Player p1 = new Player();
            // p1.sFName = "Nathaniel";
            // p1.sLName = "Burman";
            // p1.myDob  = new DateTime(1983, 7, 24);

            // Console.WriteLine($"The Players name is {p1.sFName} {p1.sLName} and his age is {p1.myDob.ToShortDateString()}");
            // p1.SetAge(99);
            // Console.WriteLine($"The players age is {p1.GetAge()}");

            // p1.iWins = 1;
            // int wins = p1.iWins;
            // Console.WriteLine($"The players age is {p1.iWins}");

            // init the player player 1
            Player p1 = new Player();
            Player p2 = new Player();
            // init the game object
            Game game = new Game();
            // init the Round
            Round round = new Round();





















            string sPlayer1Name, player2Name, sMsgStartGame, sMsgWin, sMsgLost;
            string sMsgHowToPlay, sMsgEndGame, sMsgTie, sAction, sMsgBestOfThree;
            string sMsgInputName, sMsgThis, sHandName, sHand1, sHand2, sMsg2of3Win, sMsg2of3Lost;
            int iLost, iWins, iTies, player1Hand, player1HandParsed, player2Hand, iPlayAgain;
            int rock, paper, scissors;
            bool bPlayer1HandChecked,bBestOutOfThree;
            Random rnd = new Random();

            //flag
            bBestOutOfThree = true; // sets the game to best two out of three

            sMsgStartGame = game.sMsgStartGame;
            sMsgWin       = game.sMsgWin;
            sMsgTie       = game.sMsgTie;
            sMsgLost      = game.sMsgLost;
            sMsg2of3Win   = game.sMsg2of3Lost;
            sMsg2of3Lost  = game.sMsg2of3Lost;
            sMsgThis      = game.sMsgThis;
            sMsgEndGame   = game.sMsgEndGame;
            sMsgHowToPlay = game.sMsgHowToPlay;
            sMsgInputName = game.sMsgInputName;
            sAction       = game.sAction;// i assign this action for the end message
            sMsgBestOfThree=game.sMsgBestOfThree;

            sPlayer1Name   = "Player One"; // the user
            player2Name    = "Computer"; // the computer

            // iWins = 0; // tally the wins
            // iLost = 0; // looses
            // iTies = 0; // ties
            iWins = game.iWins;
            iLost = game.iLost;
            iTies = game.iTies;

            sHand1   = "";// a temp var used to display the word instead of number for the hand
            sHand2   = "";// a temp var used to display the word instead of number for the hand
            // rock    = 1;
            // paper   = 2;
            // scissors= 3;
            rock    = game.rock;
            paper   = game.paper;
            scissors= game.scissors;

            // player1Hand = 0; // players choice will be 1,2,3
            // player1HandParsed = 0;
            // player2Hand = 0; // players choice
            player1Hand = round.iPlayer1Hand; // players choice will be 1,2,3
            player1HandParsed = round.iPlayer1HandParsed;
            player2Hand = round.iPlayer2Hand; // players choice

            //sHandName = "";

            // iPlayAgain = 1; // a flag to track if we play again
            iPlayAgain = round.iPlayAgain; // a flag to track if we play again

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
            p1.sFName = sPlayer1Name;


        while(round.iPlayAgain==1)
        {
            
            // instructions to play... explain game flow. which keys are used, etc.
            Console.WriteLine(sMsgHowToPlay);

            // press enter; take input to start the game
            //Console.Read();

            // take player input for player move
            Console.WriteLine($"{p1.sFName}, what is your choice.");
            //player1Hand = int.Parse(Console.ReadLine());
            bPlayer1HandChecked = int.TryParse(Console.ReadLine(), out player1HandParsed);
            if(bPlayer1HandChecked==true)
            {
                player1Hand = player1HandParsed;
                round.iPlayer1Hand = player1Hand;
            }
            // nb! check on the exceptions here
            //




            
            // computer returns their result
            round.iPlayer2Hand = rnd.Next(1, 3);
            //round.iPlayer2Hand = player2Hand;
            //player2Hand = 1;

            // results compared
            // win , tie, lose
            // if a tie then return to user input
            if(round.iPlayer1Hand == round.iPlayer2Hand){
                round.iTies++; // inc ties var
                sMsgThis = game.sMsgTie;
                game.sAction = "ties";
                
                // LOOP BACK ARROUND IF THERE WAS A TIE
                // tell them they tied
                Console.WriteLine($"\n{game.sMsgTie}");
                continue;
                //break;
                //
                //

            }else{
                if(round.iPlayer1Hand == game.rock && round.iPlayer2Hand == game.scissors){
                    round.iWins++;
                    sMsgThis = game.sMsgWin + " - rock beats scissors";
                    sHand1="rock";
                    sHand2="scissors";
                    game.sAction = "beats";
                }
                else if(round.iPlayer1Hand == game.paper && round.iPlayer2Hand == game.rock){
                    round.iWins++;
                    sMsgThis = game.sMsgWin + " - paper beats rock";
                    sHand1="paper";
                    sHand2="rock";
                    game.sAction = "beats";
                }
                else if(round.iPlayer1Hand == game.scissors && round.iPlayer2Hand == game.paper){
                    round.iWins++;
                    sMsgThis = game.sMsgWin + " - scissors beats paper";
                    sHand1="scissors";
                    sHand2="paper";
                    game.sAction = "beats";
                }
                else{
                    round.iLost++;
                    sMsgThis = game.sMsgLost;
                    game.sAction = "looses against";
                }
            }
            
            //
            // determine the player1's hand name
            if(round.iPlayer1Hand==game.rock){
                sHand1="rock";
            }
            else if(round.iPlayer1Hand==game.paper){
                sHand1="paper";
            }
            else{
                sHand1="scissors";
            }
            
            // a message for when the user diddnt choose a selection
            if(round.iPlayer1Hand!=rock && round.iPlayer1Hand!=paper && round.iPlayer1Hand!=scissors )
            {
                sHand1="nothing choosen";
            }

            // determine the player2's hand name
            if(round.iPlayer2Hand==game.rock){
                sHand2="rock";
            }
            else if(round.iPlayer2Hand==game.paper){
                sHand2="paper";
            }
            else{
                sHand2="scissors";
            }
            //
            //

            // check if best two out of three
            // displays message to user on win or lose
            if((round.iWins>=2) || (round.iLost >=2) && (game.bBestOutOfThree)){
                Console.WriteLine($"\n{game.sMsgBestOfThree}\n");
                if (round.iWins>=2){
                    Console.WriteLine($"\n{game.sMsg2of3Win}\n");
                    game.iWins++;
                }
                else{
                    Console.WriteLine($"\n{game.sMsg2of3Lost}\n");
                    game.iLost++;
                }
                
                 // results displayed
                Console.WriteLine($"\n{sPlayer1Name}, {sMsgThis}\nPlayer One: {round.iPlayer1Hand} : {sHand1}\n{game.sAction} \nPlayer Two: {round.iPlayer2Hand} : {sHand2}\nCurrent Round Tally: Wins:{round.iWins} Ties:{round.iTies} Lost:{round.iLost}\nFull Games Won:{game.iWins}\nFull Games Lost: {game.iLost}");

                // reset values to cycle on best of 2 out of three
                // reset rounds
                round.iWins=0;
                round.iLost=0;
                round.iTies=0;

                // does the user want to play again?
                Console.WriteLine(game.sMsgEndGame);
                round.iPlayAgain = int.Parse(Console.ReadLine());

                continue;
            }
            //continue;
            
        }

            // ask if want to play again & display total results
            // quit if n
            // loop to begin again if they y
        }
    }
}
