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

            var sortedCars = new Dictionary<string, string>();
            sortedCars.Add("Audi", "Germany");
            sortedCars.Add("BMW", "Germany");
            sortedCars.Add("Honda", "Japan");
            sortedCars.Add("Mercedes", "Germany");
            sortedCars.Add("VolksWagen", "Germany");
            sortedCars.Add("Tesla", "USA");

            foreach (var x in sortedCars)
            {
                Console.WriteLine($"{x.Key, -11} -> {x.Value}");
            }
        }
    }
}
