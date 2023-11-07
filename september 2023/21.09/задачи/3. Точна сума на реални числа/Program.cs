var n = int.Parse(Console.ReadLine());
decimal total = 0;
for (int i = 0; i < n; i++)
{
    decimal num = decimal.Parse(Console.ReadLine());

    total += num;
}

Console.WriteLine($"total = {total}");