using System;

namespace classes
{
    class Program
    {
        public class StartUp
        {
            static void Main(string[] args)
            {
                Square square = new Square();
                square.Side = 6;
                Console.WriteLine($"Circumference: {square.Side * 4}");
                Console.WriteLine($"Area: {square.Side * square.Side}");

            }
        }

    }
}
