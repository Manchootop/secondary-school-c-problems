using System;

namespace _04._print_out_3_digit_number
{
    class Program
    {
        static void Main(string[] args)
        {
            var threeDigitNum = int.Parse(Console.ReadLine());
            
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine(threeDigitNum % 10);
                threeDigitNum /= 10;
            }
        }
    }
}
