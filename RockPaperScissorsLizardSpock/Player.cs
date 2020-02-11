using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissorsLizardSpock
{
    public abstract class Player
    {
        //Member Variables(Has A)
        public string name;
        public int score;

        //Constructor(Is A)
        public Player()
        {

        }

        //Methods(Can Do)
        public abstract void EnterName();

    }
}
