using System;

namespace Company
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            string address = Console.ReadLine();
            string phone_number = Console.ReadLine();
            string website = Console.ReadLine();
            string manager_name = Console.ReadLine();
            string manager_phone_number = Console.ReadLine();

            Console.WriteLine($"Company: {name}");
            Console.WriteLine($"Address: {address}");
            Console.WriteLine($"Contacts: {phone_number}");
            Console.WriteLine($"About us: {website}");
            Console.WriteLine($"Manager: {manager_name}, {manager_phone_number}");
        }
    }
}
