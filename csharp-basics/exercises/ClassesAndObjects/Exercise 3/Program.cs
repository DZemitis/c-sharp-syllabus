using System;
using System.Linq.Expressions;

namespace Exercise_3
{
    class Program
    {
        static void Main(string[] args)

        {
            int desiredDistance = int.Parse(Console.ReadLine());
            
            Car car1 = new Car("Audi", 100, 60);
            int desiredLiters = int.Parse(Console.ReadLine());
            
            while (FuelGauge.Currentliters < desiredLiters)
            {
                car1.CarFills();
                Console.WriteLine(FuelGauge.Currentliters);
                Console.WriteLine(Odometer.CurrentMileage);
            }

            while (Odometer.CurrentMileage < Odometer.CurrentMileage + desiredDistance)
            {
                car1.CarMoves();
                Console.WriteLine(FuelGauge.Currentliters);
                Console.WriteLine(Odometer.CurrentMileage);
                if (Odometer.CurrentMileage == Odometer.CurrentMileage + desiredDistance)
                {
                    car1.CarIsMoving = false;
                    break;
                }
            }
        }
    }
}
