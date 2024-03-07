using System;
using System.Linq;

string[] names = Console.ReadLine().Split(' ');
int[] quantity = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
double[] price = Console.ReadLine().Split(' ').Select(double.Parse).ToArray();
string input = Console.ReadLine();
while(input!="done")
{
    int index = Array.IndexOf(names, input);
    Console.WriteLine($"{names[index]} costs: {price[index]}; Available quantity: {quantity[index]}");
    input = Console.ReadLine();
}
