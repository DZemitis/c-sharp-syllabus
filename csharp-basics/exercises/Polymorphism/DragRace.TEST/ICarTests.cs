using Xunit;

namespace DragRace.TEST
{
    public class ICarTests
    {
        private readonly ICar _target;

        public ICarTests()
        {
            _target = new Nissan();
        }

        [Fact]
        public void SpeedUp_SpeedUp10_ShouldBeEqual()
        {
            //Arrange
            var speedUp = 10;

            //Act
            var givenSpeedUp = _target.SpeedUp();

            //Assert
            Assert.Equal(speedUp, givenSpeedUp);
        }

        [Fact]
        public void SlowDown_SlowDown10_ShouldBeEqual()
        {
            //Arrange
            var slowDown = -10;

            //Act
            var givenSlowDown = _target.SlowDown();

            //Assert
            Assert.Equal(slowDown, givenSlowDown);
        }

        [Fact]
        public void ShowCurrentSpeed_CurrentSpeed0_ShouldContain()
        {
            //Arrange
            var currentSpeed = "0";

            //Act
            var showCurrentSpeed = _target.ShowCurrentSpeed();

            //Assert
            Assert.Contains(currentSpeed, showCurrentSpeed);
        }

        [Fact]
        public void StartEngine_StartEngineSoundString_ShouldContainSoundString()
        {
            //Arrange
            var engineSound = "Brum.. Brum..";

            //Act
            var startEngineSoundString = _target.StartEngine();

            //Assert
            Assert.Contains(engineSound, startEngineSoundString);
        }
    }
}