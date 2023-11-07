using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Number_divisable_by_10
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                int num = int.Parse(Console.ReadLine());
                if (num % 10 ==0)
                {
                    Console.WriteLine($"The number is {num}");
                    break;
                }
                Console.WriteLine("Invalid number!");
            }
        }
    }
}
