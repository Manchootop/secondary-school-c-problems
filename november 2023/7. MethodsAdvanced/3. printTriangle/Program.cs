static void printTriangle(int size)
{
    for (int i = 1; i <= size; i++)
    {
        for (int j = 1; j <= i; j++)
        {
            Console.Write($"{j} ");
        }   
        Console.WriteLine("");
    }
}
int size = int.Parse(Console.ReadLine());
printTriangle(size);