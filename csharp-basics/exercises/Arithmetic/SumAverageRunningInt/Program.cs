using System;

namespace SumAverageRunningInt
{
    class Program
    {
        static void Main(string[] args)
        {
            //See SumAverageRunningInt Write a program called SumAverageRunningInt to produce the sum of 1, 2, 3, ..., to 100.
            //Store 1 and 100 in variables lower bound and upper bound, so that we can change their values easily.
            //Also compute and display the average. The output shall look like:

           //The sum of 1 to 100 is 5050
            //The average is 50.5
            var sum = 0;
            int average;
            const int lowerBound = 1;
            const int upperBound = 100;

            for (var number = lowerBound; number <= upperBound; ++number) 
            {
                sum += number;
            }
        }

    }
}
