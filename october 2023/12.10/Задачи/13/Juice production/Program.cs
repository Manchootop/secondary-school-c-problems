namespace Juice_production
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int squareMetersGarden = Convert.ToInt32(Console.ReadLine());
            double kgApplesPerSquareMeter = Convert.ToDouble(Console.ReadLine());
            int boxWithJuiceCount = Convert.ToInt32(Console.ReadLine());

            double totalApples = squareMetersGarden * kgApplesPerSquareMeter;
            double boxes = 0.40 * totalApples / 2.3;
            if (boxes > boxWithJuiceCount)
            {
                Console.WriteLine($"Great job! Total boxes {Math.Floor(boxes)}.");
            }
            else
            {
                double diff = boxWithJuiceCount - boxes;
                Console.WriteLine($"Not enough juice with {Math.Floor(diff)} boxes less.");
            }
        }
    }
}