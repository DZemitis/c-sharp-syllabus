using Xunit;

namespace Exercise_6.Tests
{
    public class CozaLozaWozaTests
    {
        private CozaLozaWoza _target;

        public CozaLozaWozaTests()
        {
            _target = new CozaLozaWoza();
        }
        [Fact]
        public void PrintsCoza_PrintCozaInsteadOffNumbersModulo3_ShouldReturnCoza()
        {
            //Arrange
            var name = "Coza";
            var numberBy3 = "15";

            //Act
            var result = _target.PrintCozaLozaWoza();

            //Assert
            Assert.Contains(name, result);
            Assert.DoesNotContain(numberBy3, result);
        }

        [Fact]
        public void PrintsWoza_PrintWozaInsteadOffNumbersModulo7_ShouldReturnWoza()
        {
            //Arrange
            var name = "Woza";
            var numberBy7 = "14";

            //Act
            var result = _target.PrintCozaLozaWoza();

            //Assert
            Assert.Contains(name, result);
            Assert.DoesNotContain(numberBy7, result);
        }

        [Fact]
        public void PrintsLoza_PrintLozaInsteadOffNumbersModulo5_ShouldReturnLoza()
        {
            //Arrange
            var name = "Loza";
            var numberBy5 = "20";

            //Act
            var result = _target.PrintCozaLozaWoza();

            //Assert
            Assert.Contains(name, result);
            Assert.DoesNotContain(numberBy5, result);
        }

        [Fact]
        public void PrintsCozaLoza_PrintCozaLozaInsteadOffNumbersModulo5And3_ShouldReturnCozaLoza()
        {
            //Arrange
            var name = "CozaLoza";
            var numberBy5And3 = "30";

            //Act
            var result = _target.PrintCozaLozaWoza();

            //Assert
            Assert.Contains(name, result);
            Assert.DoesNotContain(numberBy5And3, result);
        }

        [Fact]
        public void PrintsWozaLoza_PrintWozaLozaInsteadOffNumbersModulo7And5_ShouldReturnWozaLoza()
        {
            //Arrange
            var name = "WozaLoza";
            var numberBy7And5 = "35";

            //Act
            var result = _target.PrintCozaLozaWoza();

            //Assert
            Assert.Contains(name, result);
            Assert.DoesNotContain(numberBy7And5, result);
        }

        [Fact]
        public void CozaWoza_PrintCozaWozaInsteadOffNumbersModulo7And3_ShouldReturnCozaWoza()
        {
            //Arrange
            var name = "CozaWoza";
            var numberBy7And3 = "21";

            //Act
            var result = _target.PrintCozaLozaWoza();

            //Assert
            Assert.Contains(name, result);
            Assert.DoesNotContain(numberBy7And3, result);
        }
    }
}