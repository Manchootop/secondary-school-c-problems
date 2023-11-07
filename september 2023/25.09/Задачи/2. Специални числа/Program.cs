using System;

namespace _2._Специални_числа
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());


            for (int i = 1; i < n + 1; i++)
            {
                int num = i;
                bool is_special = false;
                int sum = 0;
                while (num > 10)
                {
                    sum += num % 10;
                    num /= 10;
                } 
                if (num < 10)
                {
                    sum += num % 10;
                }
                if (sum == 5 || sum == 7 || sum == 11)
                    is_special = true;

                Console.WriteLine($"{i} -> {is_special}");
            }
        }
    }
}
