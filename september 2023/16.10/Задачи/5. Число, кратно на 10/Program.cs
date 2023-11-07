using System;

namespace _5._Число__кратно_на_10
{
    class Program
    {
        static void Main(string[] args)
        {
            var num = int.Parse(Console.ReadLine());
            while (num % 10 != 0)
            {
                Console.WriteLine("Invalid Number");
                num = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("The number");
        }
    }
}
