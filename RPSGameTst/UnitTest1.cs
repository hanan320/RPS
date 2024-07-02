using System;
using Xunit;
namespace RPS.Tests
{
    public class PlayerTests
    {
        [Fact]
        public void ChooseMove_InputValidation()
        {
            // Arrange
            Player player = new Player("TestPlayer");
            string[] validInputs = { "r", "p", "s" };
           
            foreach (string input in validInputs)
            {
                using (var consoleOutput = new ConsoleOutput())
                {
            // Act
                    consoleOutput.Enter(input);
                    string move = player.ChooseMove();

                    // Assert
                    Assert.True(new[] { "rock", "paper", "scissors" }.Contains(move));
                }
            }

            using (var consoleOutput = new ConsoleOutput())
            {
                // Act: Invalid input followed by valid input
                consoleOutput.Enter("invalid input", "r");
                string move = player.ChooseMove();

            // Assert
                Assert.Equal("rock", move);
            }
        }

    }
}
