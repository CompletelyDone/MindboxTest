using Model;

namespace Test
{
    public class GeometryTests
    {
        [Fact]
        public void TestTriangleGetSquare()
        {
            Triangle triangle = new Triangle(3, 4, 5);

            double expectedResult = 6;

            Assert.Equal(expectedResult, triangle.GetArea());
        }
        [Fact]
        public void TestTriangleIsRectangular()
        {
            Triangle triangle = new Triangle(3, 4, 5);

            Assert.True(triangle.IsRectangular());
        }
        [Fact]
        public void TestTriangleIsValid()
        {
            Assert.Throws(typeof(ArgumentException), () =>
                {
                    Triangle triangle = new Triangle(3, 4, 7);
                });

        }
        [Fact]
        public void TestCircleGetSquare()
        {
            double radius = 5;

            Circle circle = new Circle(radius);

            double expectedResult = Math.PI * Math.Pow(radius, 2);

            Assert.Equal(expectedResult, circle.GetArea());
        }

    }
}