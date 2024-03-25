using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Triangle: Shape
{
    private double SideA;
    private double SideB;
    private double SideC;

    public Triangle(double sideA, double sideB, double sideC)
    {
        this.SideA = sideA;
        this.SideB = sideB;
        this.SideC = sideC;
    }

    public override double GetPerimeter()
    {
        return this.SideA + this.SideB + this.SideC;
    }
    public override double GetArea()
    {
        double halfPerimeter = GetPerimeter() / 2;
        return Math.Sqrt(halfPerimeter * (halfPerimeter - SideA) * (halfPerimeter - SideB) * (halfPerimeter - SideC));
    }
}
