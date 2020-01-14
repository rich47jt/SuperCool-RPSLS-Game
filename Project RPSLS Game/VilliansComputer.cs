using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_RPSLS_Game
{
    class VilliansComputer:Player
    {
        //variables 
        Random random;
       
        public VilliansComputer(string name)
        {

            this.name = name;
            random = new Random();
            
        }

        //methods
       

        public override void PlayerChoice()
        { 
            int rng = random.Next(4);
            choice = gestures[rng];
            Console.WriteLine("computer has selected" + choice);
            
        }
        
       
    }
}
