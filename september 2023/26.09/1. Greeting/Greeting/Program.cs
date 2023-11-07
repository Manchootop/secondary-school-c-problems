using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Greeting
{
    class Program
    {
        static void Main(string[] args)
        {
            string first_name = Console.ReadLine();
            string last_name = Console.ReadLine();
            int age = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($"Hello, {first_name} {last_name}. You are {age} years old.");
        }
    }
}
