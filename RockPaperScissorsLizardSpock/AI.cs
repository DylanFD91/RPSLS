using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissorsLizardSpock
{
    public class AI : Player
    {
        //Member Variables(Has A)
        //Constructor(Is A)
        public AI()
        {

        }
        //Methods(Can Do)
        public override void EnterName()
        {
            Console.WriteLine("Sheldor");
            this.name = "Sheldor";
        }
        public override void PlayerGestureChoice()
        {
            int aIChoice = new Random().Next(1, 5);
        }
    }
}
