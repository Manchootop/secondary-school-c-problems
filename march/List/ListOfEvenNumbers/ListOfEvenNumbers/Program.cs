using System;
using System.Linq;
using System.Collections.Generic;

namespace ListOfEvenNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> list = Console.ReadLine().Split().Select(int.Parse).Where(num => num % 2 == 0).ToList();
            Console.WriteLine(String.Join(' ', list));

        }
    }
}
