using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Password
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            string pass = Console.ReadLine();
            string password = Console.ReadLine();
            while (password != pass)
            {
                password = Console.ReadLine();
            }
            Console.WriteLine($"Welcome {name}!");
        }
    }
}
