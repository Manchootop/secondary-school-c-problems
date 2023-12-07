using System;

namespace _1
{
    class Square
    {
        private int side;
        public int Side
        {
            get { return side; }
            set { side = value; }
        }
        
    }
    class Program
    {
        static void Main(string[] args)
        {
            Square square = new Square();
            square.Side = 6;
            Console.WriteLine($"CircumFence: {square.Side * 4}");
            Console.WriteLine($"Area: {square.Side * square.Side}");
        }
    }
}
