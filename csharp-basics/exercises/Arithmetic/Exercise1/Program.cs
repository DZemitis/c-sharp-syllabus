using System;

namespace ConsoleApp8
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter first number");
            int number1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter second number");
            int number2 = int.Parse(Console.ReadLine());
            Console.WriteLine(CheckIfTrue(number1, number2));
        }

        public static bool CheckIfTrue(int number1, int number2)
        {
            if (number1 + number2 == 15 || number2 - number1 == 15 || number1 == 15 || number2 == 15 || number1 - number2 == 15)
            {
                return true;
            }

            return false;
        }
    }
}