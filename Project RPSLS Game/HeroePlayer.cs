using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_RPSLS_Game
{
   class HeroePlayer: Player
    {
        //varibles
        
        //constructor
        public HeroePlayer(string name)
        {

            this.name = name;
        }

        //methods
        public override void CharacterCall()
        {
            Console.WriteLine("Lets have a fair game!", name);
        }
        public override void PlayerChoice()
        {
           
            Console.WriteLine("Please enter a gesture");
            string userInput = Console.ReadLine();

            switch(userInput)
            {
                case "rock":
                    Console.WriteLine("My Choice is " + gestures[0]);
                    choice = gestures[0];
                    break;
                case "paper":
                    Console.WriteLine("My choice is Paper" + gestures[1]);
                    choice = gestures[1];
                    break;
                case "sissors":
                    Console.WriteLine("My choice is scissors" + gestures[2]);
                    choice = gestures[2];
                    break;
                case "lizard":
                    Console.WriteLine("My choice is lizard" + gestures[3]);
                    choice = gestures[3];
                    break;
                case "spok":
                    Console.WriteLine("My choice is spok" + gestures[4]);
                    choice = gestures[4];
                    break;

                default:
                    Console.WriteLine("Play by the rules and make an appropriate gesture");
                    PlayerChoice();
                    break;
            } 
        }
    }
    

}
