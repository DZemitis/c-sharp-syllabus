using System;
using System.Threading.Channels;

namespace Exercise_2
{
    class Program
    {
        static void Main(string[] args)
        {
            var x = new OddOrEven(15);
            Console.WriteLine(x.CheckOddOrEven());
        }
    }
}