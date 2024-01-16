public class Seat : ICar
{
    public string Model { get; private set; }
    public string Color { get; private set; }
    public Seat(string model, string color)
    {
        this.Model = model;
        this.Color = color;
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