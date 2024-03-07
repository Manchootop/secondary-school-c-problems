using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.Обработка_на_масив
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] array = Console.ReadLine().Split(' ');
            int n = int.Parse(Console.ReadLine());
            for(int i = 1;i<=n;i++)
            {
                string[] command = Console.ReadLine().Split();
                ExecuteCommand(array, command);
            }
            Console.WriteLine(string.Join(", ", array));
        }

        static void ExecuteCommand (string[] array, string[] command)
        {
            if (command[0] == "Reverse") Array.Reverse(array);
            else if (command[0] == "Distinct") array = array.Distinct().ToArray();
            else if (command[0] == "Replace")
            {
                int index = int.Parse(command[1]);
                string replacement = command[2];
                array[index] = replacement;
            }
            else Console.WriteLine("Error");
        }
    }
}
