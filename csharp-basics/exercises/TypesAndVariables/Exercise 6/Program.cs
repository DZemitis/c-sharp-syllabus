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
            int[] array = new int[5];
            Console.WriteLine("Please enter five numbers to get sum of them");
             
            for (int i = 0; i < 5; i++)
            {
                var input = Console.ReadKey().KeyChar.ToString();
                array[i] = int.Parse(input);
            }

            double sum = 0;

            foreach (int j in array)
            {
                sum += j;
            }

            Console.WriteLine("\nSum of your numbers are {0}", array.Sum());
        }
    }
}
