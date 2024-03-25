using System;
using System.Collections.Generic;
using System.Linq;
namespace _2._ListOfExtremes
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> list = Console.ReadLine().Split().Select(int.Parse).ToList();
            foreach (int num in list)
            {
                if (num == list.Max())
                    Console.Write(num + " ");
                else if (num == list.Min())
                    Console.WriteLine(num + " ");
            }

        }
    }
}
