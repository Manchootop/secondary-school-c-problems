using System;

namespace _6._Четене_на_думи
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                string text = Console.ReadLine();
                if (text == "Stop")
                    break;
                Console.WriteLine(text);
            }
        }
    }
}
