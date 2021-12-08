using System;

namespace Exercise_3a
{
    class Program
    {
        static void Main(string[] args)
        {
            Odometer car = new Odometer(100, 65);


            Console.WriteLine("For filling tank");
            for (int i = 0; i < 10; i++)
            {
                car.FillFuel();
                Console.Write(car.ReportCurrentLiters() + " ");
                Console.WriteLine();
            }

            var kmDriven = 0;
            while (car.CurrentLiters > 0)
            {
                Console.WriteLine($"You have driven {kmDriven}Km");
                car.BurnFuel();
                car.FuelLoss();
                car.LimitOfOdometer();
                Console.WriteLine($"Cars Current Mileage is {car.ReportMileage()}");
                Console.WriteLine($"Cars Current Liters is {car.ReportCurrentLiters()}");
                kmDriven++;
            }
        }
    }
}
