using System;

namespace Exercise_3a
{
    class Program
    {
        static void Main(string[] args)
        {
            FuelGauge liters = new FuelGauge(65);
            Odometer car = new Odometer(100, liters);


            Console.WriteLine("For filling tank");
            for (int i = 0; i < 10; i++)
            {
                liters.FillFuel();
                Console.Write(liters.ReportCurrentLiters() + " ");
                Console.WriteLine();
            }

            var kmDriven = 0;
            while (liters.CurrentLiters > 0)
            {
                Console.WriteLine($"You have driven {kmDriven}Km");
                car.BurnFuel();
                car.LimitOfOdometer();
                Console.WriteLine($"Cars Current Mileage is {car.ReportMileage()}");
                Console.WriteLine($"Cars Current Liters is {liters.ReportCurrentLiters()}");
                kmDriven++;
            }
        }
    }
}