using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Train_the_trainers
{
    class Program
    {
        static void Main(string[] args)
        {
            int judges = int.Parse(Console.ReadLine());
            string input = Console.ReadLine();
            int counter = 0;
            double sum = 0;
            string prezentation;

            while (input != "Finish")
            {
                double prezentationEV = 0;
                prezentation = input;
                for (int i = 1; i <= judges; i++)
                {
                    prezentationEV += double.Parse(Console.ReadLine());
                }
                prezentationEV = prezentationEV / judges;
                sum += prezentationEV;

                Console.WriteLine($"{prezentation} - {prezentationEV:F2}.");
                counter++;
                input = Console.ReadLine();

            }

            Console.WriteLine($"Student's final assessment is {sum / counter:F2}.");
        }
    }
}
