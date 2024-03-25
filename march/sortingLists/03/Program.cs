List<int> nums = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
Dictionary<int, int> occurances = new Dictionary<int, int>();

nums.Sort();

foreach(int num in nums)
{
    if (!occurances.ContainsKey(num))
    {
        occurances.Add(num, 0);
    }

    occurances[num]++;
}

foreach(KeyValuePair<int, int> kvp in occurances)
{
    Console.WriteLine($"{kvp.Key} -> {kvp.Value}");
}