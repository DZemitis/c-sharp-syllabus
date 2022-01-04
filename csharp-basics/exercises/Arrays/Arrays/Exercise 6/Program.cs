using System;

namespace Exercise_6
{
    class Program
    {
        static void Main(string[] args)
        {
            var arrayMethod = new MakeArray();
            var array1 = arrayMethod.RandomArray();
            var array2 = arrayMethod.ClonedArray(array1);
            Console.WriteLine(arrayMethod.PrintArray("Array1"));
            Console.WriteLine(PrintArray(array2, "Array2"));
        }

        private static string PrintArray(int[] array, string name)
        {
            var stringBuilder = $"{name} :";
            foreach (var n in array)
            {
                stringBuilder += $" {n}";
            }

            return stringBuilder;
        }
    }
}