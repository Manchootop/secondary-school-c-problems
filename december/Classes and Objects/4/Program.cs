using System;

namespace _4
{
    public class Triangle
    {
        public int SideA { get; set; }

        public int SideB { get; set; }

        public int SideC { get; set; }

        public int CalculateCircumference()
        {
            return SideA + SideB + SideC;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Triangle triangle = new Triangle();
            triangle.SideA = 3;
            triangle.SideB = 4;
            triangle.SideC = 5;
            int circumference = triangle.CalculateCircumference();
            Console.WriteLine($"Circumference: {circumference}");
        }
    }
}
