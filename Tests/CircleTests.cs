using FiguresLibrary;
using Xunit;

namespace Tests
{   
    public class CircleTests
    {
        [Fact]
        public void AreaTest()
        {
            //Arrange
            int radius = 3;
            double areaExpected = 28.274333882308138;

            //Act
            Circle circle = new(radius);
            double areaActual = circle.Area;

            //Assert
            Assert.True(areaExpected == areaActual, "Bad result...");
        }

        [Fact]
        public void PerimeterTest()
        {
            //Arrange
            int radius = 3;
            double perimeterExpected = 18.849555921538759430775860299677;

            //Act
            Circle circle = new(radius);
            double perimeterActual = circle.Perimeter;

            //Assert
            Assert.True(perimeterExpected == perimeterActual, "Bad result...");
        }
    }
}