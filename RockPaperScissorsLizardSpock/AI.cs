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
            Console.WriteLine("\n-----------------------");
            Console.WriteLine("Please enter your name: ");
            Console.WriteLine("-----------------------\n");

            this.name = "Sheldor";
            System.Threading.Thread.Sleep(500);
            foreach (char sheldon in this.name)
            {
                System.Threading.Thread.Sleep(200);
                Console.Write(sheldon);
            }
            Console.WriteLine("\n");
        }
        public override void PlayerGestureChoice()
        {
            Random rng = new Random();
            int index = rng.Next(gesturesList.Count);
            gesture = gesturesList[index];
            Console.WriteLine(this.name + " went with " + gesturesList[index]);
        }
    }
}
