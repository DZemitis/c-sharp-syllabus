using System;

namespace ConsoleApp1
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Welcome to game of Piglet!\n" +
                              "It's a single player game, where You can roll dice!\n" +
                              "Its simple! You keep on rolling or stop, just be careful.\n" +
                              "If you roll 1, the game ends, and You get 0 points...\n" +
                              "Press any key if You want to roll Your first dice!");
            Console.ReadKey();
            Piglet.RandomDice(Piglet.Dice);
            Piglet.PigGame();
        }
    }
}