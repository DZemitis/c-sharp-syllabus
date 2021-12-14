using System;
using System.Collections.Generic;
using System.Linq;

namespace Exercise_3
{
    class Program
    {
        public static List<string> names = new List<string>();

        static void Main(string[] args)
        {
            bool inputHappens = true;
            InputNames(inputHappens);
            PrintNamees();
        }

        public static void InputNames(bool inputHappens)
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

        public static void PrintNamees()
        {
            List<string> distinct = names.Distinct().ToList();
            foreach (var x in distinct)
            {
                Console.WriteLine(x);
            }
        }
    }
}