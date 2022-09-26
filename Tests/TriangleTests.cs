using FiguresLibrary;
using Xunit;

namespace Tests
{
    public class TriangleTests
    {
        [Fact]
        public void AreaTest()
        {
            //Arrange
            int a = 3;
            int b = 4;
            int c = 5;
            double areaExpected = 6;

            //Act
            Triangle triangle = new(a,b,c);
            double areaActual = triangle.Area;

            //Assert
            Assert.True(areaExpected == areaActual, "Bad result...");
        }

        [Fact]
        public void PerimeterTest()
        {
            //Arrange
            int a = 3;
            int b = 4;
            int c = 5;
            double perimeterExpected = 12;

            //Act
            Triangle triangle = new(a, b, c);
            double perimeterActual = triangle.Perimeter;

            //Assert
            Assert.True(perimeterExpected == perimeterActual, "Bad result...");
        }

        [Fact]
        public void IsIsoscelesTest()
        {
            //Arrange
            int a = 3;
            int b = 4;
            int c = 5;
            bool isIsoscelesExpected = true;

            //Act
            Triangle triangle = new(a, b, c);
            bool isIsoscelesActual = triangle.IsIsosceles;

            //Assert
            Assert.True(isIsoscelesExpected == isIsoscelesActual, "Bad result...");
        }
    }
}
