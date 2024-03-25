using System;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        int[] numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

        int k = int.Parse(Console.ReadLine());

        int[] sumArray = new int[numbers.Length];

        for (int i = 0; i < k; i++)
        {
            RotateArrayRight(numbers);
            sumArray = SumArrays(sumArray, numbers);
        }

        foreach (int sum in sumArray)
        {
            Console.Write(sum + " ");
        }
    }

    static void RotateArrayRight(int[] array)
    {
        int lastElement = array[array.Length - 1];
        for (int i = array.Length - 1; i > 0; i--)
        {
            array[i] = array[i - 1];
        }
        array[0] = lastElement;
    }

    static int[] SumArrays(int[] array1, int[] array2)
    {
        int[] sumArray = new int[array1.Length];
        for (int i = 0; i < array1.Length; i++)
        {
            sumArray[i] = array1[i] + array2[i];
        }
        return sumArray;
    }
}
