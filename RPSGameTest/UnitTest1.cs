namespace RPSGameTest
{
    using Xunit;
    using RPS;
   
    using System.Numerics;

        public class RPSGameTests
        {
            [Fact]
            public void CompareMoves_PlayerWins()
            {
                // Arrange
                var game = new RPSGame();
                string playerMove = "rock";
                string aiMove = "scissors";

                // Act
                int result = game.CompareMoves(playerMove, aiMove);

                // Assert
                Assert.Equal(1, result);
            }

           
            
        }
    }


