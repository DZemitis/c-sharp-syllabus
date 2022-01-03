using Xunit;

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
        public void CalcFinalPosition_FinalPositionCheck_ShouldMatch()
        {
            //Act
            var finalPosition = _target.CalcFinalPosition();

            //Assert
            Assert.Equal(-490.5, finalPosition);
        }
    }
}