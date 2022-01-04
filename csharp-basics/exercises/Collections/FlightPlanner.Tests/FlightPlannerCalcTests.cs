using System;
using System.Collections.Generic;
using Xunit;

namespace FlightPlanner.Tests
{
    public class FlightPlannerCalcTests
    {
        private FlightPlannerCalc _target;

        public FlightPlannerCalcTests()
        {
            var Flights = new Dictionary<string, List<string>>
            {
                {"Denver", new List<string> {"LA", "NY"}},
                {"LA", new List<string> {"Denver", "NY"}},
                {"NY", new List<string> {"Denver", "LA"}}
            };
            _target = new FlightPlannerCalc(Flights);
        }

        [Fact]
        public void PrintCityList_RangeOfCityNames_ShouldContain()
        {
            //Arrange
            var city1 = "LA";
            var city2 = "Denver";
            var city3 = "NY";

            //Act
            var fulllList = _target.PrintCityList();

            //Assert
            Assert.Contains(city1, fulllList);
            Assert.Contains(city2, fulllList);
            Assert.Contains(city3, fulllList);
        }

        [Fact]
        public void PrintNextCity_RangeOfCityNames_ShouldContain()
        {
            //Arrange
            var city1 = "LA";
            var city2 = "Denver";
            var userCity = "NY";

            //Act
            var nextCityList = _target.PrintNextCity(userCity);

            //Assert
            Assert.Contains(city1, nextCityList);
            Assert.Contains(city2, nextCityList);
        }

        [Fact]
        public void PrintNextCity_RangeOfCityNames_ShouldNotContainOrigin()
        {
            //Arrange
            var userCity = "NY";

            //Act
            var nextCityList = _target.PrintNextCity(userCity);

            //Assert
            Assert.DoesNotContain(userCity, nextCityList);
        }

        [Fact]
        public void PrintFullFromTo_RangeOfCityNames_ShouldContain()
        {
            //Arrange
            var city1 = "LA";
            var city2 = "Denver";
            var city3 = "NY";

            //Act
            var printFromTo = _target.PrintFullFromTo();

            //Assert
            Assert.Contains(city1, printFromTo);
            Assert.Contains(city2, printFromTo);
            Assert.Contains(city3, printFromTo);
        }
    }
}