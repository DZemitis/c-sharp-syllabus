using System;
using System.Collections.Generic;

namespace ListExercise11
{
    class Program
    {
        static void Main(string[] args)
        {
            var strings = new List<string>()
            {
                "A",
                "B",
                "C",
                "D",
                "E",
                "F",
                "G",
                "H",
                "I",
                "J",
            };
            strings[4] = "Z";
            strings[strings.Count - 1] = "X";
            strings.Sort();
            Console.WriteLine(strings.Contains("Foobar"));

            foreach (var x in strings)
            {
                Console.WriteLine(x);
            }
        }
    }
}