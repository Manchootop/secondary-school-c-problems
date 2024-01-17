using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Tesla : ICar, IElectricCar
{
    public string Model { get; private set; }
    public string Color { get; private set; }
    public int Batteries { get; private set; }
    public Tesla(string model, string color, int batteries)
    {
        this.Model = model;
        this.Color = color;
        this.Batteries = batteries;
    }
    public string Start()
    {
        return "";
    }
    public string Stop()
    {
        return "";
    }
}