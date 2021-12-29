using System;

namespace Exercise_6
{
    class Program
    {
        static void Main(string[] args)
        {
            var newArray1 = new MakeArray();
            newArray1.RandomArray();
            Console.WriteLine(newArray1.PrintArray("newArray1"));

            var copyArray = newArray1.CloneChangeLastNegative7();
            Console.WriteLine(PrintArray(copyArray, "copyArray"));
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