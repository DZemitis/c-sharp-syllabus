using System;
using System.Linq;

namespace Exercise_6
{
    class Program
    {
        static void Main(string[] args)
        {
            int min = 1;
            int max = 100;
            Random randomNum = new Random();
            int[] array1 = Enumerable
                .Repeat(0, 10)
                .Select(i => randomNum.Next(min, max))
                .ToArray();

            int[] array2 = new int[array1.Length];
            array1.CopyTo(array2, 0);
            array1[9] = -7;

            Console.Write("Array 1: ");
            for (int i = 0; i < array1.Length; i++)
            {
                Console.Write(array1[i].ToString() + " ");
            }

            Console.Write("\nArray 2: ");
            for (int i = 0; i < array2.Length; i++)
            {
                Console.Write(array2[i].ToString() + " ");
            }
        }
    }
}
