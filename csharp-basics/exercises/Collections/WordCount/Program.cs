using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;

namespace WordCount
{
    class Program
    {
        static void Main(string[] args)
        {
            string filePath = @"C:\Users\davis\Desktop\cshr\CSHARP\c-sharp-syllabus\csharp-basics\exercises\Collections\WordCount\lear.txt";
            List<string> lines = File.ReadAllLines(filePath).ToList();
            string AllText = File.ReadAllText(filePath);

            var wordsCount = Regex
                .Matches(
                    AllText,
                    @"\w+").Cast<Match>().Select(m => m.Value).ToList();

            var charsCount = File.ReadAllLines(filePath).Sum(s => s.Length);

            Console.WriteLine($"Lines = {lines.Count}");
            Console.WriteLine($"Words = {wordsCount.Count}");
            Console.WriteLine($"Chars = {charsCount}");
        }
    }
}