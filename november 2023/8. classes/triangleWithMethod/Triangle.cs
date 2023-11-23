using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public class Triangle
{
    public int SideA { get; set; }
    public int SideB { get; set; }
    public int SideC { get; set; }

    public Triangle(int sideA, int sideB, int sideC)
    {
        this.SideA = sideA;
        this.SideB = sideB;
        this.SideC = sideC;
    }

    public int calcCircumference()
    {
        return this.SideA + this.SideB + this.SideC;
    }
}

