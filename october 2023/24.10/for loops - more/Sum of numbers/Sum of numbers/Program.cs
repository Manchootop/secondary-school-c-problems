using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sum_of_numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            int sum = 0;
            while (sum<num)
            {
                int input = int.Parse(Console.ReadLine());
                sum += input;
                if (sum>=num)
                {
                    Console.WriteLine(sum);
                    break;
                }
            }
        }
    }
}
