using System;
using System.Collections.Generic;
using System.Linq;

namespace DragRace
{
    class Program
    {
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
            }

            var fastCar = fastest.FirstOrDefault(x => x.Value == fastest.Values.Max()).Key;
            var carValue = fastest.FirstOrDefault(x => x.Value == fastest.Values.Max()).Value;

            Console.WriteLine($"Fastest car was {fastCar} with speed of {carValue}");
        }
    }
}