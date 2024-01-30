using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Rectangle : Shape
{
    private double SideA;
    private double SideB;

    public Rectangle(double sideA, double sideB)
    {
        this.SideA = sideA;
        this.SideB = sideB;
    }

    public override double GetPerimeter()
    {
        return 2 * (this.SideA + this.SideB);
    }
    public override double GetArea()
    {
        return this.SideA * this.SideB;
    }
}
