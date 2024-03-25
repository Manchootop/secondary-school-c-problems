using System;
using System.Linq;
using System.Collections.Generic;

namespace _01
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            foreach(int num in numbers)
            {
                if(num % 2 == 0)
                {
                    Console.Write($"{num} ");
                }
            }

        }
    }
}
