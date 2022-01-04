using System.Collections.Generic;
using Xunit;

namespace DragRace.TEST
{
    public class ICarTests
    {
        private readonly ICar _target;
        private ICar _nissan;
        private ICar _bmw;
        private ICar _audi;
        private ICar _lexus;
        private ICar _tesla;
        private ICar _vw;
        
        

        public ICarTests()
        {
            _nissan = new Nissan();
            _bmw = new Bmw();
            _audi = new Audi();
            _lexus = new Lexus();
            _tesla = new Tesla();
            _vw = new VW();
        }
        
        [Fact]
        public void SlowDown_SlowDownCars_ShouldBeEqual()
        {
            //Assert
            Assert.Equal(-10, _audi.SlowDown());
            Assert.Equal(-10, _bmw.SlowDown());
            Assert.Equal(-10, _lexus.SlowDown());
            Assert.Equal(-10, _nissan.SlowDown());
            Assert.Equal(-15, _tesla.SlowDown());
            Assert.Equal(-8, _vw.SlowDown());
        }

        [Fact]
        public void ShowCurrentSpeed_CurrentSpeed0_ShouldContain()
        {
            //Assert
            Assert.Contains("0", _audi.ShowCurrentSpeed());
            Assert.Contains("0", _bmw.ShowCurrentSpeed());
            Assert.Contains("0", _lexus.ShowCurrentSpeed());
            Assert.Contains("0", _nissan.ShowCurrentSpeed());
            Assert.Contains("0", _tesla.ShowCurrentSpeed());
            Assert.Contains("0", _vw.ShowCurrentSpeed());
        }

        [Fact]
        public void StartEngine_StartEngineSoundString_ShouldContainSoundString()
        {
            //Assert
            Assert.Contains("Rrrrrrr.....", _audi.StartEngine());
            Assert.Contains("Rrrrrrr.....", _bmw.StartEngine());
            Assert.Contains("Rrrrrrr.....", _lexus.StartEngine());
            Assert.Contains("Brum.. Brum..", _nissan.StartEngine());
            Assert.Contains("-- silence ---", _tesla.StartEngine());
            Assert.Contains("Puk.. Puk..", _vw.StartEngine());
        }
        
        [Fact]
        public void SpeedUp_SpeedUpCars_ShouldBeEqual()
        {
            //Assert
            Assert.Equal(10, _audi.SpeedUp());
            Assert.Equal(10, _bmw.SpeedUp());
            Assert.Equal(10, _lexus.SpeedUp());
            Assert.Equal(10, _nissan.SpeedUp());
            Assert.Equal(15, _tesla.SpeedUp());
            Assert.Equal(8, _vw.SpeedUp());
        }
    }
}