using System;

namespace Exercise_6
{
    internal class FizzBuzz
    {
        public static void FizzBuzzGame()
        {
            Console.WriteLine("Please enter a number!");
            var input = int.Parse(Console.ReadLine());

            Console.WriteLine("Max Value? {0}", input);
            for (var i = 1; i <= input; i++)
            {
                if (i % 5 == 0 && i % 3 == 0)
                    Console.Write("FizzBuzz ");
                else if (i % 5 == 0)
                    Console.Write("Buzz ");
                else if (i % 3 == 0)
                    Console.Write("Fizz ");
                else
                    Console.Write(i + " ");

                if (i % 20 == 0) Console.WriteLine();
            }
        }
    }
}