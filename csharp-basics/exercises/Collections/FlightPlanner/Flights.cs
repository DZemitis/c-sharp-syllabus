using System;
using System.Collections.Generic;
using System.Linq;

namespace FlightPlanner
{
   public class Flights
    {
        public Flights(string beginning, string destination)
        {
            Beginning = beginning;
            Destination = destination;
        }


        public string Beginning { get; set; }
        public string Destination { get; set; }

        public string ListOfCities()
        {
            return $"{Beginning}";
        }
        public string DisplayFlights()
        {
            return $"From {Beginning} to {Destination}";
        }
        public override string ToString()
        {
            return $"{Beginning}";
        }
    }
}