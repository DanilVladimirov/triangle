using System;

namespace triangle
{
    public class Triangle
    {
        private double a;
        private double b;
        private double c;
        private double angleA;
        private double angleB;
        private double angleC;

        public Triangle()
        {
            a = 0;
            b = 0;
            c = 0;
            angleA = 0;
            angleB = 0;
            angleC = 0;
        }

        public Triangle(double a, double b, double c)
        {
            if (a <= 0 || b <= 0 || c <= 0) {
                throw new Exception("a, b and c can't be zero or less than zero !"); 
            }
            this.a = a;
            this.b = b;
            this.c = c;
        }
        public double getA()
        {
            return a;
        }
        public double getB()
        {
            return b;
        }
        public double getC()
        {
            return c;
        }
        public double getL(double a, double b, double c)
        {
            double s = a + b;
            return Math.Sqrt(a * b * (s + c) * (s - c)) / s;
        }
        public double calculatePerimeter(double a, double b, double c)
        {
            return a + b + c;
        }
    }
}
