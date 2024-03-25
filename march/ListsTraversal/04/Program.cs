List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();
int sum = 0;

foreach(int num in numbers)
{
    int reversedNum = int.Parse(String.Join("", num.ToString().Reverse()));
    sum += reversedNum;
}

Console.WriteLine(sum); 