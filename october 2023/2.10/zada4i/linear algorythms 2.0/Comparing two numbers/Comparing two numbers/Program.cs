﻿using System;

namespace Comparing_two_numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(Math.Max(a,b));
        }
    }
}
