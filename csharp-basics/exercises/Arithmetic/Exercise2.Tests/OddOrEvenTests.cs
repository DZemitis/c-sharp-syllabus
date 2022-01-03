using System;
using Exercise_2;
using Xunit;

namespace Exercise2.Tests
{
    public class OddOrEvenTests
    {
        private OddOrEven _target;

        [Fact]
        public void CheckOddOrEven_GivenNumberIsOdd_ShouldReturnOdd()
        {
            //Arrange
            _target = new OddOrEven(5);

            //Act
            _target.CheckOddOrEven();

            //Assert
            Assert.Contains("Odd", _target.CheckOddOrEven());
        }

        [Fact]
        public void CheckOddOrEven_GivenNumberIsEven_ShouldReturnEven()
        {
            //Arrange
            _target = new OddOrEven(4);

            //Act
            _target.CheckOddOrEven();

            //Assert
            Assert.Contains("Even", _target.CheckOddOrEven());
        }

        [Fact]
        public void CheckOddOrEven_ProgramHasToPrintBye_ShouldReturnBye()
        {
            //Arrange
            _target = new OddOrEven(4);

            //Act
            _target.CheckOddOrEven();

            //Assert
            Assert.Contains("bye!", _target.CheckOddOrEven());
        }
    }
}