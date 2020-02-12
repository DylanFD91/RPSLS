using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissorsLizardSpock
{
    class PlayGame
    {
        //Member Variables(Has A)
        
        Player player1;
        Player player2;

        //Constructor(Is A)
        public PlayGame()
        {

        }

        //Methods(Can Do)
        private void DisplayRules()
        {
            Console.WriteLine("--------------------------------------------------------");
            Console.WriteLine("Welcome to my Rock, Paper, Scissors, Lizard, Spock Game!");
            Console.WriteLine("--------------------------------------------------------");
            Console.WriteLine("To sum the game up its your normal R,P,S game with a twist!\n");

            Console.WriteLine("Below here is the list of what beats what in this game: \n");

            Console.WriteLine("---------------------------------");
            Console.WriteLine("|     Rock crushes Scissors     |");
            Console.WriteLine("|      Scissors cuts Paper      |");
            Console.WriteLine("|       Paper covers Rock       |");
            Console.WriteLine("|      Rock crushes Lizard      |");
            Console.WriteLine("|      Lizard poisons Spock     |");
            Console.WriteLine("|     Spock smashes Scissors    |");
            Console.WriteLine("|  Scissors decapitates Lizard  |");
            Console.WriteLine("|       Lizard eats Paper       |");
            Console.WriteLine("|     Paper disproves Spock     |");
            Console.WriteLine("|     Spock vaporizes Rock      |");
            Console.WriteLine("---------------------------------");

            Console.WriteLine("\nPress Enter to continue...");
            Console.ReadLine();
            Console.Clear();
        }

        private void OneorTwoPlayers()
        {
            Console.WriteLine("One or Two Players?(Please Type 1 or 2)");
            string input = Console.ReadLine();
            switch (input)
            {
                case "0":
                    player1 = new AI();
                    player2 = new AI();
                    Console.WriteLine("\nWelcome " + player1.name + " and " + player2.name + "! Press Enter to Continue...");
                    Console.ReadLine();
                    break;
                case "1":
                    player1 = new Human();
                    player2 = new AI();
                    Console.WriteLine("\nWelcome " + player1.name + " and " + player2.name + "! Press Enter to Continue...");
                    Console.ReadLine();
                    break;
                case "2":
                    player1 = new Human();
                    player2 = new Human();
                    Console.WriteLine("\nWelcome " + player1.name + " and " + player2.name + "! Press Enter to Continue...");
                    Console.ReadLine();
                    break;
                default:
                    Console.Clear();
                    Console.WriteLine("That was not a valid response, please press enter try again.");
                    Console.ReadLine();
                    OneorTwoPlayers();
                    break;
            }
            Console.Clear();
        }

        private void DisplayWinnerOfGame()
        {
            if (player1.score == 2)
            {
                Console.WriteLine(player1.name + " you win the game!");
                Console.ReadLine();
            }
            else if(player2.score == 2)
            {
                Console.WriteLine(player2.name + " you win the game!");
                Console.ReadLine();
            }
        }

        public void DisplayGestureOptions()
        {
            Console.WriteLine("Please choose from the list: \n");
            foreach(string gesture in player1.gesturesList)
            {
                Console.WriteLine(gesture);
            }
            Console.WriteLine("\n");
        }

        private void PickGestures()
        {
            Console.WriteLine(player1.name + " please choose from the list: \n");
            player1.PlayerGestureChoice();

            Console.Clear();

            Console.WriteLine(player2.name + " please choose from the list: \n");
            player2.PlayerGestureChoice();

            CompareGestures();
        }

        private void CompareGestures()
        {
            if (player1.gesture == player2.gesture)
            {
                Console.WriteLine("\nIt's a tie lets go again.");
            }
            else if ((player1.gesture == "Rock" && player2.gesture == "Scissors") || player1.gesture == "Rock" && player2.gesture == "Lizard")
            {
                Console.WriteLine("\n" + player1.name + " wins this round!");
                player1.score++;
            }
            else if (player1.gesture == "Scissors" && player2.gesture == "Paper" || player1.gesture == "Scissors" && player2.gesture == "Lizard")
            {
                Console.WriteLine("\n" + player1.name + " wins this round!");
                player1.score++;
            }
            else if (player1.gesture == "Paper" && player2.gesture == "Rock" || player1.gesture == "Paper" && player2.gesture == "Spock")
            {
                Console.WriteLine("\n" + player1.name + " wins this round!");
                player1.score++;
            }
            else if (player1.gesture == "Lizard" && player2.gesture == "Spock" || player1.gesture == "Lizard" && player2.gesture == "Paper")
            {
                Console.WriteLine("\n" + player1.name + " wins this round!");
                player1.score++;
            }
            else if (player1.gesture == "Spock" && player2.gesture == "Rock" || player1.gesture == "Spock" && player2.gesture == "Scissors")
            {
                Console.WriteLine("\n" + player1.name + " wins this round!");
                player1.score++;
            }
            else
            {
                Console.WriteLine("\n" + player2.name + " wins this round!");
                player2.score++;
            }
            Console.ReadLine();
            Console.Clear();
        }

        private void PlayAgain()
        {
            Console.Clear();
            Console.WriteLine("\nWould you like to play again?(Type Y/N): ");
            string playAgain = Console.ReadLine();
            switch (playAgain)
            {
                case "Y":
                case "y":
                    Console.Clear();
                    PlayGame newGame = new PlayGame();
                    newGame.SimulateProgram();
                    break;
                case "N":
                case "n":
                    Console.Clear();
                    Console.WriteLine("\nThankyou for playing!");
                    Console.ReadLine();
                    break;
                default:
                    Console.WriteLine("That was not a valid response, please try again.");
                    Console.ReadLine();
                    PlayAgain();
                    break;
            }

        }

        public void SimulateProgram()
        {
            DisplayRules();
            OneorTwoPlayers();
            do
            {
                PickGestures();
            } while (player1.score < 2 && player2.score < 2);
            DisplayWinnerOfGame();
            PlayAgain();
        }

    }
}
