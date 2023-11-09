using System;

namespace _4._powers
{
    class Program
    {
        static void powerOfNumber(int num, int power)
        {
            Console.WriteLine($"{num ^ power}");
        }
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            int power = int.Parse(Console.ReadLine());

            powerOfNumber(num, power);
        }
    }
}
