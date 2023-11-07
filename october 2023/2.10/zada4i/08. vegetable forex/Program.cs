using System;

namespace _08._vegetable_forex
{
    class Program
    {
        static void Main(string[] args)
        {
            var vegetablesPrice = int.Parse(Console.ReadLine());
            var fruitsPrice = int.Parse(Console.ReadLine());
            var vegetablesWeight = int.Parse(Console.ReadLine());
            var fruitWeight = int.Parse(Console.ReadLine());

            Console.WriteLine(vegetablesPrice * vegetablesWeight + fruitsPrice * fruitWeight);
        }
    }
}
