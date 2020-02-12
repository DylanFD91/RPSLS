using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissorsLizardSpock
{
    public class Human : Player
    {
        //Member Variables(Has A)
        //Constructor(Is A)
        public Human()
        {

        }
        //Methods(Can Do)
        public override void EnterName()
        {
            Console.WriteLine("Please enter your name.");
            string input = Console.ReadLine();
            this.name = input;
        }
        public override void PlayerGestureChoice()
        {
            gesture = Console.ReadLine();
            switch (gesture)
            {
                case "Rock":
                case "rock":
                case "1":
                    gesture = "Rock";
                    break;
                case "Paper":
                case "paper":
                case "2":
                    gesture = "Paper";
                    break;
                case "Scissors":
                case "scissors":
                case "3":
                    gesture = "Scissors";
                    break;
                case "Lizard":
                case "lizard":
                case "4":
                    gesture = "Lizard";
                    break;
                case "Spock":
                case "spock":
                case "5":
                    gesture = "Spock";
                    break;
                default:
                    Console.WriteLine("\nThat was not a valid response please try again\n");
                    Console.ReadLine();
                    Console.Clear();
                    PlayerGestureChoice();
                    break;
            }
        }
    }
}
