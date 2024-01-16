using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tank
{
    class AreaOfTank:Tank
    {
        public string Color { get; set; }
        public AreaOfTank(double Radius, double Height, string Color)
            :base(Radius, Height)
        {
            this.Color = Color;
        }
        public double Area()
        {
            return 2 * 3.14 * Radius * Height;
        }
        public void DisplayColor()
        {
            Console.WriteLine($"The color of tank is: {Color}");
        } 
    }
}
