using System;

namespace Percentage_of_a_sum
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());
            int c = Convert.ToInt32(Console.ReadLine());
            int sum = a + b + c;
            Console.WriteLine($"{a} = {(a*100/sum):f0}%");
            Console.WriteLine($"{b} = {(b*100/sum):f0}%");
            Console.WriteLine($"{c} = {(c*100/sum):f0}%");
        }
    }
}
