using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPS
{
    public class RPSGame
    {
        private Player player;
        private Player ai;
        private Random random;
        private bool isHardMode;
        

        public RPSGame()
        {
            player = new Player("player");
            ai = new Player("AI");
            random = new Random();
            isHardMode = false;

            Console.WriteLine("Choose difficulty: \n1. Normal \n2. Hard (AI Cheat Mode)");

            string choice="";

            try
            {
                choice = Console.ReadLine();
            }
            catch (Exception ex)
            {
                Console.WriteLine("An error occurred: " + ex.Message);
                
            }

            if (choice == "2")
                isHardMode = true;
        }

        public void PlayGame()
        {
            Console.Clear();
            int round = 1;
            while (player.Score < 3 && ai.Score < 3)
            {
                Console.WriteLine($"\n--- Round {round} ---");
                PlayRound();
                DisplayScores();
                round++;
                
            }
            DeclareWinner();
        }

        private void PlayRound()
        {
            string playerMove = player.ChooseMove();
            string aiMove = isHardMode ? GetCheatingAIMove(playerMove) : GetAIMove();

            Console.WriteLine($"AI chose: {aiMove}");
            int result = CompareMoves(playerMove, aiMove);

            if (result == 1)
            {
                Console.WriteLine($"{player.Name} wins this round!");
                player.Score++;
            }
            else if (result == -1)
            {
                Console.WriteLine($"{ai.Name} wins this round!");
                ai.Score++;
            }
            else if(result==10)
            {
                Console.WriteLine("you chose end this game!");
                ai.Score = 3;
            }
            else
            {
                Console.WriteLine("This round is a draw!");
            }
        }

        private string GetAIMove()
        {
            string[] options = { "rock", "paper", "scissors" };
            int choice = random.Next(0, options.Length);

            return options[choice];

        }

        private string GetCheatingAIMove(string playerMove)
        {
            switch (playerMove)
            {
                case "rock": return "paper";
                case "paper": return "scissors";
                case "scissors": return "rock";
                default: return "rock";
            }
        }

        public int CompareMoves(string playerMove, string aiMove)
        {
            if (playerMove =="end")
                return 10;
            if (playerMove == aiMove) return 0;

            if ((playerMove == "rock" && aiMove == "scissors") ||
                (playerMove == "paper" && aiMove == "rock") ||
                (playerMove == "scissors" && aiMove == "paper"))
            {
                return 1;
            }
            else
            {
                return -1;
            }
        }

        private void DisplayScores()
        {
            Console.WriteLine($"\nScores:\n{player.Name}: {player.Score}\n{ai.Name}: {ai.Score}");
        }

        private void DeclareWinner()
        {
            Thread.Sleep(3000);
            Console.Clear();
            if (player.Score > ai.Score)
            {
                Console.WriteLine($"\n{player.Name} wins the game!");
            }
            else
            {
                Console.WriteLine($"\n{ai.Name} wins the game!");
            }
        }
    }
}
