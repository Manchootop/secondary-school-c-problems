using System;

namespace _1.zad
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[20];
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = (i + 1) * 5;
            }
            foreach (int num in array)
            {
                Console.WriteLine(num);
            }
        }
    }
}
