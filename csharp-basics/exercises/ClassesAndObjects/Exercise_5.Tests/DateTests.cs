using System;
using Xunit;

namespace Exercise_5.Tests
{
    public class DateTests
    {
        private Date _target;

        public DateTests()
        {
            _target = new Date(9, 22, 1989);
        }

        [Fact]
        public void GetMonth_Month9_ShouldGet9()
        {
            //Arrange
            var monthTest = 9;

            //Act
            var mothGiven = _target.Month;

            //Assert
            Assert.Equal(monthTest, mothGiven);
        }

        [Fact]
        public void GetDay_Day22_ShouldGet22()
        {
            //Arrange
            var dayTest = 22;

            //Act
            var dayGiven = _target.Day;

            //Assert
            Assert.Equal(dayTest, dayGiven);
        }

        [Fact]
        public void GetYear_Year1989_ShouldGet1989()
        {
            //Arrange
            var yearTest = 1989;

            //Act
            var yearGiven = _target.Year;

            //Assert
            Assert.Equal(yearTest, yearGiven);
        }

        [Fact]
        public void SetYear_Year2000_ShouldGet2000()
        {
            //Arrange
            var yearTest = 2000;

            //Act
            _target.Year = 2000;
            var yearGiven = _target.Year;

            //Assert
            Assert.Equal(yearTest, yearGiven);
        }

        [Fact]
        public void SetDay_Day30_ShouldGet30()
        {
            //Arrange
            var dayTest = 30;

            //Act
            _target.Day = 30;
            var dayGiven = _target.Day;

            //Assert
            Assert.Equal(dayTest, dayGiven);
        }

        [Fact]
        public void SetMonth_Month12_ShouldGet12()
        {
            //Arrange
            var monthTest = 12;

            //Act
            _target.Month = 12;
            var mothGiven = _target.Month;

            //Assert
            Assert.Equal(monthTest, mothGiven);
        }

        [Fact]
        public void Display_GivenMonthDayYear_ShoulContainMonthDayYear()
        {
            //Arrange
            var dateTest = "9/22/1989";

            //Act
            var displayDate = _target.DisplayDate();

            //Assert
            Assert.Equal($"{dateTest}", displayDate);
        }
    }
}