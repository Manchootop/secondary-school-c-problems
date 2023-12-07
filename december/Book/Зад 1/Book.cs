using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Зад_1
{
    internal class Book
    {
        public string Title { get; set; }
        public string Author { get; set; }
        public int Year { get; set; }
        public int Count { get; set; }
        public int Price { get; set; }
        public int Total => Count * Price;
        public Book()
        {

        }

        public Book(string title, string author, int year, int count, int price)
        {
            Title = title;
            Author = author;
            Year = year;
            Count = count;
            Price = price;
        }

        public string WriteBook()
        {
            return $"{Title} {Year} {Author} - {Count}";
        }

        public int CalcAll()
        {
            int total = Total;
            return total;
        }
    }
}
