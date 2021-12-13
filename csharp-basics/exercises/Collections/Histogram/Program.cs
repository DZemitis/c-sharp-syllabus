using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Histogram
{
    class Program
    {
        private const string Path = "../../midtermscores.txt";

        private static void Main(string[] args)
        {
            var readText = File.ReadAllLines(Path);
            var sortMarks = new Dictionary<string, string>
            {
                { "00-09:", String.Empty },
                { "10-19:", String.Empty },
                { "20-29:", String.Empty },
                { "30-39:", String.Empty },
                { "40-49:", String.Empty },
                { "50-59:", String.Empty },
                { "60-69:", String.Empty },
                { "70-79:", String.Empty },
                { "80-89:", String.Empty },
                { "90-99:", String.Empty },
                { "100:", String.Empty },

            };
            
            foreach (var s in readText)
            {
                var entries = Regex.Split(s, @" ");
                int[] myNumbers = Array.ConvertAll(entries, int.Parse);
                foreach (var x in myNumbers)
                {
                    if (x < 10)
                    {
                        sortMarks["00-09:"] += "*";
                    }
                    else if (x >= 10 && x < 20)
                    {
                        sortMarks["10-19:"] += "*";
                    }
                    else if (x >= 20 && x < 30)
                    {
                        sortMarks["20-29:"] += "*";
                    }
                    else if (x >= 30 && x < 40)
                    {
                        sortMarks["30-39:"] += "*";
                    }
                    else if (x >= 40 && x < 50)
                    {
                        sortMarks["40-49:"] += "*";
                    }
                    else if (x >= 50 && x < 60)
                    {
                        sortMarks["50-59:"] += "*";
                    }
                    else if (x >= 60 && x < 70)
                    {
                        sortMarks["60-69:"] += "*";
                    }
                    else if (x >= 70 && x < 80)
                    {
                        sortMarks["70-79:"] += "*";
                    }
                    else if (x >= 80 && x < 90)
                    {
                        sortMarks["80-89:"] += "*";
                    }
                    else if (x >= 90 && x < 99)
                    {
                        sortMarks["90-99:"] += "*";
                    }
                    else if (x == 100)
                    {
                        sortMarks["100:"] += "*";
                    }
                }
            }

            foreach (var x in sortMarks)
            {
                Console.WriteLine($"{x.Key, 7} : {x.Value}");
            }
        }
    }
}
