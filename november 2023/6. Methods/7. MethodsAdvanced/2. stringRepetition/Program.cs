static void stringRepetition(string str, int repCount)
{
    for (int i = 0; i < repCount; i++)
    {
        Console.Write(str);
    }
}

var str = Console.ReadLine();
int repCount = int.Parse(Console.ReadLine());

