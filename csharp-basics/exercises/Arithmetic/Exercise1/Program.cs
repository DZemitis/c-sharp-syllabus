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

            var magicNumber = new Magic15(number1, number2);
            Console.WriteLine(magicNumber.CheckIfSumOrNumberIs15());
        }
    }
}