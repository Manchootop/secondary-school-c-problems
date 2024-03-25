List<int> nums = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
int[] data = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

int elementsToTakeFromFirst = data[0];
int elementsToDeleteFromFirst = data[1];
int lookupNum = data[2];

List<int> lookupList = new List<int>();
for (int i = 0; i < elementsToTakeFromFirst; i++)
{
    lookupList.Add(nums[i]);
}

for (int i = 0; i < elementsToDeleteFromFirst; i++)
{
    lookupList.RemoveAt(0);
}

if (lookupList.Contains(lookupNum))
{
    Console.WriteLine("YES!");
}

else
{
    Console.WriteLine("NO!");
}