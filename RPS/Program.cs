

namespace RPS
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Rock, Paper, Scissors!");
            Console.WriteLine("You will be playing against an AI opponent, Choose 'rock', 'paper', or 'scissors' to make your move.");
            Console.WriteLine("The first player to reach 3 points wins the game.");
            Console.WriteLine("You can choose between Normal mode and Hard mode (AI Cheat Mode).\n");

            RPSGame game = new RPSGame();
            game.PlayGame();
        }

    }
}
