using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text.RegularExpressions;

namespace FlightPlanner
{
    public class Program
    {
        private const string Path = "../../flights.txt";
        private static List<string> readText = File.ReadAllLines(Path).ToList();
        private static Dictionary<string, List<string>> _flights = new Dictionary<string, List<string>>();

        private static void Main(string[] args)
        {
            AddData();
            var flightPlannerCalc = new FlightPlannerCalc(_flights.ToDictionary(entry => entry.Key,
                entry => entry.Value));

            Console.WriteLine("Hello, Welcome to the Flight Planner!" +
                              "\n Time to plan your round trip!" +
                              "\nTo bring up the list of available Cities to depart from, please pres 1!" +
                              "\nTo Exit the program, press #");
            var userInput = Console.ReadKey().KeyChar.ToString();
            Console.WriteLine();
            if (userInput == "1")
            {
                Console.WriteLine(flightPlannerCalc.PrintCityList());
                Console.WriteLine("To chose city please enter the name of it");
                var userCity = Console.ReadLine();
                Console.WriteLine();
                Console.WriteLine(flightPlannerCalc.PrintNextCity(userCity));
                Console.WriteLine("Please select write next city from where You would like to depart");
                var nextCity = Console.ReadLine();
                Console.WriteLine();

                while (nextCity != userCity)
                {
                    Console.WriteLine(flightPlannerCalc.PrintNextCity(nextCity));
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

        private static void AddData()
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
                    _flights.Add($"{entries[0]}", new List<string> {entries[1]});
                }
            }
        }
    }
}