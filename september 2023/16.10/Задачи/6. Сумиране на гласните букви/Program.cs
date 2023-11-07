using System;

namespace _6._Сумиране_на_гласните_букви
{
    class Program
    {
        static void Main(string[] args)
        {
            var text = Console.ReadLine();
            var vowelSum = 0;
            for (int i = 0; i < text.Length; i++)
            {
                char letter = text[i];
                switch(letter)
                {
                    case 'a':
                        vowelSum += 1;
                        break;
                    case 'e':
                        vowelSum += 2;
                        break;
                    case 'i':
                        vowelSum += 3;
                        break;
                    case 'o':
                        vowelSum += 4;
                        break;
                    case 'u':
                        vowelSum += 5;
                        break;
                }
            }
            Console.WriteLine(vowelSum);

        }
    }
}
