using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;

namespace Exercise_6
{
    class Program
    {
        static void Main(string[] args)
        {
            // Write a program that asks the user to enter a series of single digit numbers and calculate the sum of all the numbers.
            //int[] userInputNumbers = new int[] {int.Parse(Console.ReadLine())};
            // List<int> list1 = new List<int>() { int.Parse(Console.ReadLine()) };
            // int sum2 = list1.Sum();
            // int sumOfInput = userInputNumbers.Sum();
            //Console.WriteLine("Sum is {0}", userInputNumbers);
            // Console.WriteLine("Sum is {0}", sum2);
            double[] array = new double[6];
            Console.WriteLine("Please enter your numbers");
            for (int i = 0; i < 6; i++)
            {
                array[i] = Convert.ToDouble(Console.ReadLine());
            }

            double sum = 0;

            foreach (double j in array)
            {
                sum += j;
            }

            Console.WriteLine("sum of numbers are {0}", array.Sum());
        }
        }
    }
