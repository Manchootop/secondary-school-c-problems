using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public class Rectangle : IDrawable
{
    public int width { get; set; }
    public int height { get; set; }
    public Rectangle(int width, int height)
    {
        this.width = width;
        this.height = height;
    }

    public void Draw()
    {
        DrawLine(this.width, '*', '*');
        for (int i = 0; i < this.height - 1; i++)
            DrawLine(this.width, '*', ' ');
        DrawLine(this.width, '*', '8');
    }
    private void DrawLine(int width, char end, char mid)
    {
        Console.Write(end);
        for (int i = 1; i < width - 1; ++i)
            Console.Write(mid);
        Console.WriteLine(end);
    }
}
