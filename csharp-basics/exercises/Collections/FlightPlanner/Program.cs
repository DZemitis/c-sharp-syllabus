using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;

namespace FlightPlanner
{
    class Program
    {
        public static List<Flights> flights = new List<Flights>();
        private const string Path = "../../flights.txt";
        private static List<string> readText = File.ReadAllLines(Path).ToList();

        private static void Main(string[] args)
        {
            AddData();
            Console.WriteLine("Hello, Welcome to the Flight Planner!" +
                              "\nTo bring up the list of available Cities to depart from, please pres 1!" +
                              "\nTo Exit the program, press #");
            var userInput = Console.ReadKey().KeyChar.ToString();
            if (userInput == "1")
            {
                GetCityList();
            }
            else 
            {
                Console.Clear();
                Console.WriteLine("Come again");
            }
            
        }

        private static void AddData()
        {
            foreach (var x in readText)
            {
                string[] entries = Regex.Split(x, @" -> ");
                Flights newRoute = new Flights(entries[0], entries[1]);
                flights.Add(newRoute);
            }
        }

        private static void GetCityList()
        {
            var cities = new List<string>();
            foreach (var x in flights)
            {
                cities.Add(x.ListOfCities());
            }

            List<string> distinct = cities.Distinct().ToList();
            List<string> distinctList = distinct.Distinct().ToList();
            foreach (var x in distinctList)
            {
                Console.WriteLine(x);
            }
        }
    }
}
