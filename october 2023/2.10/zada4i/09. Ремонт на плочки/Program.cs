using System;

namespace _09._Ремонт_на_плочки
{
    class Program
    {
        static void Main(string[] args)
        {
            var roomSide = double.Parse(Console.ReadLine());
            var tileWidth = double.Parse(Console.ReadLine());
            var tileLength = double.Parse(Console.ReadLine());
            var benchWidth = double.Parse(Console.ReadLine());
            var benchLength = double.Parse(Console.ReadLine());
            var bench = benchWidth * benchLength;
            var tileSquare = tileWidth * tileLength;

            var tiles = ((roomSide * roomSide - bench) / tileSquare);

            Console.WriteLine(tiles);
            Console.WriteLine(tiles * 0.2);
        }
    }
}
