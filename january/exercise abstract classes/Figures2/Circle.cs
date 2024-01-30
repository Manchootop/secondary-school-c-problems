using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Circle : Shape
{
    private double Radius;

    public Circle(double radius)
    {
        Radius = radius;
    }

    public override double GetArea()
    {
        return Math.PI * Radius * Radius;
    }   
    public override double GetPerimeter()
    {
        return 2 * Radius * Math.PI;
    }
}