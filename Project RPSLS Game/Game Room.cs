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
            
            ChooseGameMode();
            Play();

        }

        public void ChooseGameMode()
        {
            Console.WriteLine("please pick your game mode pvp or pvcomp");
            string gamemode = Console.ReadLine();
         
            switch (gamemode)
            {

                case "pvp":
                    Console.WriteLine("you have choosen player vs player");
                    playerOne = new HeroePlayer("playerone");
                    playerTwo = new HeroePlayer("playerTwo");
                    break;
               
                case "pvcomp":
                    Console.WriteLine("you have choosen player vs computer");
                    playerOne = new HeroePlayer("playerone");
                    playerTwo = new VilliansComputer("playertwo");
                    break;

                default:
                    Console.WriteLine("incorrect response please choose again");
                    ChooseGameMode();
                    break;

            }
        }

        public void Play()
        {
            while(playerOne.score < 2 && playerTwo.score < 2)
            {

                playerOne.PlayerChoice();
                playerTwo.PlayerChoice();


                if (playerOne.choice ==  playerTwo.choice)
                {
                    Console.WriteLine("both players have tied this round"); 
                }

                //start
                else if (playerOne.choice == "rock" && playerTwo.choice == "paper")
                {
                    Console.WriteLine("player two has won");
                    playerTwo.score += 1;
                }
                else if (playerOne.choice == "rock" && playerTwo.choice == "scissors")
                {
                    Console.WriteLine("player one has won the game");
                    playerOne.score += 1;
                }
                else if (playerOne.choice == "rock" && playerTwo.choice == "lizard")
                {
                    Console.WriteLine("player one has won");
                    playerOne.score += 1;
                        
                }
                else if (playerOne.choice == "rock" && playerTwo.choice == "spok")
                {
                    Console.WriteLine("player two has won");
                    playerTwo.score += 1;
                }

                //break
                else if (playerOne.choice == "paper" && playerTwo.choice == "scissors")
                {
                    Console.WriteLine("player two has won");
                    playerTwo.score += 1;
                }
                else if (playerOne.choice == "paper" && playerTwo.choice == "rock")
                {
                    Console.WriteLine("player one has won");
                    playerOne.score += 1;
                }
                else if (playerOne.choice == "paper" && playerTwo.choice == "lizard")
                {
                    Console.WriteLine("player two has won");
                    playerTwo.score += 1;

                }
                else if (playerOne.choice == "paper" && playerTwo.choice == "spok")
                {
                    Console.WriteLine("player one has won");
                    playerOne.score += 1;
                }
                //break
                else if (playerOne.choice == "scissors" && playerTwo.choice == "paper")
                {
                    Console.WriteLine("player one has won");
                    playerOne.score += 1;
                }
                else if (playerOne.choice == "scissors" && playerTwo.choice == "rock")
                {
                    Console.WriteLine("player two has won");
                    playerTwo.score += 1;
                }
                else if (playerOne.choice == "scissors" && playerTwo.choice == "lizard")
                {
                    Console.WriteLine("player one has won");
                    playerOne.score += 1;

                }
                else if (playerOne.choice == "scissors" && playerTwo.choice == "spok")
                {
                    Console.WriteLine("player two has one");
                    playerTwo.score += 1;
                }
                //break
                else if (playerOne.choice == "lizard" && playerTwo.choice == "scissors")
                {
                    Console.WriteLine("player two has won");
                    playerTwo.score += 1;
                }
                else if (playerOne.choice == "lizard" && playerTwo.choice == "rock")
                {
                    Console.WriteLine("player two has won");
                    playerTwo.score += 1;
                }
                else if (playerOne.choice == "lizard" && playerTwo.choice == "paper")
                {
                    Console.WriteLine("player one has won");
                    playerOne.score += 1;

                }
                else if (playerOne.choice == "lizard" && playerTwo.choice == "spok")
                {
                    Console.WriteLine("player one has won");
                    playerOne.score += 1;

                }
                //break
                else if (playerOne.choice == "spok" && playerTwo.choice == "scissors")
                {
                    Console.WriteLine("player one has won");
                    playerOne.score += 1;
                }
                else if (playerOne.choice == "spok" && playerTwo.choice == "rock")
                {
                    Console.WriteLine("player one has won");
                    playerOne.score += 1;
                }
                else if (playerOne.choice == "spok" && playerTwo.choice == "paper")
                {
                    Console.WriteLine("player Two has won");
                    playerTwo.score += 1;

                }
                else if (playerOne.choice == "spok" && playerTwo.choice == "lizard")
                {
                    Console.WriteLine("player two has won");
                    playerTwo.score += 1;

                }
                //end


            }


            if (playerOne.score > 2)
            {
                Console.WriteLine("player one on has won game");
            }
            else
            {
                Console.WriteLine("player two has lost this round");
            }

        }

       

    }
}
