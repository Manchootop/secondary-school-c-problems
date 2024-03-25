using System;
using System.Linq;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Enter a sequence of numbers separated by space:");
        int[] array = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

        Array.Sort(array);

        int maxFrequency = 1;
        int currentFrequency = 1;
        int mostFrequentNumber = array[0];
        int currentNumber = array[0];

        for (int i = 1; i < array.Length; i++)
        {
            if (array[i] == currentNumber)
            {
                currentFrequency++;
            }
            else
            {
                if (currentFrequency > maxFrequency || (currentFrequency == maxFrequency && currentNumber < mostFrequentNumber))
                {
                    mostFrequentNumber = currentNumber;
                    maxFrequency = currentFrequency;
                }
                currentNumber = array[i];
                currentFrequency = 1;
            }
        }

        if (currentFrequency > maxFrequency || (currentFrequency == maxFrequency && currentNumber < mostFrequentNumber))
        {
            mostFrequentNumber = currentNumber;
        }

        Console.WriteLine($"The most frequent number is: {mostFrequentNumber}");
    }
}
