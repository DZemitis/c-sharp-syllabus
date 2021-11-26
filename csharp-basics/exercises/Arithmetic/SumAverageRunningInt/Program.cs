using System;

namespace SumAverageRunningInt
{
    class Program
    {
        static void Main(string[] args)
        {
            var sum = 0;
            const int lowerBound = 1;
            const int upperBound = 100;

            for (var number = lowerBound; number <= upperBound; ++number) 
            {
                sum += number;
            }
            
            double average = (double)(lowerBound + upperBound) / 2;

            Console.WriteLine("The sum of 1 to 100 is {0}", sum);
            Console.WriteLine("The average is {0}", average);
        }
    }
}
