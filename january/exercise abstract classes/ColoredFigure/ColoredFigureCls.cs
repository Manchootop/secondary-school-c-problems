using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

abstract class ColoredFigureCls
{
    public string Color;
    public double Size;
    public ColoredFigureCls(string color, double size)
    {
        this.Color = color;
        this.Size = size;
    }

    public void Show()
    {
        Console.WriteLine($"Size: {this.Size}, Color: {this.Color}");
    }
    public abstract void GetName();

    public abstract void GetArea();

}