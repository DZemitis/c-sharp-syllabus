using System;
using System.Collections.Generic;

namespace DragRace
{
    class Program
    {
        /**
 * Take a look at the cars in this solution.
 * 1. Extract common behaviour to an interface called Car, and use it in the all classes.
 * Which methods will be extracted with an empty body, and which can be default?
 * 2. Create two more cars of your own choice.
 * 3. As you see there is a possibility to use some kind of boost in Lexus, extract it to a new interface
          and add that behaviour in one more car.
 * 4. Create one instance of an each car and add them to list.
 * 5. Iterate over the list 10 times, in the 3rd iteration use speed boost on the car if they have one.
 * 6. Print out the car name and speed of the fastest car
 */

        public static void Main(string[] args)
        {
            var fastest = new SortedList<string, int>();
            var cars = new List<ICar>
            {
                new Audi(),
                new Bmw(),
                new Lexus(),
                new Tesla(),
                new Nissan(),
                new VW()
            };

            for (int i = 1; i <= 10; i++)
            {
                foreach (var car in cars)
                {
                    if (i == 1)
                    {
                        car.StartEngine();
                        continue;
                    }

                    if (i == 3)
                    {
                        if (car is IBoostable boostable)
                        {
                            boostable.UseNitrousOxideEngine();
                            continue;
                        }
                    }

                    car.SpeedUp();
                }
            }

            foreach (var car in cars)
            {
                fastest.Add($"{ car.GetType().Name}", int.Parse($"{car.ShowCurrentSpeed()}"));
                Console.WriteLine($"{car.GetType().Name} : {car.ShowCurrentSpeed()}");
            }

            foreach (var car in fastest)
            {
                Console.WriteLine($"{car.Key} : {car.Value}");
            }
        }
    }
}