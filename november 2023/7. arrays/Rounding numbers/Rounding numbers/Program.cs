using System.Linq;
using System.Collections.Generic;
namespace Rounding_numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double[] arr = Console.ReadLine().Split().Select(double.Parse).ToArray();
            
            for (int j = 0; j < arr.Length; j++)
            {

                Console.WriteLine($"{(arr[j])} => {(int)(Math.Round((arr[j]), MidpointRounding.AwayFromZero))}");
            }
        }
    }
}