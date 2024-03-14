using System;
using System.Linq;

char[] alphabet = new char[26];
for (int i = 0; i < 26; i++)
{
    alphabet[i] = (char)('a' + i);
}

Console.Write("Enter a word in lowercase letters: ");
string word = Console.ReadLine();

Console.WriteLine("Indexes of letters in the alphabet:");
foreach (char letter in word)
{
    int index = Array.IndexOf(alphabet, letter);
    Console.WriteLine($"{letter}: {index}");
}