using System;

namespace _02._value_of_falcrum
{
    class Program
    {
        static void Main(string[] args)
        {
            var x1 = int.Parse(Console.ReadLine());
            var x2 = int.Parse(Console.ReadLine());

            Console.WriteLine(0.5 * (x1 + x2 +  Math.Abs(x1 - x2)));


        }
    }
}
