using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;

namespace Histogram
{
    class Program
    {
        private const string Path = "../../midtermscores.txt";

        private static void Main(string[] args)
        {
            var readText = File.ReadAllText(Path);
            var sortMarks = new Dictionary<string, string>
            {
                {"00-09", String.Empty},
                {"10-19", String.Empty},
                {"20-29", String.Empty},
                {"30-39", String.Empty},
                {"40-49", String.Empty},
                {"50-59", String.Empty},
                {"60-69", String.Empty},
                {"70-79", String.Empty},
                {"80-89", String.Empty},
                {"90-99", String.Empty},
                {"100", String.Empty},

            };

            var entries = Regex.Split(readText, @" ");
            int[] myNumbers = Array.ConvertAll(entries, int.Parse);
            for (int i = 0; i < 100; i += 10)
            {
                sortMarks[$"{i:00}-{i + 9:00}"] += new string('*', myNumbers.Count(c => c >= i && c <= i + 9));
            }

            sortMarks[$"100"] += new string('*', myNumbers.Count(c => c == 100));

            foreach (var x in sortMarks)
            {
                Console.WriteLine($"{x.Key,7}: {x.Value}");
            }

            Console.ReadKey();
        }
    }
}