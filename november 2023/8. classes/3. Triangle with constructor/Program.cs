public class StartUp
{
    static void Main(string[] args)
    {
        Triangle triangle = new Triangle(3, 4, 5);
        //Square square = new Square();
        //square.Side = 6;
        //Console.WriteLine($"Circumference: {square.Side * 4}");
        //Console.WriteLine($"Area: {square.Side * square.Side}");

        int circumference = triangle.SideA + triangle.SideB + triangle.SideC;

    
        Console.WriteLine($"Circumference: {circumference}");

    }
}