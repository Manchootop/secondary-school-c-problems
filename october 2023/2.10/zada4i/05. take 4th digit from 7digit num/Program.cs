using System;

namespace _05._take_4th_digit_from_7digit_num
{
    class Program
    {
        static void Main(string[] args)
        {
            var num = int.Parse(Console.ReadLine());
            for (int i = 0; i < 3; i++)
            {
                num /= 10;
            }
            Console.WriteLine(num % 10);
        }
    }
}
