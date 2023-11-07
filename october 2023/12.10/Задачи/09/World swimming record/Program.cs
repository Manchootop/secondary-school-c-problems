using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace World_swimming_record
{
    class Program
    {
        static void Main(string[] args)
        {
            double record = double.Parse(Console.ReadLine());
            double distance = double.Parse(Console.ReadLine());
            double time = double.Parse(Console.ReadLine());
            double resistance = 0;

            if (distance >= 15)
            {
                resistance = (Math.Floor(distance / 15) * 12.5);
            }
            double аchievedRecord = distance * time + resistance;
            if (аchievedRecord < record)
            {
                Console.WriteLine($" Yes, he succeeded! The new world record is {аchievedRecord:F2} seconds.");
            }
            else { Console.WriteLine($"No, he failed! He was {(аchievedRecord - record):F2} seconds slower."); }
        }
    }
}
