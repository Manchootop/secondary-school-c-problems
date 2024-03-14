using System;
using System.Linq;

int[] array = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();
int[] reversed = new int[array.Length];
for (int i = 0; i < array.Length; i++)
{
    reversed[i] = array[array.Length - i - 1];
}
for (int i = 0;i < reversed.Length; i++)
{
    Console.Write(reversed[i] + " ");
}

