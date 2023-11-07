﻿using System;

namespace Weather_forecast
{
    class Program
    {
        static void Main(string[] args)
        {
            var num = double.Parse(Console.ReadLine());

            if (num % 1 != 0)
                Console.WriteLine("Rainy");
            else if (num > sbyte.MinValue && num < sbyte.MaxValue)
                Console.WriteLine("Sunny");
            else if (num > int.MinValue && num < int.MaxValue)
                Console.WriteLine("Cloudy");
            else if (num > long.MinValue && num < long.MaxValue)
                Console.WriteLine("Windy");

        }
    }
}
