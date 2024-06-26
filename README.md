# Rock, Paper, Scissors Game

## Overview

This project is a console-based Rock, Paper, Scissors game in C#. Players compete against an AI with normal and hard (cheating AI) modes. The first player to reach 3 points wins.

## Code Structure

- **Program.cs**: Initializes and starts the game.
- **RPSGame.cs**: Contains game logic, including round handling, score tracking, and AI move generation.
- **Player.cs**: Manages player details and move selection.

## Unit Testing

- Tests are written using xUnit.
- **PlayerTests.cs**: Validates the `ChooseMove` method of the `Player` class.

## Running Tests

1. Open Test Explorer in Visual Studio.
2. Run the tests in the `RPS.Tests` project to ensure the code works correctly.

## Dependencies

- .NET Framework or .NET Core
- xUnit for unit testing
****
