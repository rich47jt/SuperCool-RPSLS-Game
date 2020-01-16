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
       
        public Game_Room()
        {
            Start();

        }

        public void Start()
        {
            ChooseGameMode();
            Play();
            Restart();
        }

        public void ChooseGameMode()
        {
            Console.WriteLine("Welcome to the game rock, paper, scissors, lizard, spock");
            Console.WriteLine("Please pick your game mode pvp or pvcomp:");
            string gamemode = Console.ReadLine();
         
            switch (gamemode)
            {

                case "pvp":
                    Console.WriteLine("you have choosen player vs player");
                    playerOne = new HeroePlayer("player one");
                    playerTwo = new HeroePlayer("player Two");
                    break;
               
                case "pvcomp":
                    Console.WriteLine("you have choosen player vs computer");
                    playerOne = new HeroePlayer("player one");
                    playerTwo = new VilliansComputer("player two");
                    break;

                default:
                    Console.WriteLine("incorrect response please choose again");
                    ChooseGameMode();
                    break;

            }
        }

        public void Play()
        {
            while(playerOne.score < 3 && playerTwo.score < 3)
            {

                playerOne.PlayerChoice();
                playerTwo.PlayerChoice();


                if (playerOne.choice ==  playerTwo.choice)
                {
                    Console.WriteLine("both players have tied this round"); 
                }

                
                else if (playerOne.choice == "rock" && playerTwo.choice == "paper")
                {
                    Console.WriteLine("player two has won");
                    playerTwo.score += 1;
                }
                else if (playerOne.choice == "rock" && playerTwo.choice == "scissors")
                {
                    Console.WriteLine("player one has won");
                    playerOne.score += 1;
                }
                else if (playerOne.choice == "rock" && playerTwo.choice == "lizard")
                {
                    Console.WriteLine("player one has won");
                    playerOne.score += 1;
                        
                }
                else if (playerOne.choice == "rock" && playerTwo.choice == "spock")
                {
                    Console.WriteLine("player two has won");
                    playerTwo.score += 1;
                }

                
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
                else if (playerOne.choice == "paper" && playerTwo.choice == "spock")
                {
                    Console.WriteLine("player one has won");
                    playerOne.score += 1;
                }

                
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
                else if (playerOne.choice == "scissors" && playerTwo.choice == "spock")
                {
                    Console.WriteLine("player two has won");
                    playerTwo.score += 1;
                }

                
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
                else if (playerOne.choice == "lizard" && playerTwo.choice == "spock")
                {
                    Console.WriteLine("player one has won");
                    playerOne.score += 1;

                }

                
                else if (playerOne.choice == "spock" && playerTwo.choice == "scissors")
                {
                    Console.WriteLine("player one has won");
                    playerOne.score += 1;
                }
                else if (playerOne.choice == "spock" && playerTwo.choice == "rock")
                {
                    Console.WriteLine("player one has won");
                    playerOne.score += 1;
                }
                else if (playerOne.choice == "spock" && playerTwo.choice == "paper")
                {
                    Console.WriteLine("player Two has won");
                    playerTwo.score += 1;

                }
                else if (playerOne.choice == "spock" && playerTwo.choice == "lizard")
                {
                    Console.WriteLine("player two has won");
                    playerTwo.score += 1;

                }
                


            }

           if (playerOne.score > 2)
            {
                Console.WriteLine("player one on has won round");
            }

           if(playerTwo.score > 2)
           {
                Console.WriteLine("player two has won  round");
           }

        }

        public void Restart()
        {
            Console.WriteLine("wanna play again Yes or No");
            string Userinput = Console.ReadLine();

            switch (Userinput)
            {
                case "Yes":
                    Console.WriteLine("Lets go");
                    Start();
                    break;

                case "No":
                    Console.WriteLine("See you Later");
                    break;

                default:
                    Console.WriteLine("incorrect input, YOU WANNA PLAY OR NOT!");
                    Restart();
                    break;
            }
        }

       

    }
}
