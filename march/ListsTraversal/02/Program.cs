using System;
using System.Linq;
using System.Collections.Generic;

namespace _02
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();

            int max = numbers.Max();
            int min = numbers.Min();

            int minCounter = 0;
            int maxCounter = 0;

            foreach(int num in numbers)
            {
                if(num == min)
                {
                    minCounter++;
                }

                else if(num == max)
                {
                    maxCounter++;
                }
            }

            for(int i = 0; i < minCounter; i++)
            {
                Console.Write($"{min} ");
            }

            for (int i = 0; i < maxCounter; i++)
            {
                Console.Write($"{max} ");
            }
        }
    }
}
