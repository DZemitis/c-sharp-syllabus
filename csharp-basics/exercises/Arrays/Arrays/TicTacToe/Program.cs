﻿using System;
using System.ComponentModel;
using System.Media;

namespace TicTacToe
{
    class Program
    {
        private static char[,] board = new char[3, 3];

        private static void Main()
        {
            char player = 'X';
            int movesPlayed = 0;
            InitBoard();
            bool playAgain = true;

            while (playAgain == true)
            {
                DisplayBoard();
                Console.WriteLine($"Player {player} make a move!");
                Console.Write("Please enter row: ");
                int row = int.Parse(Console.ReadKey().KeyChar.ToString());
                Console.Write("\nPlease enter col: ");
                int col = int.Parse(Console.ReadKey().KeyChar.ToString());
                board[row, col] = player;
                Console.Clear();

                //win conditions
                if (player == board[0, 0] && player == board[0, 1] && player == board[0, 2])
                {
                    Console.WriteLine($"{player} has won the game");
                    break;
                }
                else if (player == board[1, 0] && player == board[1, 1] && player == board[1, 2])
                {
                    Console.WriteLine($"{player} has won the game");
                    break;
                }
                else if (player == board[2, 0] && player == board[2, 1] && player == board[2, 2])
                {
                    Console.WriteLine($"{player} has won the game");
                    break;
                }
                else if (player == board[0, 0] && player == board[1, 1] && player == board[2, 2])
                {
                    Console.WriteLine($"{player} has won the game");
                    break;
                }
                else if (player == board[2, 0] && player == board[1, 1] && player == board[0, 2])
                {
                    Console.WriteLine($"{player} has won the game");
                    break;
                }
                else if (player == board[0, 0] && player == board[1, 0] && player == board[2, 0])
                {
                    Console.WriteLine($"{player} has won the game");
                    break;
                }
                else if (player == board[0, 1] && player == board[1, 1] && player == board[2, 1])
                {
                    Console.WriteLine($"{player} has won the game");
                    break;
                }
                else if (player == board[0, 2] && player == board[1, 2] && player == board[2, 2])
                {
                    Console.WriteLine($"{player} has won the game");
                    break;
                }

                for (int i = 0; i < board.Length; i++)
                {
                    if (board[col,row] == 'X')
                    {
                        Console.WriteLine("Already exist!");
                    }
                    else
                    {
                        board[row, col] = player;
                        movesPlayed++;
                    }
                }
               
                /*if (board[col, row] == player)
                {
                    Console.WriteLine("Already exists!");
                }
                else
                {
                    board[row, col] = player;
                    movesPlayed++;
                }*/

                //player turns
                movesPlayed = movesPlayed + 1;
                if (movesPlayed == 9)
                {
                    Console.WriteLine("DRAW!!!");
                    break;
                }
                
                player = PlayerTurn(player);
            }

            Console.WriteLine("Game ended!");
            Console.WriteLine("Would You like to Restart the game? Y/N");
            char restartGame = Console.ReadKey().KeyChar;
            //restart game
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

        private static void addData(out int row, out int col)
        {
            throw new NotImplementedException();
        }

        private static void Draw(int playerMoves)
        {
            playerMoves = playerMoves + 1;

            if (playerMoves == 9)
            {
                Console.Clear();
                Console.WriteLine("Its a tie!");
            }
        }

        private static char PlayerTurn(char currentPlayer)
        {
            if (currentPlayer == 'X')
            {
                return 'O';
            }
            else
            {
                return 'X';
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
