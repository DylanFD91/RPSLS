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
        public List<string> gesturesList = new List<string>() { ("Rock"), ("Paper"), ("Scissors"), ("Lizard"), ("Spock") };
        Player player1;
        Player player2;

        //Constructor(Is A)
        public PlayGame()
        {

        }

        //Methods(Can Do)
        private void DisplayRules()
        {
            Console.WriteLine("Here is the list of what beats what in this game: ");

            Console.WriteLine("\nRock crushes Scissors");
            Console.WriteLine("Scissors cuts Paper");
            Console.WriteLine("Paper covers Rock");
            Console.WriteLine("Rock crushes Lizard");
            Console.WriteLine("Lizard poisons Spock");
            Console.WriteLine("Spock smashes Scissors");
            Console.WriteLine("Scissors decapitates Lizard");
            Console.WriteLine("Lizard eats Paper");
            Console.WriteLine("Paper disproves Spock");
            Console.WriteLine("Spock vaporizes Rock\n");

            Console.WriteLine("Press Enter to continue...");

            Console.ReadLine();
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
                    break;
                case "1":
                    player1 = new Human();
                    player2 = new AI();
                    break;
                case "2":
                    player1 = new Human();
                    player2 = new Human();
                    break;
                default:
                    Console.Clear();
                    Console.WriteLine("That was not a valid response, please try again.");
                    OneorTwoPlayers();
                    break;
            }
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

        private void DisplayGestureOptions()
        {
            Console.WriteLine("Please choose from the list: \n");
            foreach(string gesture in gesturesList)
            {
                Console.WriteLine(gesture);
            }
            Console.WriteLine("\n");
        }

        private void PickGestures()
        {
            DisplayGestureOptions();
            player1.PlayerGestureChoice();

            Console.Clear();

            DisplayGestureOptions();
            player2.PlayerGestureChoice();
            CompareGestures();
        }

        public void CompareGestures()
        {
            if (player1.gesture == player2.gesture)
            {
                Console.WriteLine("It's a tie lets go again.");
                player1.score++;
            }
            else if (player1.gesture == "Rock" && player2.gesture == "Scissors" || player2.gesture == "Lizard")
            {
                Console.WriteLine(player1.name + "wins this round");
                player1.score++;
            }
            else if (player1.gesture == "Scissors" && player2.gesture == "Paper" || player2.gesture == "Lizard")
            {
                Console.WriteLine(player1.name + "wins this round");
                player1.score++;
            }
            else if (player1.gesture == "Paper" && player2.gesture == "Rock" || player2.gesture == "Spock")
            {
                Console.WriteLine(player1.name + "wins this round");
                player1.score++;
            }
            else if (player1.gesture == "Lizard" && player2.gesture == "Spock" || player2.gesture == "Paper")
            {
                Console.WriteLine(player1.name + "wins this round");
                player1.score++;
            }
            else if (player1.gesture == "Spock" && player2.gesture == "Rock" || player2.gesture == "Scissors")
            {
                Console.WriteLine(player1.name + " wins this round!");
                player1.score++;
            }
            else
            {
                Console.WriteLine(player2.name + " wins this round!");
                player2.score++;
            }
            Console.ReadLine();
        }

        private void PlayAgain()
        {
            Console.WriteLine("\nWould you like to play again?(Type Y/N): ");
            string playAgain = Console.ReadLine();
            switch (playAgain)
            {
                case "Y":
                case "y":
                    PlayGame newGame = new PlayGame();
                    newGame.SimulateProgram();
                    break;
                case "N":
                case "n":
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

            PickGestures();

            DisplayWinnerOfGame();
            PlayAgain();
        }

    }
}
