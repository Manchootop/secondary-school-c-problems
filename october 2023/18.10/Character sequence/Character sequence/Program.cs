﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Character_sequence
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            for (int i = 0; i < input.Length; i++)
            {
                char letter = input[i];
                Console.WriteLine(letter);
            }
        }
    }
}