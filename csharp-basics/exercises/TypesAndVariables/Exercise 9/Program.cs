using System;

namespace Exercise_9
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter distance by meters!");
            var meters = double.Parse(Console.ReadLine());
            var kilometers = meters / 1000;
            var miles = meters / 1609;
           
            Console.WriteLine("Enter time was taken in hours!");
            var hours = double.Parse(Console.ReadLine());
            var minutes = hours * 60;
            var seconds = minutes * 60;

            var milesPerHour = Math.Round((miles / hours), 2);
            var kmToHour = Math.Round((kilometers / hours), 2);
            var metersPerSecond = Math.Round((meters / seconds), 2);

            Console.WriteLine($"Your speed in meters is {metersPerSecond} m/s");
            Console.WriteLine($"Your speed in kilometers is {kmToHour} km/h");
            Console.WriteLine($"Your speed in miles is {milesPerHour} mph");
        }
    }
}