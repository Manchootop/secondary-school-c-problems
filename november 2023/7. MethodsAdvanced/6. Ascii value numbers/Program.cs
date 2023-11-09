using System;
using System.Text;
namespace _6._Ascii_value_numbers
{
    class Program
    {
        
        static void printAsciiValuesInGivenRange(string first, string second)
        {
            byte[] firstASCII = Encoding.ASCII.GetBytes(first);
            byte[] secondASCII = Encoding.ASCII.GetBytes(second);
            Console.WriteLine(firstASCII);
            Console.WriteLine(secondASCII);
        }
        static void Main(string[] args)
        {
            printAsciiValuesInGivenRange("a", "b");
        }
    }
}
