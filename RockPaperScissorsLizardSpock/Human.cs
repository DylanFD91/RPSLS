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
            EnterName();
            this.score = 0;
        }
        //Methods(Can Do)
        public override void EnterName()
        {
            Console.WriteLine("Please enter your name.");
            string input = Console.ReadLine();
            this.name = input;
        }
    }
}
