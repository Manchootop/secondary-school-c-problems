namespace From_radians_to_degrees
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double radians = Convert.ToDouble(Console.ReadLine());
            double degree = radians * 180 / Math.PI;
            Console.WriteLine(Math.Round(degree));
        }
    }
}