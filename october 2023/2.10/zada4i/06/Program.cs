using System;

namespace _06
{
    class Program
    {
        static void Main(string[] args)
        {
            var k = int.Parse(Console.ReadLine());
            var num = int.Parse(Console.ReadLine());
            //for (int i = 0; i < k; i++)
            //{
            //    num /= 10;
            //}
            //Console.WriteLine(num % 10);

            for (int i = k; i > 1; i--)
            {
                num /= 10;
            }
            Console.WriteLine(num % 10);
        }
    }
}
