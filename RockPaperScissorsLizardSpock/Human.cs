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
                    gesture = "Rock";
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
                    Console.WriteLine("\nThat was not a valid response please try again\n");
                    Console.ReadLine();
                    Console.Clear();
                    PlayerGestureChoice();
                    break;
            }
        }
    }
}
