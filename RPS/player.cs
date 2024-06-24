using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPS
{
    public class Player
    {
        
            public string Name { get; set; }
            public int Score { get; set; }

        public Player(string name)
        {
            Name = name;
            Score = 0;
        }

            public string ChooseMove()
            {
                string move = "";
                while (true)
                {
                    Console.WriteLine($"{Name}, choose your move (r for rock, p for paper, s for scissors e  for end the game): ");
                    move = Console.ReadLine().ToLower();
                if (move == "r")
                {
                    move = "rock";
                    break;
                }
                else if (move =="p")
                {
                    move = "paper";
                    break;
                }
                else if (move == "s")
                {
                    move = "scissors";
                    break;
                }
                else if (move =="e")
                {
                    move = "end";
                    break;

                }
                else
                    Console.WriteLine("Invalid move. Please choose again.");
                }
                return move;
            
        }
    }
}
