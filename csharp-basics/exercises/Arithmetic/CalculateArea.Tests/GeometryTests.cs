using System;
using Xunit;

namespace CalculateArea.Tests
{
    public class GeometryTests
    {
        private Geometry _target;

        [Fact]
        public void AreaOfCircle_Radius3_ShouldReturnArea28Point27()
        {
            //Arrange
            var radius = 3;
            var circleArea = 28.27;

            //Act
            var calculatedRadius = Geometry.AreaOfCircle(radius);

            //Assert
            Assert.Equal(circleArea, calculatedRadius);
        }

        [Fact]
        public void AreaOfRectangle_Width3Length5_ShouldReturnArea15()
        {
            //Arrange
            var width = 3;
            var length = 5;
            var rectangleArea = 15;

            //Act
            var calculatedRectangleArea = Geometry.AreaOfRectangle(length, width);

            //Assert
            Assert.Equal(rectangleArea, calculatedRectangleArea);
        }

        [Fact]
        public void AreaOfTriangle_Ground3H5_ShouldReturnArea7Point5()
        {
            //Arrange
            var ground = 3;
            var h = 5;
            var triangleArea = 7.5;

            //Act
            var calculatedTriangleArea = Geometry.AreaOfTriangle(ground, h);

            //Assert
            Assert.Equal(triangleArea, calculatedTriangleArea);
        }
    }
}