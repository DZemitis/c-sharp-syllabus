using System;
using Xunit;

namespace DragRace.TEST
{
    public class IBoostableTests
    {
        private IBoostable _nissan;
        private IBoostable _lexus;

        public IBoostableTests()
        {
            _nissan = new Nissan();
            _lexus = new Lexus();
        }

        [Fact]
        public void UseNitrousOxideEngine_UseNitro25_ShouldBeEqual()
        {
            //Assert
            Assert.Equal(25, _lexus.UseNitrousOxideEngine());
            Assert.Equal(25, _nissan.UseNitrousOxideEngine());
        }
    }
}