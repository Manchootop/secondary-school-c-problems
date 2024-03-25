List<int> nums = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
List<int> perfectSquares = new List<int>();

foreach(int num in nums)
{
    if(Math.Sqrt(num) % 1 == 0)
    {
        perfectSquares.Add(num);
    }
}

perfectSquares.Sort();
perfectSquares.Reverse();

Console.WriteLine(String.Join(' ', perfectSquares));
