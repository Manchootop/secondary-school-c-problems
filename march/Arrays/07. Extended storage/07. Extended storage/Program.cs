using System;
using System.Linq;
using static System.Runtime.InteropServices.JavaScript.JSType;

string[] names = Console.ReadLine().Split(' ');
int[] quantity = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
double[] price = Console.ReadLine().Split(' ').Select(double.Parse).ToArray();
string[] input = Console.ReadLine().Split(' ');

while (input[0] != "done")
{
    int index = Array.IndexOf(names, input[0]);
    int quantity_bought = Convert.ToInt32(input[1]);
    if (quantity.Length>index || quantity[index]>0)
    {
        Console.WriteLine($"{names[index]} x {quantity_bought} costs {Math.Round(price[index] * quantity_bought, 2)}");
        quantity[index] = quantity[index] - quantity_bought;
    }
    else Console.WriteLine("We do not have enough " + names[index]);
    input = Console.ReadLine().Split(' ');
}
