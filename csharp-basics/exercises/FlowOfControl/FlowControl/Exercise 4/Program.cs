using System;
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

                switch (userInput)
                {
                    case 0:
                        Console.WriteLine(dayInWord[0]);
                        break;
                    case 1:
                        Console.WriteLine(dayInWord[1]);
                        break;
                    case 2:
                        Console.WriteLine(dayInWord[2]);
                        break;
                    case 3:
                        Console.WriteLine(dayInWord[3]);
                        break;
                    case 4:
                        Console.WriteLine(dayInWord[4]);
                        break;
                    case 5:
                        Console.WriteLine(dayInWord[5]);
                        break;
                    case 6:
                        Console.WriteLine(dayInWord[6]);
                        break;
                    default:
                        Console.WriteLine("Day is not valid");
                        break;
                }
        }
    }
}
