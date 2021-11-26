using System;
using System.Threading.Channels;

namespace Exercise4
{
    class Program
    {
        static void Main(string[] args)
        {
            Product1ToN();
        }

        static void Product1ToN()
        {
            int number = 1;
            for (int i = 1; i <= 10; i++)
            {
               number *= i;
            }

            Console.WriteLine(number);
        } 
    }
}
