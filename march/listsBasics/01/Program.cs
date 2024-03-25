List<int> list = Console.ReadLine().Split(' ').Select(int.Parse).ToList();

for(int i = 0; i < list.Count; i++)
{
    Console.WriteLine($"list[{i}] = {list[i]}");
}