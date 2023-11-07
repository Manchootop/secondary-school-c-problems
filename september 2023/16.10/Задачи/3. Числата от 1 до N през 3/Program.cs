using System;

namespace _3._Числата_от_1_до_N_през_3
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i += 3)
            {
                Console.WriteLine(i);
            }
        }
    }
}
