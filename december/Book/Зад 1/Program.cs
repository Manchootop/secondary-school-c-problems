namespace Зад_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int older = int.MaxValue;
            for (int i = 1; i <= 3; i++)
            {
                string[] bookInfo = Console.ReadLine().Split();
                string title = bookInfo[0];
                string author = bookInfo[1];
                int year = int.Parse(bookInfo[2]);
                int count = int.Parse(bookInfo[3]);
                int price = int.Parse(bookInfo[4]);

                Book currentBook = new Book(title, author, year, count, price);

                if (older < year)
                { 
                    older = year; 
                }

                currentBook.WriteBook();
                currentBook.CalcAll();
            }
            Console.WriteLine((int)'a');
        }
    }
}