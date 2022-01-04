using System.Collections.Generic;
using Xunit;

namespace Hierarchy.Tests
{
    public class AnimalTests
    {
        private readonly List<Food> _foodTarget;
        private readonly List<Animal> _target;

        public AnimalTests()
        {
            _target = new List<Animal>()
                {new Cat("Tom", "Cat", 5.5, 2, "Home", "British"),
                 new Tiger("Muris", "Tiger", 190, 20, "Africa"),
                 new Mouse("Mickey", "Mouse", 1.2, 1, "Cave"),
                 new Zebra("Phony", "Zebra", 120, 10, "Africa")
                };
            _foodTarget = new List<Food>() {new Meat(10), new Vegetable(10)};
        }
        [Fact]
        public void MakeSound_GivenSoundFromAllMammals_ShouldContain()
        {
            //Arrange
            var catSay = "Murrrrr...";
            var mouseSay = "Pii... Pii...";
            var tigerSay = "ROAAR!!!";
            var zebraSay = "Iah iah, iah iah.";
            
            //Act
            var actualCatSay = _target[0].MakeSound();
            var actualMouseSay = _target[2].MakeSound();
            var actualTigerSay = _target[1].MakeSound();
            var actualZebraSay = _target[3].MakeSound();

            //Assert
            Assert.Contains(catSay, actualCatSay);
            Assert.Contains(mouseSay, actualMouseSay);
            Assert.Contains(tigerSay, actualTigerSay);
            Assert.Contains(zebraSay, actualZebraSay);
        }

        [Fact]
        public void EatFood_CatEat10Meat_ShouldContain12AsFoodEaten()
        {
            //Arrange
            var catFoodEaten = "12";

            //Act
            var catEat = _target[0].EatFood(_foodTarget[0]);

            //Assert
            Assert.Contains(catFoodEaten, catEat);
        }

        [Fact] public void EatFood_TigerEat10Vegetables_ShouldContainMessage()
        {
            //Arrange
            var tigerMessage = "are not eating that type of food!";

            //Act
            var tigerEat = _target[1].EatFood(_foodTarget[1]);

            //Assert
            Assert.Contains(tigerMessage, tigerEat);
        }
        
        [Fact] public void ToString_TigerToString_ShouldContain()
        {
            //Arrange
            var tigerName = "Muris";

            //Act
            var tigerToString = _target[1].ToString();

            //Assert
            Assert.Contains(tigerName, tigerToString);
        }
    }
}
