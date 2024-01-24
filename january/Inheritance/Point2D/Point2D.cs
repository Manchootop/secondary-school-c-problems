using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

    class Point2D
    {
        private double x;
        private double y;
        
        public Point2D (double x, double y)
        {
            this.X = x;
            this.Y = y;
        }

        public double X { get; set; }
        public double Y { get; set; }

        public void Move(double mx, double my)
        {
            X += mx;
            Y += my;
        }
    public void Print()
    {
        Console.WriteLine($"{X} {Y} moved.");
    }
}
