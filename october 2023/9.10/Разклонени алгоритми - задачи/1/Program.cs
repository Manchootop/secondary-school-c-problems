using System;

namespace _1
{
    class Program
    {
        static void Main(string[] args)
        {
            var num = int.Parse(Console.ReadLine());
            // 1 
            Console.WriteLine("#1 Test");
            if (num % 2 == 0 )
                Console.WriteLine("Even");

            // 2
            Console.WriteLine("#2 Test");
            if (num % 3 != 0)
                Console.WriteLine("Not dividable by 3");

            // 3 
            Console.WriteLine("#3 Test");
            if (num % 4 == 0 || num % 7 == 0)
                Console.WriteLine("Dividable by 4 or 7");

            // 4
            Console.WriteLine("#4 Test");
            if (num <= 10 && num >=0)
                Console.WriteLine("Between 0 and 10");

            // 5 
            Console.WriteLine("#5 Test");       

            if (num <= 7 && num >= -5)
                Console.WriteLine("Between -5 and 7");


        }
    }
}
