using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_RPSLS_Game
{
    class Game_Room
    {
        Player playerOne;
        Player playerTwo;

        //constuctor
        public Game_Room()
        {
            this.playerOne = new VilliansComputer("red");
            this.playerTwo = new HeroePlayer("blue");


        }

        public void LetsPlay()
        {
            
        }


    }
}
