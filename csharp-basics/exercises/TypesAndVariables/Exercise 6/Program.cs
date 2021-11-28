using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Xml.Schema;

namespace Exercise_6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter numbers to sum!");
            var userInput = int.Parse(Console.ReadLine());
            int sum = 0;

            for (int i = 0; i <= userInput.ToString().Length; i++)
            {
                sum += i;
            }

            Console.WriteLine($"Total sum is {sum}");
        }
    }
}
