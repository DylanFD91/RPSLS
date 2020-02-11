using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissorsLizardSpock
{
    class GesturesList
    {
        //Member Variables(Has A)
        public List<Gestures> gestures;
        //Constructor(Is A)
        public GesturesList()
        {
            gestures = new List<Gestures>() {new Gestures("Rock"), new Gestures("Paper"), new Gestures("Scissors"), new Gestures("Lizard"), new Gestures("Spock")};
        }
        //Methods(Can Do)
    }
}
