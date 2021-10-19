using System;
namespace triangle
{
    public class Program
    {
        static void Main(string[] args)
        {
            Triangle tri = new Triangle(1.3, 3.4, 4.0);
            Console.WriteLine(tri.getA());
        }
    }
}
