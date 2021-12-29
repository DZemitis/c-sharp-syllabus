using System;
using ConsoleApp8;
using Xunit;

namespace Exercise1Tests
{
    public class Magic15Tests
    {
        private Magic15 _target;

        [Fact]
        public void NumberIs15_OneOfNumbersIs15_ShouldReturnTrue()
        {
            // Arrange
            _target = new Magic15(0, 15);

            // Assert
            Assert.True(_target.CheckIfSumOrNumberIs15());
        }

        [Fact]
        public void SumIs15_NumbersSumIs15_ShouldReturnTrue()
        {
            // Arrange
            _target = new Magic15(2, 13);

            // Assert
            Assert.True(_target.CheckIfSumOrNumberIs15());
        }

        [Fact]
        public void IsNot15_SumOrNumberNot15_ShouldReturnFalse()
        {
            // Arrange
            _target = new Magic15(13, 13);

            // Assert
            Assert.False(_target.CheckIfSumOrNumberIs15());
        }

        [Fact]
        public void DifferenceIs15_NumbersDifferenceIs15_ShouldReturnTrue()
        {
            // Arrange
            _target = new Magic15(30, 15);

            // Assert
            Assert.True(_target.CheckIfSumOrNumberIs15());
        }
    }
}