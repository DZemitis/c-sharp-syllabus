using System;
using System.Collections.Generic;
using System.Linq;

namespace ListExercise4
{
    class Program
    {
        private static void Main(string[] args)
        {
            var colors = new List<string>
            {
                "Red",
                "Green",
                "Orange",
                "White",
                "Black"
            };

            Console.WriteLine("First element: " + colors.First());

            Console.WriteLine("Third element: " + colors[2]);
        }
    }
}
