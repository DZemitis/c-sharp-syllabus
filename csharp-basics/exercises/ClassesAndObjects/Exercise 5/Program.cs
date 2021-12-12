using System;

namespace Exercise_5
{
    class Program
    {
        static void Main(string[] args)
        {
            var test = new Date(9, 22, 1989);
            test.Day = 30;
            test.Year = 2000;
            test.Month = 12;
            Console.WriteLine(test.DisplayDate());
        }
    }
}
