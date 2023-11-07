using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Max_number
{
    class Program
    {
        static void Main(string[] args)
        {
            double max = -10000000;
            string number = Console.ReadLine();

            while (number != "Stop")
            {
                if (double.Parse(number) > max)
                {
                    max = double.Parse(number);
                }
                number = Console.ReadLine();
            }
            Console.WriteLine(max);
        }
    }
}
