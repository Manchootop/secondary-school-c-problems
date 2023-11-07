namespace Invalid_number
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double num = double.Parse(Console.ReadLine());
            if ((num >= 100 && num <= 200) || num == 0)
            { }
            else { Console.WriteLine("invalid"); }
        }
    }
}