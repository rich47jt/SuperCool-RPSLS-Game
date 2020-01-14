using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_RPSLS_Game
{
    public abstract class Player
    {
        //varables
      public  List <string> gestures;
      public string name;  //keep name of get rid of it ?
        
      public string choice;
      public int score;



        //constructor 
        public Player()
        {
            gestures = new List<string>() { "rock", "paper","scissors","lizard","spok" };
            score = 0;
        }

        //methods
      

       


        public abstract void PlayerChoice();




    }
}
