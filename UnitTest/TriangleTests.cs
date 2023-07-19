using Microsoft.VisualStudio.TestTools.UnitTesting;
using SquareShape;

namespace UnitTest
{
    [TestClass]
    public class TriangleTests
    {
        [TestMethod]
        public void Square_2_3_4_Return_2_905()
        {
            ISquare triangle = new Triangle(2, 3, 4);
            var expected = 2.905;
            var result = triangle.Square();

            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void Square_5_2_4_Return_3_8()
        {
            ISquare triangle = new Triangle(5, 2, 4);
            var expected = 3.8;
            var result = triangle.Square();

            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void isNotStraightTriangle()
        {
            IStraightTriangle triangle = new Triangle(2, 3, 4);
            var result = triangle.isStraightTriangle();

            Assert.IsFalse(result);
        }
    }
}
