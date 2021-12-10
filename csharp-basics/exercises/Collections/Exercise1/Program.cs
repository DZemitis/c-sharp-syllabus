using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace Exercise1
{
    class Program
    {
        private static void Main(string[] args)
        {
            string[] array = { "Audi", "BMW", "Honda", "Mercedes", "VolksWagen", "Mercedes", "Tesla" };
            List<string> cars = array.ToList();
            foreach (var x in cars)
            {
                Console.WriteLine(x);
            }

            Console.WriteLine();

            var hashCars = new HashSet<string>(array);
            foreach (var x in hashCars)
            {
                Console.WriteLine(x);
            }

            Console.WriteLine();

            SortedList sortedCars = new SortedList();
            sortedCars.Add("Audi", "Germany");
            sortedCars.Add("BMW", "Germany");
            sortedCars.Add("Honda", "Japan");
            sortedCars.Add("Mercedes", "Germany");
            sortedCars.Add("VolksWagen", "Germany");
            sortedCars.Add("Tesla", "USA");

            PrintKeysAndValues(sortedCars);
        }

        public static void PrintKeysAndValues(SortedList myList)
        {
            Console.WriteLine("Brand       -> -Origin-");

            for (int i = 0; i < myList.Count; i++)
            {
                Console.WriteLine($"{myList.GetKey(i), -11} -> {myList.GetByIndex(i)}");
            }

            Console.WriteLine();
        }
    }
}
