using System;

namespace _03._heron
{
    class Program
    {
        static void Main(string[] args)
        {
            var a = int.Parse(Console.ReadLine());
            var b = int.Parse(Console.ReadLine());
            var c = int.Parse(Console.ReadLine());
            var p = (a + b + c) / 2;

            Console.WriteLine(Math.Sqrt((p-a)) * (p-b) * (p-c)));
        }
    }
}
