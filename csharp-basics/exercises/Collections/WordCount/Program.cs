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
            
            Console.WriteLine($"Lines = {text.LinesCount()}");
            Console.WriteLine($"Words = {text.WordsCount()}");
            Console.WriteLine($"Chars = {text.CharsCount()}");
        }
    }
}