using System;
using ConsoleApp8;
using Xunit;

namespace Exercise1Tests
{
    public class Magic15Tests
    {
        private Magic15 _target;

        [Fact]
        public void CheckIf15_OneOfNumbersIs15_ShouldReturnTrue()
        {
            // Arrange
            _target = new Magic15(4, 15);

            // Assert
            Assert.True(_target.CheckIf15());
        }

        [Fact]
        public void CheckIf15_NumbersSumIs15_ShouldReturnTrue()
        {
            // Arrange
            _target = new Magic15(2, 13);

            // Assert
            Assert.True(_target.CheckIf15());
        }

        [Fact]
        public void CheckIf15_SumOrNumberNot15_ShouldReturnFalse()
        {
            // Arrange
            _target = new Magic15(13, 13);

            // Assert
            Assert.False(_target.CheckIf15());
        }

        [Fact]
        public void CheckIf15_NumbersDifferenceIs15_ShouldReturnTrue()
        {
            // Arrange
            _target = new Magic15(40, 25);

            // Assert
            Assert.True(_target.CheckIf15());
        }
    }
}