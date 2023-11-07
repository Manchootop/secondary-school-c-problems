namespace Landscaping_yards
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double quadratic_meters = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine($"The final price is: {((quadratic_meters*7.61)*0.82):f2} lv.");
            Console.WriteLine($"The final price is: {((quadratic_meters*7.61)*0.18):f2} lv.");
        }
    }
}