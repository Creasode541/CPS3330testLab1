// Michael Banko - CPS3330 Midterm SP24
using Xunit;
using CircleOperationsLib;

namespace CircleOperationsLibTest {
    public class UnitTest1 {
        [Fact]
        public void Area_CorrectValue() {
            double radius = 5;
            Circle circle = new Circle(radius);

            double area = circle.Area();

            Assert.Equal(Math.PI * Math.Pow(radius, 2), area);
        }

        [Fact]
        public void CalculatePerimeter_ShouldReturnCorrectValue() {
            double radius = 5;
            Circle circle = new Circle(radius);

            double perimeter = circle.Perimeter();

            Assert.Equal(2 * Math.PI * radius, perimeter);
        }

        [Fact]
        public void CalculateDiameter_ShouldReturnCorrectValue() {
            double radius = 5;
            Circle circle = new Circle(radius);

            double diameter = circle.Diameter();

            Assert.Equal(2 * radius, diameter);
        }
    }
}