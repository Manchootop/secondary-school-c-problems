using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bread
{
    class Program
    {
        static void Main(string[] args)
        {
        }
    }
    class Bread
    {
        public Bread(string breadType, decimal weight, string flourType, uint supplements, decimal price, uint count)
        {
            BreadType = breadType;
            Weight = weight;
            FlourType = flourType;
            Supplements = supplements;
            Price = price;
            Count = count;
        }

        public string ProductInfo()
        {
            return $"{BreadType}, {Weight} {Price:F3}, {FlourType}, supplements{Supplements}%, {Count}";
        }

        public decimal ValueOfProducts(string flourType)
        {
            switch(flourType)
            {
                case "Bqlo":
                    Price = Count*
                    break;
            }
        
        }
        public string BreadType { get; set; }
        public decimal Weight { get; set; }
        public string FlourType { get; set; }
        public uint Supplements { get; set; }
        public decimal Price { get; set; }
        public uint Count { get; set; }
    }
}
