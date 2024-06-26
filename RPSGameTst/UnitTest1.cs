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

        // Helper class to mock Console.ReadLine() for testing purposes
        private class ConsoleOutput : IDisposable
        {
            private readonly StringWriter stringWriter;
            private readonly TextWriter originalOutput;

            public ConsoleOutput()
            {
                stringWriter = new StringWriter();
                originalOutput = Console.Out;
                Console.SetOut(stringWriter);
            }

            public void Enter(params string[] input)
            {
                foreach (var line in input)
                {
                    Console.SetIn(new StringReader(line + Environment.NewLine));
                }
            }

            public void Dispose()
            {
                Console.SetOut(originalOutput);
                stringWriter.Dispose();
            }
        }
    }
}
