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
      public string name;     
      public string choice;
        

        //constructor 
        public Player()
        {
            gestures = new List<string>() { "Rock", "Paper", "Scissors","lizard","spok" };
            
        }

        //methods
        //choose guester
        public abstract void CharacterCall();
        //{
        //    //Console.WriteLine("lets play", name);


        //}

        public abstract void PlayerChoice();
        //{
        //    Console.WriteLine("Please enter a gesture");
        //    judgment = Console.ReadLine();

        //    switch (judgment)
        //    {
        //        case "rock":
        //            Console.WriteLine("My Choice is Rock" + judgment);
        //            break;
        //        case "paper":
        //            Console.WriteLine("My choice is Paper" + judgment);
        //            break;
        //        case "sissors":
        //            Console.WriteLine("My choice is scissors" + judgment);
        //            break;
        //        case "lizard":
        //            Console.WriteLine("My choice is lizard" + judgment);
        //            break;
        //        case "spok":
        //            Console.WriteLine("My choice is spok" + judgment);
        //            break;
        //        default:
        //            Console.WriteLine("Play by the rules and make an appropriate gesture");
        //            break;



        //    }
        //    Console.ReadLine();
        //}



    }
}
