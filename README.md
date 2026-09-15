# Tic-Tac-Toe Game

A local two-player Tic-Tac-Toe desktop game built with C# and Windows Forms. The application manages alternating turns, detects wins and draws, highlights the winning line, and supports restarting the board without reopening the program.

## Features

- Local two-player gameplay
- Automatic alternation between Player 1 (`X`) and Player 2 (`O`)
- Validation that prevents selecting an occupied cell
- Win detection across rows, columns, and diagonals
- Draw detection after all nine cells are filled
- Visual highlight for the winning combination
- Current-player and winner status display
- One-click game restart

## Technologies

- C#
- Windows Forms
- .NET Framework 4.8
- Visual Studio

## Prerequisites

- Windows 10 or later
- Visual Studio 2022 with the **.NET desktop development** workload
- .NET Framework 4.8 targeting pack

## Run Locally

1. Clone the repository:

   ```bash
   git clone https://github.com/HashemQuraan-402/Tic-Tac-Toe-Game.git
   ```

2. Open `Tic-Tac_Toe Game.sln` in Visual Studio.
3. Select **Build > Build Solution**.
4. Press `F5` to run with debugging, or `Ctrl+F5` to run without debugging.

## How to Play

1. Player 1 selects an empty square to place `X`.
2. Player 2 selects an empty square to place `O`.
3. The first player to complete a row, column, or diagonal wins.
4. Select **Restart Game** to clear the board and begin again.

## Project Structure

```text
Tic-Tac-Toe-Game/
├── Properties/
├── Resources/
├── App.config
├── Form1.cs
├── Form1.Designer.cs
├── Form1.resx
├── Program.cs
├── Tic-Tac_Toe Game.csproj
├── Tic-Tac_Toe Game.sln
├── .gitignore
└── README.md
```

## Current Scope

The game supports two players on the same computer. It does not currently include an AI opponent, online multiplayer, saved scores, or automated tests.

## Future Improvements

- Extract the game rules into a testable game-engine class
- Add unit tests for win and draw detection
- Add an optional computer opponent
- Add score tracking across multiple rounds

## Author

**Hashem Quraan**

- [GitHub](https://github.com/HashemQuraan-402)
- [LinkedIn](https://www.linkedin.com/in/hashem-quraan-b561453ab)

