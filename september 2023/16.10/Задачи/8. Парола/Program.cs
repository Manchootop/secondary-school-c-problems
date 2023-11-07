using System;

namespace _8._Парола
{
    class Program
    {
        static void Main(string[] args)
        {
            var name = Console.ReadLine();

            var password = Console.ReadLine();
            var guess = Console.ReadLine();
            while (guess != password)
            {
                guess = Console.ReadLine();
            }
            Console.WriteLine($"Welcum {name}");
        }
    }
}
