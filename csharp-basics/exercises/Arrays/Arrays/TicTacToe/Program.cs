using System;

namespace TicTacToe
{
    class Program
    {
        private static char[,] board = new char[3, 3];

        private static void Main()
        {
            char player = 'X';
            int turns = 1;
            InitBoard();
            bool playAgain = true;

            while (playAgain)
            {
                Console.Clear();
                DisplayBoard();
                Console.WriteLine($"\nPlayer {player} make a move!");
                AddData(out int row, out int col);
                
                if (board[row, col] == 'X' || board[row, col] == 'O')
                {
                    Console.WriteLine("\nAlready exist");
                    Console.ReadKey();
                    turns--;
                }
                else
                {
                    board[row, col] = player;
                }
                turns++;

                player = turns % 2 == 0 ? 'O' : 'X';

                if (player == board[0, 0] && player == board[0, 1] && player == board[0, 2] ||
                    player == board[1, 0] && player == board[1, 1] && player == board[1, 2] ||
                    player == board[2, 0] && player == board[2, 1] && player == board[2, 2] ||
                    player == board[0, 0] && player == board[1, 1] && player == board[2, 2] ||
                    player == board[2, 0] && player == board[1, 1] && player == board[0, 2] ||
                    player == board[0, 0] && player == board[1, 0] && player == board[2, 0] ||
                    player == board[0, 1] && player == board[1, 1] && player == board[2, 1] ||
                    player == board[0, 2] && player == board[1, 2] && player == board[2, 2])
                {
                    Console.Clear();
                    Console.WriteLine($"Congratulations, {player} has won the game!");
                    break;
                }

                if (turns != 10) continue;
                Console.Clear();
                Console.WriteLine("Its a tie!");
                break;
            }
            
            Console.WriteLine("Game ended!");
            Console.WriteLine("Would You like to Restart the game? Y/N");
            char restartGame = Console.ReadKey().KeyChar;
            
            RestartGame(restartGame, playAgain);
        }

        private static void RestartGame(char restartGame, bool playAgain)
        {
            if (restartGame == 'y')
            {
                Console.Clear();
                playAgain = true;
                Main();
            }
            else
            {
                Console.Clear();
                Console.WriteLine("Thank You for the game!");
            }
        }

        private static void AddData(out int row, out int col)
        {
            Console.Write("Please enter row: ");
            string inputRow = Console.ReadKey().KeyChar.ToString();

            while (!int.TryParse(inputRow, out row))
            {
                Console.Write("Please enter row: ");
                inputRow = Console.ReadKey().KeyChar.ToString();
            }

            Console.Write("\nPlease enter col: ");
            string inputColumn = Console.ReadKey().KeyChar.ToString();

            while (!int.TryParse(inputColumn, out col))
            {
                Console.Write("\nPlease enter col: ");
                inputColumn = Console.ReadKey().KeyChar.ToString();
            }
        }

        private static void InitBoard()
        {
            for (var r = 0; r < 3; r++)
            {
                for (var c = 0; c < 3; c++)
                    board[r, c] = ' ';
            }
        }

        private static void DisplayBoard()
        {
            Console.WriteLine("     0   1   2 ");
            Console.WriteLine("  0  " + board[0, 0] + " | " + board[0, 1] + " | " + board[0, 2]);
            Console.WriteLine("    ---+---+---");
            Console.WriteLine("  1  " + board[1, 0] + " | " + board[1, 1] + " | " + board[1, 2]);
            Console.WriteLine("    ---+---+---");
            Console.WriteLine("  2  " + board[2, 0] + " | " + board[2, 1] + " | " + board[2, 2]);
            Console.WriteLine();
        }
    }
}