using System;

namespace Exercise_9
{
    class RollTwoDice
    {
        private static int[] _diceGenerator = new int[6];
        private static int _input = int.Parse(Console.ReadLine());

        private static void CreateDice(int[] dice)
        {
            Random rnd = new Random();

            for (int i = 0; i < dice.Length; i++)
            {
                dice[i] = rnd.Next(1, 7);
            }
        }

        public static void Game()
        {
            CreateDice(_diceGenerator);
            int dice1 = _diceGenerator[0];
            int dice2 = _diceGenerator[5];
            Console.WriteLine($"Desired sum is {_input}");
            while (dice1 + dice2 != _input)
            {
                dice1 = _diceGenerator[0];
                dice2 = _diceGenerator[5];
                CreateDice(_diceGenerator);
                Console.WriteLine($"{dice1} and {dice2} = {dice1 + dice2}");
            }
        }
    }
}