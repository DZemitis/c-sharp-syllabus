using System;
using Xunit;

namespace Exercise_8.Tests
{
    public class SalaryCalculatorTests
    {
        private SalaryCalculator _target;

        public SalaryCalculatorTests()
        {
            _target = new SalaryCalculator();
        }

        [Fact]
        public void SalaryCalc_Hours40Pay8_ShouldBeEqual()
        {
            //Arange
            var hours = 40;
            var pay = 8;
            var salary = hours * pay;

            //Act
            var calculatedPay = _target.SalaryCalc(8, 40);

            //Assert
            Assert.Equal(salary, calculatedPay);
        }

        [Fact]
        public void SalaryCalc_Hours61Pay8_ReturnError()
        {
            //Arrange
            var errorMessage = "Error, not possible";

            //Act
            var exception = Assert.Throws<Exception>(() => _target.SalaryCalc(8,61));

            //Assert
            Assert.Equal(errorMessage, exception.Message);
        }

        [Fact]
        public void SalaryCalc_Hours40Pay7_ReturnError()
        {
            //Arrange
            var errorMessage = "Error, not possible";

            //Act
            var exception = Assert.Throws<Exception>(() => _target.SalaryCalc(7, 40));

            //Assert
            Assert.Equal(errorMessage, exception.Message);
        }

        [Fact]
        public void SalaryCalc_Hours45Pay8_ShouldBeEqual()
        {
            //Arange
            var hours = 45;
            var pay = 8;
            decimal salary =  Math.Round(pay * 40 + (decimal)1.5 * pay * (hours - 40), 2);

            //Act
            var calculatedPay = _target.SalaryCalc(8, 45);

            //Assert
            Assert.Equal(salary, calculatedPay);
        }
    }
}