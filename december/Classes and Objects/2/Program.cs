using System;

namespace _2
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
            triangle.SideA = 6;
            triangle.SideB = 12;
            triangle.SideC = 16;
            Console.WriteLine($"Triangle's circumference = {triangle.SideA + triangle.SideB + triangle.SideC}");
        }
    }
}
