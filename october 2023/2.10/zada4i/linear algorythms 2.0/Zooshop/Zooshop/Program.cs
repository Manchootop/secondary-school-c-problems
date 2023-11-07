namespace Zooshop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int dogs = Convert.ToInt32(Console.ReadLine());
            int the_rest = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($"{(dogs*2.50)+(the_rest*4)} lv.");
        }
    }
}