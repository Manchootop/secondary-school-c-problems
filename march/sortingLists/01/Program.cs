List<int> nums = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
nums.Sort();

Console.WriteLine(String.Join(" <= ", nums));