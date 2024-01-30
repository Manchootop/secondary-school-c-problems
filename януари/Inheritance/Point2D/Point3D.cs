using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

    class Point3D : Point2D
    {
        private double z;
        public Point3D(double z, double x, double y) : base(x, y)
        {
            this.Z = z;
        }
        public double Z
        {
            get { return z; }
            set { z = value; }
        }
        public void Move(double mx, double my, double mz)
        {
            base.Move(mx, my);
            Z += mz;
        }
        public void Print()
        {
        Console.WriteLine($"{X} {Y} {Z} moved.");
        }
    }
