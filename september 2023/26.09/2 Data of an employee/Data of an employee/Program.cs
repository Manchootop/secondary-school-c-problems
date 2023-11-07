using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_of_an_employee
{
    class Program
    {
        static void Main(string[] args)
        {
            string first_name = Console.ReadLine();
            string last_name = Console.ReadLine();
            int age = Convert.ToInt32(Console.ReadLine());
            char gender = Convert.ToChar(Console.ReadLine());
            long ID = Convert.ToInt64(Console.ReadLine());
            long unique_num = Convert.ToInt64(Console.ReadLine());
            Console.WriteLine($"First name: {first_name}");
            Console.WriteLine($"Last name: {last_name}");
            Console.WriteLine($"Age: {age}");
            Console.WriteLine($"Gender: {gender}");
            Console.WriteLine($"Personal ID: {ID}");
            Console.WriteLine($"Unique Employee number: {unique_num}");
        }
    }
}
