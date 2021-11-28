﻿using System;
using System.Linq;

namespace Exercise3
{
    class Program
    {
        //TODO: Write a C# program to calculate the average value of array elements.
        private static void Main(string[] args)
        {
            int[] numbers = {20, 30, 25, 35, -16, 60, -100};

            int sum = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                sum += numbers[i];
            }

            var avg = Math.Round(numbers.Average(), 2);

            Console.WriteLine($"Sum of numbers array is {sum}");
            Console.WriteLine("Average value of the array elements is : " + avg);
            
        }
    }
}
