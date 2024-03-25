List<int> nums = Console.ReadLine().Split(' ').Select(int.Parse).ToList();

while (true)
{
    string[] command = Console.ReadLine().Split(' ').ToArray();
    if (command[0].ToLower() == "odd")
    {
        Console.WriteLine(String.Join(' ', nums.Where(x => x % 2 != 0)));
        break;
    }
    else if(command[0].ToLower() == "even")
    {
        Console.WriteLine(String.Join(' ', nums.Where(x => x % 2 == 0)));
        break;
    }

    else if (command[0].ToLower() == "delete")
    {
        int element = int.Parse(command[1]);
        nums.RemoveAll(x => x == element);
    }

    else if (command[0].ToLower() == "insert")
    {
        int element = int.Parse(command[1]);
        int index = int.Parse(command[2]);
        nums.Insert(index, element);
    }
}