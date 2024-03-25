using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

abstract class Shape
{
    public virtual double GetArea()
    {
        return 0;
    }
    public virtual double GetPerimeter()
    {
        return 0;
    }
}
