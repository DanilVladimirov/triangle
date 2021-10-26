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

        public double getL()
        {
            double s = a + b;
            return Math.Sqrt(a * b * (s + c) * (s - c)) / s;
        }

        public void setA(double a)
        {
            this.a = a;
        }

        public void setB(double b)
        {
            this.b = b;
        }

        public void setC(double c)
        {
            this.c = c;
        }

        public double calculatePerimeter()
        {
            return a + b + c;
        }

        public double calculateTriangleArea(double p)
        {
            return Math.Sqrt(p * (p - a) * (p - b) * (p - c));
        }

        public double calculateAreaWithr(double r)
        {
            return r * (a + b + c) / 2;
        }

        public double calculateAreaWithR(double r)
        {
            return (a * b * c) / 4*r;
        }

        public double getAngleA()
        {
            return Math.Cos((Math.Pow(a, 2) + Math.Pow(c, 2) - Math.Pow(b, 2)) / 2 * a * c);
        }

        public double getAngleB()
        {
            return Math.Cos((Math.Pow(a, 2) + Math.Pow(b, 2) - Math.Pow(c, 2)) / 2 * a * b);
        }

        public double getAngleY()
        {
            return Math.Cos((Math.Pow(b, 2) + Math.Pow(c, 2) - Math.Pow(a, 2)) / 2 * c * b);
        }
    }
}
