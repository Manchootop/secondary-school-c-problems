using System;

namespace _2._Числата_от_N_до_1_в_обратен_ред
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            for (int i = n; i < 0; i--)
            {
                Console.WriteLine(i);
            }
        }
    }
}
