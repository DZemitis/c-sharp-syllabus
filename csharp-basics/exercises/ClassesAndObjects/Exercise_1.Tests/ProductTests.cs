using System;
using Xunit;

namespace Exercise_1.Tests
{
    public class ProductTests
    {
        private Product _target;

        public ProductTests()
        {
            _target = new Product("Iphone", 250.00, 5);
        }

        [Fact]
        public void GetPrice_Get250_ShouldReturn250()
        {
            //Arrange
            var priceGiven = 250.00;

            //Act
            var productPrice = _target.Price;

            //Assert
            Assert.Equal(priceGiven, productPrice);
        }

        [Fact]
        public void GetAmount_Get5_ShouldReturn250()
        {
            //Arrange
            var amount = 5;

            //Act
            var productAmount = _target.Amount;

            //Assert
            Assert.Equal(amount, productAmount);
        }

        [Fact]
        public void PrintProduct_PrintNameAmountPrice_ShouldPass()
        {
            //Arrange
            var amount = 5;
            var price = 250.00;
            var name = "Iphone";

            //Act
            var printedProduct = _target.PrintProduct();

            //Assert
            Assert.Contains($"{amount}", printedProduct);
            Assert.Contains($"{price}", printedProduct);
            Assert.Contains(name, printedProduct);
        }

        [Fact]
        public void SetPrice_Price25_ShouldReturn25()
        {
            //Arrange
            var newPrice = 25;

            //Act
            _target.Price = 25;
            var productPrice = _target.Price;

            //Assert
            Assert.Equal(newPrice, productPrice);
        }

        [Fact]
        public void SetAmount_Amount25_ShouldReturn25()
        {
            //Arrange
            var newAmount = 25;

            //Act
            _target.Amount = 25;
            var productAmount = _target.Amount;

            //Assert
            Assert.Equal(newAmount, productAmount);
        }
    }
}