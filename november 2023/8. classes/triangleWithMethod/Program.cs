public class StartUp
{
    static void Main(string[] args)
    {
        Triangle triangle = new Triangle(3, 4, 5);
        int circumference = triangle.calcCircumference();
        Console.WriteLine(circumference);
    }
}