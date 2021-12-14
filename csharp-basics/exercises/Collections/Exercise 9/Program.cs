using System;
using System.Collections.Generic;

namespace Exercise_9
{
    class Program
    {
        static void Main(string[] args)
        {
            var newHash = new HashSet<string>();
            newHash.Add("Audi");
            newHash.Add("BMW");
            newHash.Add("Mazda");
            newHash.Add("Nissan");
            newHash.Add("VW");
            foreach (var x in newHash)
            {
                Console.WriteLine(x);
            }

            Console.WriteLine();
            newHash.Clear();
            newHash.Add("Audi");
            newHash.Add("BMW");
            newHash.Add("Mazda");
            newHash.Add("Nissan");
            newHash.Add("VW");
            newHash.Add("Audi");
            newHash.Add("BMW");
            foreach (var x in newHash)
            {
                Console.WriteLine(x);
            }
        }
    }
}
