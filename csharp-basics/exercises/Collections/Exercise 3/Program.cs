using System;
using System.Collections.Generic;
using System.Linq;

namespace Exercise_3
{
    class Program
    {
        public static bool inputHappens = true;
        public static List<string> names = new List<string>();

        static void Main(string[] args)
        {
            inputNames();
            printNamees();
        }

        public static void inputNames()
        {
            Console.WriteLine("Enter list of names, pres Enter after done");

            while (inputHappens == true)
            {
                var input = Console.ReadLine();
                if (!string.IsNullOrEmpty(input))
                {
                    names.Add(input);
                }
                else
                {
                    inputHappens = false;
                }
            }
        }

        public static void printNamees()
        {
            List<string> distinct = names.Distinct().ToList();
            foreach (var x in distinct)
            {
                Console.WriteLine(x);

            }
        }
    }
}