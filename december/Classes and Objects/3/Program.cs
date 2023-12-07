using System;

namespace _3
{
    public class Triangle
    {
        public int SideA { get; set; }

        public int SideB { get; set; }

        public int SideC { get; set; }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Triangle triangle = new Triangle();
            triangle.SideA = 3;
            triangle.SideB = 4;
            triangle.SideC = 5;
            Console.WriteLine($"Circumference: {triangle.SideA + triangle.SideB + triangle.SideC}");
        }
    }
}
