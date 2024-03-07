using System.Linq;

int[] array = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
int min = array.Min();
int max = array.Max();
int sum = array.Sum();
int avg = (int)(double)array.Average();
Console.WriteLine("The samllest number in this array is: " + min);
Console.WriteLine("The biggest number in this array is: " + max);
Console.WriteLine("The sum of this array is: " + sum);
Console.WriteLine("The average number in this array is: " + avg);
