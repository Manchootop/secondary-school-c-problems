using System;

namespace Dividing_a_number_in_two_halves
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = Convert.ToInt32(Console.ReadLine());
            int last_digit = num % 10;
            num /= 10;
            Console.WriteLine(num);
            Console.WriteLine(last_digit);
        }
    }
}
