using System;

namespace triangle
{
    public class Triangle
    {
        private double a;
        private double b;
        private double c;

        public Triangle()
        {
            a = 0;
            b = 0;
            c = 0;
        }

        public Triangle(double a, double b, double c)
        {
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
        public double getL(double c, double a, double b)
        {
            double s = a + b;
            return Math.Sqrt(a * b * (s + c) * (s - c)) / s;
        }
    }
}
