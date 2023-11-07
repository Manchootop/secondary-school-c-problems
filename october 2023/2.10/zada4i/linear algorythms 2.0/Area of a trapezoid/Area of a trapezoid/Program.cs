using System;

namespace Area_of_a_trapezoid
{
    class Program
    {
        static void Main(string[] args)
        {
            double a = Convert.ToDouble(Console.ReadLine());
            double b = Convert.ToDouble(Console.ReadLine());
            double h = Convert.ToDouble(Console.ReadLine());
            double area = (a + b) / 2 * h;
            Console.WriteLine($"Trapezoid area: {area}");
        }
    }
}
