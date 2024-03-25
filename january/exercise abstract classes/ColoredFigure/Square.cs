using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Rectangle : ColoredFigureCls
{
    public Rectangle(string color, double size) : base(color, size)
    {
        this.Color = color;
        this.Size = size;
    }
    public override void GetName()
    {
        Console.WriteLine("Triangle");
    }
    public override void GetArea()
    {
        Console.WriteLine(Size * Size * Math.Sqrt(3) / 4);
    }
}
