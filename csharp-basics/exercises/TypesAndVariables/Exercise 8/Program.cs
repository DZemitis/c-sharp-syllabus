using System;

namespace Exercise_8
{
    class Program
    {
        static void Main(string[] args)
        { 
            Console.WriteLine("Enter minutes to calculate!");
                int minutes = int.Parse(Console.ReadLine());
                if (minutes < 0)
                {
                    Console.WriteLine("Invalid Value");
                }
                else
                {
                    int hours = minutes / 60;
                    int day = hours / 24;
                    int years = day / 365;
                    int remainingDays = day % 365;
                    Console.WriteLine(minutes + " minutes is " + years + " years and " + remainingDays + " days!");
                }
        }
    }
}
