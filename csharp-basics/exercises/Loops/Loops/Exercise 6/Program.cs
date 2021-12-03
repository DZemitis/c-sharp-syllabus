using System;

namespace Exercise_6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a number!");
            int input = int.Parse(Console.ReadLine());

            if (input > 100)
            {
                Console.WriteLine("Max Value? 100");
                for (int i = 1; i <= 100; i++)
                {
                    if (i % 5 == 0 && i % 3 == 0)
                    {
                        Console.Write("FizzBuzz ");
                    }
                    else if (i % 5 == 0)
                    {
                        Console.Write("Buzz ");
                    }
                    else if (i % 3 == 0)
                    {
                        Console.Write("Fizz ");
                    }
                    else
                    {
                        Console.Write(i + " ");
                    }

                    if (i % 20 == 0)
                    {
                        Console.WriteLine();
                    }
                }
            }
            else
            {
                for (int i = 1; i <= input; i++)
                {
                    if (i % 5 == 0 && i % 3 == 0)
                    {
                        Console.Write("FizzBuzz ");
                    }
                    else if (i % 5 == 0)
                    {
                        Console.Write("Buzz ");
                    }
                    else if (i % 3 == 0)
                    {
                        Console.Write("Fizz ");
                    }
                    else
                    {
                        Console.Write(i + " ");
                    }

                    if (i % 20 == 0)
                    {
                        Console.WriteLine();
                    }
                }
            }
        }
    }
}

