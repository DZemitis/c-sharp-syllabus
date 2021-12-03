using System;

namespace Exercise_7
{
    public class Piglet
    {
        public static int[] Dice = new int[6];

        public static void RollDice(int[] Dice)
        {
            Random rnd = new Random();

            for (int i = 0; i < Dice.Length; i++)
            {
                Dice[i] = rnd.Next(1, 6);
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number from 0 - 19 to get  random number!");
            int input = int.Parse(Console.ReadLine());

            var result = Dice[input];
            Console.WriteLine($"Result is {result}");

            //Write a console program in a class named Piglet that implements a simple 1-player dice game called "Piglet"
            //(based on the game "Pig"). The player's goal is to accumulate as many points as possible without rolling a 1.
            //Each turn, the player rolls the die; if they roll a 1,
            //the game ends and they get a score of 0. Otherwise, they add this number to their running total score.
            //The player then chooses whether to roll again, or end the game with their current point total.
            //Here is an example dialogue where the user plays until rolling a 1, which ends the game with 0 points:

            //Welcome to Piglet!
            //You rolled a 5!
            //Roll again? yes
            //You rolled a 4!
            //Roll again? yes
            //You rolled a 1!
            //You got 0 points.
        }
    }
}
