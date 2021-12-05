using System;

namespace ConsoleApp1
{
    class Piglet
    {
        public static int[] Dice = new int[6];
        private static int _count = 0;
        private static bool _gameOn = true;

        public static void RandomDice(int[] Dice)
        {
            Random rnd = new Random();

            for (int i = 0; i < Dice.Length; i++)
            {
                Dice[i] = rnd.Next(1, 6);
            }
        }

        public static void PigGame()
        {
            while (_gameOn)
            {
                foreach (var t in Dice)
                {
                    if (t == 1)
                    {
                        _count = 0;
                        Console.WriteLine("You rolled 1. Game Over!");
                        _gameOn = false;
                        break;
                    }
                    else
                    {
                        _count += t;
                        Console.WriteLine($"You rolled: {t}");
                        Console.WriteLine($"Your score is {_count}");
                        Console.WriteLine("Roll again? y/n");
                        var rollAgain = Console.ReadKey().KeyChar;
                        if (rollAgain == 'y')
                        {
                            continue;
                        }
                        else
                        {
                            Console.WriteLine($"\nThanks for game! Your total is {_count}");
                            Console.ReadKey();
                            _gameOn = false;

                        }
                    }
                }
            }
        }
    }
}