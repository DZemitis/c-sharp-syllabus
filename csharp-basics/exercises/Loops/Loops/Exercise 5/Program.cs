using System;
using System.Linq;
using System.Transactions;

namespace Exercise_5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter first word");
            var input = Console.ReadLine();
            Console.WriteLine("Please enter second word");
            var input2 = Console.ReadLine();
            var missingLength = 0;
            if (input.Length + input2.Length <= 30)
            {
                missingLength = 30 - (input.Length + input2.Length);
            }

            Console.WriteLine(input + String.Concat(Enumerable.Repeat(".", missingLength)) + input2);
        }
    }
}
