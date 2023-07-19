using System;

namespace SquareShape
{
    public class Triangle : ISquare, IStraightTriangle
    {
        private readonly double EdgeA;
        private readonly double EdgeB;
        private readonly double EdgeC;

        public Triangle(double a, double b, double c)
        {
            if (isExist(a, b, c))
            {
                EdgeA = a;
                EdgeB = b;
                EdgeC = c;
            }
        }

        public double Square()
        {
            var p = (EdgeA + EdgeB + EdgeC) / 2;
            var result = Math.Sqrt(p * (p - EdgeA) * (p - EdgeB) * (p - EdgeC));

            return Math.Round(result, 3);
        }

        private bool Returns_Result_Checking_Sides_Equal_Zero(double a, double b, double c)
        {
            if (a < 0 || b < 0 || c < 0)
            {
                throw new TriangleExceptions("Такого треугольника не существует(сторона(ы) меньше 0)");
            }
            return true;
        }

        private bool Returns_Result_Checking_Sum_Parties(double a, double b, double c)
        {
            if (a > (b + c) || b > (a + c) || c > (a + b))
            {
                throw new TriangleExceptions("Такого треугольника не существует(сторона больше суммы двух других)");
            }
            return true;
        }

        private bool isExist(double a, double b, double c)
        {
            return Returns_Result_Checking_Sides_Equal_Zero(a, b, c)
                 & Returns_Result_Checking_Sum_Parties(a, b, c);
        }

        public bool isStraightTriangle()
        {
            return EdgeA == Math.Sqrt(Math.Pow(EdgeB, 2) + Math.Pow(EdgeC, 2))
                    || EdgeB == Math.Sqrt(Math.Pow(EdgeA, 2) + Math.Pow(EdgeC, 2))
                    || EdgeC == Math.Sqrt(Math.Pow(EdgeA, 2) + Math.Pow(EdgeB, 2));
        }
    }
}
