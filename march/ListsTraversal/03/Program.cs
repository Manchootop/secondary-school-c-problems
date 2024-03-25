using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;

namespace _03
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();
            Dictionary<int, int> occurances = new Dictionary<int, int>();

            foreach(int el in numbers)
            {
                if (!occurances.ContainsKey(el))
                {
                    occurances.Add(el, 0);
                }
                occurances[el]++;
            }

            int maxValue = occurances.Values.Max();

            foreach(KeyValuePair<int, int> kv in occurances)
            {
                if(kv.Value == maxValue)
                {
                    for(int i = 1; i <= kv.Value; i++)
                    {
                        Console.Write($"{kv.Key} ");
                    }
                    break;
                }
            }
        }
    }
}
