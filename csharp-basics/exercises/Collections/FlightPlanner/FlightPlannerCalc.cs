using System.Collections.Generic;

namespace FlightPlanner
{
    public class FlightPlannerCalc
    {
        private Dictionary<string, List<string>> _flights = new Dictionary<string, List<string>>();

        public FlightPlannerCalc(Dictionary<string, List<string>> flights)
        {
            _flights = flights;
        }

        public string PrintNextCity(string userCity)
        {
            var printResult = string.Empty;
            if (_flights.ContainsKey(userCity))
            {
                var value = _flights[userCity];
                foreach (var x in value)
                {
                    printResult += $"You can fly to {x}\n";
                }
            }

            return printResult;
        }

        public string PrintCityList()
        {
            var cityList = string.Empty;
            foreach (var x in _flights)
            {
                cityList += x.Key + "\n";
            }

            return cityList;
        }

        public string PrintFullFromTo()
        {
            var x = string.Empty;
            foreach (var contents in _flights.Keys)
            {
                foreach (var listMember in _flights[contents])
                {
                    x += "From " + contents + " can fly to " + listMember + "\n";
                }
            }

            return x;
        }
    }
}