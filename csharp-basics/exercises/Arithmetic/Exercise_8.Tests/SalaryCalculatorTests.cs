using System;
using System.Threading;
using Xunit;

namespace Exercise_8.Tests
{
    public class SalaryCalculatorTests
    {
        private SalaryCalculator _target;

        public SalaryCalculatorTests()
        {
            var _target = new SalaryCalculator();
        }

        [Fact]
        public void Calculate_Hours40_ReturnBasePay()
        {
            //Arange
            var hours = 40;
            var pay = 8;
            var salary = hours * pay;

            //Act
            var calculatedPay = _target.Calculate(pay, hours);

            //Assert
            Assert.Equal(salary, calculatedPay);
        }
    }
}