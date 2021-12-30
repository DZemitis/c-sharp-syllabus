using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace WordCount
{
    class Program
    {
        static void Main(string[] args)
        {
            string filePath = "../../lear.txt";
            var lines =  File.ReadAllLines(filePath).ToList();
            var text = new TextCalculator(lines);
            var allText = string.Empty;
            foreach (var z in lines)
            {
                allText += z;
            }

            Console.WriteLine(allText);
            var x = allText.Split(' ',',');
            var count = 0;
            foreach (var n in x)
            {
                Console.WriteLine(n);
                count++;

            }

            Console.WriteLine(count);
            
            Console.WriteLine($"Lines = {text.LinesCount()}");
            Console.WriteLine($"Words = {text.WordsCount()}");
            Console.WriteLine($"Chars = {text.CharsCount()}");
        }
    }
}