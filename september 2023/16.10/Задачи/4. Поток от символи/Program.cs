using System;

namespace _4._Поток_от_символи
{
    class Program
    {
        static void Main(string[] args)
        {
            var str = Console.ReadLine();

            for (int i = 0; i < str.Length; i++)
            {
                char letter = str[i];
                Console.WriteLine(letter);


            }
        }
    }
}
