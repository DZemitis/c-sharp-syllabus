using System;
using System.ComponentModel.Design;
using System.Runtime.InteropServices;

namespace Exercise_4
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] dayInWord = new[] {"Sunday", "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday"};
            Console.WriteLine("Enter 0-6 to get the day of the weak!");
            var userInput = int.Parse(Console.ReadLine());

            if (userInput == 0)
            {
                Console.WriteLine(dayInWord[0]);
            }
            else if (userInput == 1)
            {
                Console.WriteLine(dayInWord[1]);
            }
            else if (userInput == 2)
            {
                Console.WriteLine(dayInWord[2]);
            }
            else if (userInput == 3)
            {
                Console.WriteLine(dayInWord[3]);
            }
            else if (userInput == 4)
            {
                Console.WriteLine(dayInWord[4]);
            }
            else if (userInput == 5)
            {
                Console.WriteLine(dayInWord[5]);
            }
            else if (userInput == 6)
            {
                Console.WriteLine(dayInWord[6]);
            }
            else 
            {
                Console.WriteLine("Day is not valid!");
            }
        }
    }
}
