using System;
using System.Collections.Generic;

namespace Exercise_7
{
    public class DogTests
    {
        public static void Main()
        {
            var Max = new Dog("Max", "male");
            var Rocky = new Dog("Rocky", "male");
            var Sparky = new Dog("Sparky", "male");
            var Buster = new Dog("Buster", "male");
            var Sam = new Dog("Sam", "male");
            var Lady = new Dog("Lady", "female");
            var Molly = new Dog("Molly", "female");
            var Coco = new Dog("Coco", "female");
            Max.Mother = "Lady";
            Max.Father = "Rocky";
            Coco.Mother = "Molly";
            Coco.Father = "Buster";
            Rocky.Mother = "Molly";
            Rocky.Father = "Sam";
            Buster.Mother = "Lady";
            Buster.Father = "Sparky";
            var DogTest = new List<Dog>
            {
                Max,
                Rocky,
                Sparky,
                Buster,
                Sam,
                Lady,
                Molly,
                Coco
            };

            foreach (var dog in DogTest)
            {
                Console.WriteLine($"{dog.fathersName()}");
                Console.WriteLine();
            }
            Console.WriteLine($"{Coco.SameMother(Rocky)}" + " " + Coco.HasSameMother(Coco, Rocky));
        }
    }
}

