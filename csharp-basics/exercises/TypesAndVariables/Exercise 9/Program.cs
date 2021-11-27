using System;
using System.Transactions;

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
            
            Console.WriteLine("Enter hours taken!");
            var inputHours = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter minutes taken!");
            var inputMinutes = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter seconds taken!");
            var inputSeconds = double.Parse(Console.ReadLine());
            var inHours = Math.Round(inputHours + (inputMinutes / 60) + (inputSeconds / 3600));
            var inMinutes = Math.Round((inputHours * 60) + inputMinutes + (inputSeconds / 60));
            var inSeconds = Math.Round((inputMinutes * 60) + inputSeconds + (inHours * 3600));

            var milesPerHour = Math.Round((miles / inHours), 3);
            var kmToHour = Math.Round((kilometers / inHours), 3);
            var metersPerSecond = Math.Round((meters / inSeconds), 3);

            Console.WriteLine($"Your speed in meters is {metersPerSecond} m/s");
            Console.WriteLine($"Your speed in kilometers is {kmToHour} km/h");
            Console.WriteLine($"Your speed in miles is {milesPerHour} mph");
        }
    }
}
