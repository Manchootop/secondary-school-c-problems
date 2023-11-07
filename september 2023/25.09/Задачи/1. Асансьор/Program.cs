using System;

namespace _1._Асансьор
{
    class Program
    {
        static void Main(string[] args)
        {
            int people = int.Parse(Console.ReadLine());

            int capacity = int.Parse(Console.ReadLine());

            Console.WriteLine(people / capacity + capacity % (people % capacity));
        }
    }
}
