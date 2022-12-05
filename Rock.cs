using System;
namespace App
{
    class RockPaperScissors
    {
        public void RockP()
        {
            // STRINGS FOR GAMEMOVE AND PLAYERMOVE
            string[] gameMove = {"Rock", "Paper", "Scissors"};
            string PlayerMove = "Player move goes here";

            // GAMEMOVE RANDOM NUMBER GENERATOR
            Random rand = new Random();
            int move = rand.Next(3);

            // USER INPUR FOR GAME MOVE
            Console.Write("/>>> Enter your move: ");
            PlayerMove = Console.ReadLine();

            // GAME DECISION
            switch (PlayerMove)
            {
                case "rock":
                    if (gameMove[move] == "Rock"){Console.WriteLine($"/>>> Tie");}
                    if (gameMove[move] == "Paper"){Console.WriteLine($"/>>> You lose");}
                    if (gameMove[move] == "Scissors"){Console.WriteLine($"/>>> You win");}
                    break;

                case "paper":
                    if (gameMove[move] == "Rock"){Console.WriteLine($"/>>> You win");}
                    if (gameMove[move] == "Paper"){Console.WriteLine($"/>>> Tie");}
                    if (gameMove[move] == "Scissors"){Console.WriteLine($"/>>> You lose");}
                    break;

                case "scissors":
                    if (gameMove[move] == "Rock"){Console.WriteLine($"/>>> You lose");}
                    if (gameMove[move] == "Paper"){Console.WriteLine($"/>>> You win");}
                    if (gameMove[move] == "Scissors"){Console.WriteLine($"/>>> Tie");}
                    break;        

                default:
                    Console.WriteLine($"Invalid input");
                    break;
            }
            
        }
    }
}