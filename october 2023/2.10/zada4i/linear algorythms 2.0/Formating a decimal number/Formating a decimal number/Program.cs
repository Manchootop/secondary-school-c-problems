using System;

namespace Formating_a_decimal_number
{
    class Program
    {
        static void Main(string[] args)
        {
            double number = Convert.ToDouble(Console.ReadLine());
            double format = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine(number.ToString("F" + format));
        }
    }
}
