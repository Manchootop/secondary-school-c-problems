using System;

namespace _07
{
    class Program
    {
        static void Main(string[] args)
        {
            var length = double.Parse(Console.ReadLine()) * 100;
            var width = double.Parse(Console.ReadLine()) * 100;
            //var workingPlace = 70
            var corridor = 100;
            var lineLength = 120;

            var availableDesksPerLine = ((int)width - corridor) / 70;
            var lines = (int)length / lineLength;
            var lossCausedByObjects = 3;
            var desksToFit = availableDesksPerLine * lines - lossCausedByObjects;

            Console.WriteLine(desksToFit);
        }
    }
}
