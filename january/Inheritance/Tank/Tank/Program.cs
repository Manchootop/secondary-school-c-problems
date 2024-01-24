using System;
class Program
{
    static void Main(string[] args)
    {
        Tank.AreaOfTank t1 = new Tank.AreaOfTank(4, 8, "Brown");
        t1.DisplayColor();
        t1.ToString();
        Console.WriteLine("Area is: " + t1.Area());

    }
}

