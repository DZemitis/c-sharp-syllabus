using System;
using System.Collections.Generic;
using Xunit;

namespace Hierarchy.Tests
{
    public class FoodTests
    {
        private List<Food> _foodTarget;

        public FoodTests()
        {
            _foodTarget = new List<Food>() {new Meat(10), new Vegetable(10)};
        }

        [Fact]
        public void ToString_Meat10_ShouldContain()
        {
            //Arrange
            var foodToString = $"Meat 10";
            
            //Act
            var foodGivenNameQTY = _foodTarget[0].ToString();

            //Assert
            Assert.Contains(foodToString, foodGivenNameQTY);
        }
    }
}