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
        public bool playerOneTurn = false;
        public bool twoHumans = false;

        //Constructor(Is A)
        public PlayGame()
        {

        }

        //Methods(Can Do)

        //checks if one or two players
        public void OneorTwoPlayers()
        {
            Console.WriteLine("One or Two Players?(Please Type 1 or 2)");
            string input = Console.ReadLine();
            switch (input)
            {
                case "1":
                    new Human();
                    new AI();
                    break;
                case "2":
                    new Human();
                    new Human();
                    twoHumans = true;
                    break;
                default:
                    Console.WriteLine("That was not a valid response, please try again.");
                    OneorTwoPlayers();
                    break;
            }
        }


        //allows user input
        public void HumanChoose()
        {
            Console.WriteLine("Please choose from the list: ");
            Console.WriteLine("Rock");
            Console.WriteLine("Paper");
            Console.WriteLine("Scissors");
            Console.WriteLine("Lizard");
            Console.WriteLine("Spock");
            string input = Console.ReadLine();
            switch (input)
            {
                case "Rock":
                case "rock":
                    break;
                case "Paper":
                case "paper":
                    break;
                case "Scissors":
                case "scissors":
                    break;
                case "Lizard":
                case "lizard":
                    break;
                case "Spock":
                case "spock":
                    break;
                default:
                    Console.WriteLine("That was not a valid response please try again");
                    HumanChoose();
                    break;
            }
        }
        public void AIChoose()
        {

        }


        //actually operates the turn
        public void PlayerTurn()
        {


            //if (playerOneTurn == true)
            //{

            //    playerOneTurn = false;
            //}
            //else
            //{

            //    playerOneTurn = true;
            //}
        }


        //play again and run program
        public void PlayAgain()
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
            OneorTwoPlayers();




            PlayAgain();
        }

    }
}
