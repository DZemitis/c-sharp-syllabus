using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;

namespace FlightPlanner
{
    class Program
    {
        private const string Path = "../../flights.txt";
        private static List<string> readText = File.ReadAllLines(Path).ToList();
        private static Dictionary<string, List<string>> _flights = new Dictionary<string, List<string>>();
        private static void Main(string[] args)
        {
            Adddata();
            Console.WriteLine("Hello, Welcome to the Flight Planner!" +
                              "\n Time to plan your round trip!" +
                              "\nTo bring up the list of available Cities to depart from, please pres 1!" +
                              "\nTo Exit the program, press #");
            var userInput = Console.ReadKey().KeyChar.ToString();
            Console.WriteLine();
            if (userInput == "1")
            {
                PrintCityList();
                Console.WriteLine("To chose city please enter the name of it");
                var userCity = Console.ReadLine();
                Console.WriteLine();
                PrintNextCity(userCity);
                Console.WriteLine("Please select write next city from where You would like to depart");
                var nextCity = Console.ReadLine();
                Console.WriteLine();

                while (nextCity != userCity)
                {
                    PrintNextCity(nextCity);
                    Console.WriteLine("Please select write next city from where You would like to depart");
                    nextCity = Console.ReadLine();
                    Console.WriteLine();
                }

                Console.WriteLine($"Congratulations You're home at {userCity}");
            }
            else
            {
                Console.Clear();
                Console.WriteLine("Have a good day!");
            }
        }

        private static void PrintNextCity(string userCity)
        {

            if (_flights.ContainsKey(userCity))
            {
                var value = _flights[userCity];
                foreach (var x in value)
                {
                    Console.WriteLine($"You can fly to {x}");
                }
            }
        }

        private static void PrintCityList()
        {
            foreach (var x in _flights)
            {
                Console.WriteLine(x.Key);
            }
        }

        private static void PrintFullFromTo()
        {
            foreach (var contents in _flights.Keys)
            {
                foreach (var listMember in _flights[contents])
                {
                    Console.WriteLine("From " + contents + " can fly to " + listMember);
                }
            }
        }

        private static void Adddata()
        {
            foreach (var x in readText)
            {
                string[] entries = Regex.Split(x, @" -> ");
                if (_flights.ContainsKey(entries[0]))
                {
                    _flights[entries[0]].Add(entries[1]);
                }
                else
                {
                    _flights.Add($"{entries[0]}", new List<string> { entries[1] });
                }
            }
        }
    }
}
