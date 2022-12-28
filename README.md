# Tic-Tac-Toe-game
Tic Tac Toe game in C#. I write this project for my 90 day C# learning

</h1>This C# code is for a Tic-tac-toe game</h1>
<h2>How Code work </h2>

The game is played on a 3x3 grid and consists of two players. The first player is represented by the letter 'X' and the second player is represented by the letter 'O'. The goal of the game is to get three of your letter in a row, either horizontally, vertically, or diagonally. The first player to do so wins the game.

The program is contained within a namespace called "Tic_tak_to_game" and has a class called "Program" with a Main method. The Main method is the entry point for the program and contains the code that runs the game.

Inside the Main method, the program initializes several variables, including an integer called "usr_input" which will store the user's input, and an integer called "player" which will keep track of which player's turn it is.

The program then enters a do-while loop which will continue to run until the "wflag" variable is equal to 't'. Within this loop, the program calls the "setfild" method which clears the console and displays the current state of the game board to the user. The program then alternates the value of the "player" variable between 1 and 2 to represent the alternating turns of the two players.

The program then enters another do-while loop which will continue to run until the "flag" variable is equal to 't'. Within this loop, the program prompts the current player to enter their move and stores the input in the "usr_input" variable. The program then checks the validity of the input with the "chack_input" method and, if the input is valid, updates the game board with the player's letter using the "input" method. The program then checks for a winner with the "winer" method. If a winner is found, the "flag" variable is set to 't' and the inner do-while loop is exited.

Once the inner do-while loop is exited, the program checks if the game ended in a draw by checking the value of the "draw_flag" variable. If the game ended in a draw, the "wflag" variable is set to 't' and the outer do-while loop is exited, ending the game.

The program also contains several additional methods, including "setfild" which displays the current state of the game board, "input" which updates the game board with the player's letter, "chack_input" which checks the validity of the user's input, and "winer" which checks for a winner.

<h3>To play the Tic-tac-toe game, follow these steps</h3>

<b>Run the program - Tic tak to game\bin\Release\Tic tak to game.exe </b>
Player 1 will be prompted to enter their move.
Player 1 should enter a number between 1 and 9, corresponding to the location on the game board where they would like to place their letter (X).
Player 2 will be prompted to enter their move.
Player 2 should enter a number between 1 and 9, corresponding to the location on the game board where they would like to place their letter (O).
Steps 3 and 4 will continue to alternate between the two players until one player gets three of their letters in a row or all of the spaces on the game board are filled.
If a player gets three of their letters in a row, they win the game and the program will end.
If all of the spaces on the game board are filled and no player has won, the game is a draw and the program will end.
