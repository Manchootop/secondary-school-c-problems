using System;

namespace _01._Volume_and_square_of_an_cylinder
{
    class Program
    {
        static void Main(string[] args)
        {
            var height = int.Parse(Console.ReadLine());
            var r = int.Parse(Console.ReadLine());
            var B = Math.PI * r * r;
            var volume = height * B;
            var square = Math.PI * r * height + 2 * B;

            Console.WriteLine($"{volume}, {square}");

        }
    }
}
