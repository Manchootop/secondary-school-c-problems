using System;
using System.Linq;
using System.Collections.Generic;

namespace _3.MaximumSequenceOfIdenticalNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            //List<int> list = Console.ReadLine().Split().Select(int.Parse).ToList();
            int[] arr = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int mostOccurences = 0;
            int mostOccuringNumber = 0;
            int currOccurences = 0;

            for (int i = 0; i < arr.Length; i++)
            {
                int currNum = arr[i];

                if (currNum != mostOccuringNumber)
                    currOccurences = 0;
                currOccurences++;
                // add 1 to the current number

                // check most occuring number
                if (currOccurences >= mostOccurences)
                    mostOccuringNumber = currNum;
            }
            for (int i = 0; i < mostOccurences; i++)
                Console.WriteLine(mostOccuringNumber + " ");
        }
    }
}
