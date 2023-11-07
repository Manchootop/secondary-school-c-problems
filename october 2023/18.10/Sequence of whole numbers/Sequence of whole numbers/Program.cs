﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sequence_of_whole_numbers
{
    class Program
    {
        static void Main(string[] args)
        {
			int n = int.Parse(Console.ReadLine());
			int max = -1000000;
			int min = 1000000;

			for (int i = 0; i < n; i++)
			{
				int num = int.Parse(Console.ReadLine());
				if (max < num) { max = num; }
				if (num < min) { min = num; }
			}
			Console.WriteLine($"Max number: {max}");
			Console.WriteLine($"Min number: {min}");
		}
    }
}
