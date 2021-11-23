using System;
using System.Threading.Channels;

namespace Exercise_2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Write a program called CheckOddEven which prints "Odd Number" if the int variable “number” is odd, or “Even Number” otherwise. The program shall always print “bye!” before exiting.
            Console.WriteLine("Enter number to check if its Odd or Even!");
            int number = int.Parse(Console.ReadLine());
            CheckOddEven(number);
            Console.WriteLine("bye!");
        }

        static void CheckOddEven(int number)
        {
            if (number % 2 == 0)
                Console.WriteLine("Even Number");
            else
                Console.WriteLine("Odd Number");
        }
    }
}
