using System;

namespace Percentage_of_women
{
    class Program
    {
        static void Main(string[] args)
        {
            int people = Convert.ToInt32(Console.ReadLine());
            int women = Convert.ToInt32(Console.ReadLine());
            int percentage = women * 100 / people;
            Console.WriteLine($"{percentage:f2}%");
        }
    }
}
