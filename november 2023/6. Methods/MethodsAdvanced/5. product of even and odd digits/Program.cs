using System;

namespace _5._product_of_even_and_odd_digits
{
    class Program2
    {
        public static int productOfEvenAndOddDigitsSum(int num)
        {
            int evenSum = 0;
            int oddSum = 0;
            while (num != 0)
            {
                var digit = Math.Abs(num % 10);
                num /= 10;
                if (digit % 2 == 0)
                    evenSum += digit;
                else
                    oddSum += digit;
            }
            return evenSum * oddSum;
        }
        static void Main(string[] args)
        {
            var num = int.Parse(Console.ReadLine());
            Console.WriteLine(productOfEvenAndOddDigitsSum(num));
        }
    }
}
