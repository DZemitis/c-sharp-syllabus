using System;
using Xunit;
using GravityCalculator;
using Xunit.Abstractions;

namespace GravityCalculator.Tests
{
    public class GravityCalTests
    {
        private GravityCal _target;

        public GravityCalTests()
        {
            _target = new GravityCal();
        }

        [Fact]
        public void CalculateFinalPosition_FinalPositionCheck_ShouldReturnDouble()
        {
            //Act
            var finalPosition = _target.CalcFinalPosition();

            //Assert
            Assert.Equal(-490.5, finalPosition);
        }
    }
}