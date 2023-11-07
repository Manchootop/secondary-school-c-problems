using System;

namespace Catch_the_thief
{
    class Program
    {
        static void Main(string[] args)
        {
            var type = Console.ReadLine();
            var typeMaxValue = 0.0;
            var closestIdToMaxValue = 0.0;


            var ids_count = int.Parse(Console.ReadLine());
            switch (type)
            {
                case "sbyte":
                    typeMaxValue = sbyte.MaxValue;
                    break;
                case "int":
                    typeMaxValue = int.MaxValue;
                    break;
                case "long":
                    typeMaxValue = long.MaxValue;
                    break;
            }
            var closestIdValueToMaxValue = typeMaxValue;
            for (int i = 0; i < ids_count; i++)
            {
                var id = double.Parse(Console.ReadLine());
                if (Math.Abs(id - typeMaxValue) <= closestIdValueToMaxValue)
                {
                    closestIdValueToMaxValue = Math.Abs(id - typeMaxValue);
                    closestIdToMaxValue = id;
                }
            }
            Console.WriteLine(closestIdValueToMaxValue);
        }

    }
}
