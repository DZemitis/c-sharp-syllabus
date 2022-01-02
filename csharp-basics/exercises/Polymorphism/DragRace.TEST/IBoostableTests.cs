using System;
using Xunit;

namespace DragRace.TEST
{
    public class IBoostableTests
    {
        private IBoostable _target;

        public IBoostableTests()
        {
            _target = new Nissan();
        }

        [Fact]
        public void UseNitrousOxideEngine_UseNitro25_ShouldBeEqual()
        {
            //Arrange
            var useNitroOxideEngine = 25;

            //Act
            var givenNitroOxideValue = _target.UseNitrousOxideEngine();

            //Assert
            Assert.Equal(useNitroOxideEngine, givenNitroOxideValue);
        }
    }
}