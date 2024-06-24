using Xunit;
using RPS;
using System.Text;

namespace RPSGameTst
{
    public class UnitTest1
    {
        [Fact]
        public void CompareMoves_PlayerWins()
        {
            // Arrange
            var game = new RPSGame();
            var plyer = new Player("plyer");
           

            // Act
            int result = game.CompareMoves("r","s" );

            // Assert
            Assert.Equal(1, result); // Assuming 1 indicates player wins
        }
    }
}
