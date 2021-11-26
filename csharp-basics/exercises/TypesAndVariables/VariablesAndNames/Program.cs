using System;

namespace VariablesAndNames
{
    class Program
    {
        private static void Main(string[] args)
        {
            int cars = 100;
            int drivers = 28;
            double passengers = 90;
            double carsDriven = drivers;
            int carsNotDriven = cars - drivers;
            int seatsInACar = 4;
            int carpoolCapacity = drivers * seatsInACar;
            double averagePassengersPerCar = System.Math.Round((passengers / carsDriven), 2);
            
            Console.WriteLine("There are " + cars + " cars available.");
            Console.WriteLine("There are only " + drivers + " drivers available.");
            Console.WriteLine("There will be " + carsNotDriven + " empty cars today.");
            Console.WriteLine("We can transport " + carpoolCapacity + " people today.");
            Console.WriteLine("We have " + passengers + " to carpool today.");
            Console.WriteLine("We need to put about " + averagePassengersPerCar + " in each car.");
            Console.ReadKey();
        }
    }
}