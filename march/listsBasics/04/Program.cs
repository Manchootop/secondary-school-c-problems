List<string> names = Console.ReadLine().Split(", ").ToList();

foreach(string el in names)
{
    Console.WriteLine(String.Join(" ", el.Split(' ').Reverse()));
}