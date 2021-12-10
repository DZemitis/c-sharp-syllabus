using System;
using System.Linq;

namespace Exercise_3
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] randomNumbers = new int[20];
            Random rnd = new Random();
            
            for (int i = 0; i < randomNumbers.Length; i++)
            {
                randomNumbers[i] = rnd.Next(int.MinValue, int.MaxValue);
            }
            
            Console.WriteLine("Enter a number from 0 - 19 to get  random number!");
            int input = int.Parse(Console.ReadLine());

            var result = randomNumbers[input];
            Console.WriteLine($"Result is {result}");
        }
    }
}
