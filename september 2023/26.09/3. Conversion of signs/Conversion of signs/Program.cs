﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conversion_of_signs
{
    class Program
    {
        static void Main(string[] args)
        {
            char a = Convert.ToChar(Console.ReadLine());
            char b = Convert.ToChar(Console.ReadLine());
            char c = Convert.ToChar(Console.ReadLine());

            Console.WriteLine($"{c}{b}{a}");
        }
    }
}
