List<int> nums = Console.ReadLine().Split().Select(int.Parse).ToList();

while (true)
{
    string[] line = Console.ReadLine().Split(' ');

    if (line[0].ToLower() == "add")
    {
        int index = int.Parse(line[1]);
        int element = int.Parse(line[2]);

        nums.Insert(index, element);
    }

    else if (line[0].ToLower() == "addmany")
    {
        int index = int.Parse(line[1]);
        List<int> range = new List<int>();
        for (int i = 2; i < line.Length; i++)
        {
            range.Add(int.Parse(line[i]));
        }

        nums.InsertRange(index, range);
    }

    else if (line[0].ToLower() == "contains")
    {
        int element = int.Parse(line[1]);

        Console.WriteLine(nums.IndexOf(element));
    }

    else if (line[0].ToLower() == "remove")
    {
        int index = int.Parse(line[1]);

        nums.RemoveAt(index);
    }

    else if (line[0].ToLower() == "shift")
    {
        int positions = int.Parse(line[1]);

        List<int> shiftedList = new List<int>();
        shiftedList.AddRange(nums.GetRange(positions, nums.Count - positions));
        shiftedList.AddRange(nums.GetRange(0, positions));

        nums = shiftedList;
    }

    else if (line[0].ToLower() == "sumpairs")
    {
        List<int> sums = new List<int>();

        for (int i = 0; i < nums.Count - 1; i += 2)
        {
            if (i + 1 < nums.Count)
            {
                sums.Add(nums[i] + nums[i + 1]);
            }
            else
            {
                sums.Add(nums[i]);
            }
        }

        nums = sums;
    }

    else if (line[0].ToLower() == "print")
    {
        Console.WriteLine("[" + String.Join(", ", nums) + "]");
        break;
    }
}
