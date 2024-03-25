List<int> nums = Console.ReadLine().Split(' ').Select(int.Parse).ToList();

while (true)
{
    bool found = false;
    for (int i = 0; i < nums.Count - 2; i++)
    {
        if (nums[i] == nums[i + 1])
        {
            found = true;
            nums[i] = nums[i] + nums[i + 1];
            nums[i + 1] = int.MinValue;
        }

        nums.RemoveAll(x => x == int.MinValue);
    }
    if(found == false)
    {
        break;
    }
}

Console.WriteLine(String.Join(' ', nums));