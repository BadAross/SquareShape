using System;

namespace SquareShape
{
    public class Circle : ISquare
    {
        private readonly double Radius;

        public Circle(double radius)
        {
            Radius = radius;
        }

        public double Square()
        {
            var result = Math.Round(Math.PI * Math.Pow(Radius, 2), 1);

            return Math.Round(result, 3);
        }
    }
}
