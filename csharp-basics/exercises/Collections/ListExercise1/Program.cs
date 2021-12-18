using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListExercise1
{
    class Program
    {
        private static void Main(string[] args)
        {
            
            var colors = new List<string>();

            colors.Add("Red");
            colors.Add("Yellow");
            colors.Add("Black");
            colors.Add("Grey");
            colors.Add("Pink");
            colors.Add("White");
            foreach (var x in colors)
            {
                Console.WriteLine(x);
            }

            Console.WriteLine();
        }
    }
}
