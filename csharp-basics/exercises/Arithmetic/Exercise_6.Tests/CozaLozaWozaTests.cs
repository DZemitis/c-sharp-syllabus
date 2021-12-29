using System;
using System.Security.Cryptography;
using Xunit;
using Exercise_6;

namespace Exercise_6.Tests
{
    public class CozaLozaWozaTests
    {
        private CozaLozaWoza _target;

        [Fact]
        public void PrintsCoza_PrintCozaInsteadOffNumbersModulo3_ShouldReturnCoza()
        {
            //Arrange
            _target = new CozaLozaWoza();
            var name = "Coza";
            var numberby3 = "15";

            //Act
            var result = _target.PrintCozaLozaWoza();

            //Assert
            Assert.Contains(name, result);
            Assert.DoesNotContain(numberby3, result);
        }

        [Fact]
        public void PrintsWoza_PrintWozaInsteadOffNumbersModulo7_ShouldReturnWoza()
        {
            //Arrange
            _target = new CozaLozaWoza();
            var name = "Woza";
            var numberby7 = "14";

            //Act
            var result = _target.PrintCozaLozaWoza();

            //Assert
            Assert.Contains(name, result);
            Assert.DoesNotContain(numberby7, result);
        }

        [Fact]
        public void PrintsLoza_PrintLozaInsteadOffNumbersModulo5_ShouldReturnLoza()
        {
            //Arrange
            _target = new CozaLozaWoza();
            var name = "Loza";
            var numberby5 = "20";

            //Act
            var result = _target.PrintCozaLozaWoza();

            //Assert
            Assert.Contains(name, result);
            Assert.DoesNotContain(numberby5, result);
        }

        [Fact]
        public void PrintsCozaLoza_PrintCozaLozaInsteadOffNumbersModulo5And3_ShouldReturnCozaLoza()
        {
            //Arrange
            _target = new CozaLozaWoza();
            var name = "CozaLoza";
            var numberby5And3 = "30";

            //Act
            var result = _target.PrintCozaLozaWoza();

            //Assert
            Assert.Contains(name, result);
            Assert.DoesNotContain(numberby5And3, result);
        }

        [Fact]
        public void PrintsWozaLoza_PrintWozaLozaInsteadOffNumbersModulo7And5_ShouldReturnWozaLoza()
        {
            //Arrange
            _target = new CozaLozaWoza();
            var name = "WozaLoza";
            var numberby7And5 = "35";

            //Act
            var result = _target.PrintCozaLozaWoza();

            //Assert
            Assert.Contains(name, result);
            Assert.DoesNotContain(numberby7And5, result);
        }

        [Fact]
        public void CozaWoza_PrintCozaWozaInsteadOffNumbersModulo7And3_ShouldReturnCozaWoza()
        {
            //Arrange
            _target = new CozaLozaWoza();
            var name = "CozaWoza";
            var numberby7And3 = "21";

            //Act
            var result = _target.PrintCozaLozaWoza();

            //Assert
            Assert.Contains(name, result);
            Assert.DoesNotContain(numberby7And3, result);
        }
    }
}