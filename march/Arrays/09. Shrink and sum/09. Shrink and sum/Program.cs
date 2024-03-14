using System;

class Program
{
    static void Main(string[] args)
    {
        int[] array = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

        int k = array.Length / 4;
        int[] foldedArray = new int[2 * k];

        for (int i = 0; i < k; i++)
        {
            foldedArray[i] = array[k + i] + array[k - 1 - i];
            foldedArray[2 * k - 1 - i] = array[3 * k - 1 - i] + array[4 * k - 1 - i];
        }

        Console.WriteLine("Folded array:");
        foreach (int num in foldedArray)
        {
            Console.Write(num + " ");
        }

        int upperRowSum = 0;
        for (int i = 0; i < k; i++)
        {
            upperRowSum += foldedArray[i];
        }

        int lowerRowSum = 0;
        for (int i = k; i < 2 * k; i++)
        {
            lowerRowSum += foldedArray[i];
        }
    }
}

