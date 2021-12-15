using System;
using System.Collections.Generic;

namespace Hierarchy
{
    class Program
    {
        static void Main(string[] args)
        {
            var food = new List<Food>()
            {
                new Vegetable(4),
                new Vegetable(5),
                new Meat(10)
            };
            
            
            var animals = new List<Animal>()
            {
                new Cat("Gray", "Cat", 1.1, 4, "Home", "Persian"),
                new Tiger("Typcho", "Tiger", 167.7, 4, "Asia")
            };
            foreach (var x in animals)
            {
                Console.WriteLine(x.DisplayAnimal());
                Console.WriteLine(x.MakeSound());
                Console.WriteLine($"{food[0]}");
                Console.WriteLine(x.EatFood(food[0]));
            }

            Console.WriteLine("End");
            Console.WriteLine($"{animals[0].ToString()}, {animals[1].ToString()}");
        }
    }
}