using Microsoft.VisualStudio.TestTools.UnitTesting;
using SquareShape;

namespace UnitTest
{
    [TestClass]
    public class CircleTests
    {
        [TestMethod]
        public void Square_5_Return_78_5()
        {
            ISquare circle = new Circle(5);
            var expected = 78.5;
            var result = circle.Square();

            Assert.AreEqual(expected, result);
        }
    }
}
