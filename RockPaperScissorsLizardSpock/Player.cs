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
        public List<string> gesturesList = new List<string>() { ("Rock"), ("Paper"), ("Scissors"), ("Lizard"), ("Spock") };
        public string name;
        public int score;
        public string gesture;

        //Constructor(Is A)
        public Player()
        {
            EnterName();
            score = 0;
            gesture = "";
        }

        //Methods(Can Do)
        public abstract void EnterName();
        public abstract void PlayerGestureChoice();

    }
}
