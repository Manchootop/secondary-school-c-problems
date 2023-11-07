//2 1 1 2 3 3 2 2 2 1 222

int[] arr = Console.ReadLine()
    .Split()
    .Select(int.Parse)
    .ToArray();
int counter = 0;
int bestCount = 0;
int number = 0;

for (int i = 0; i <= arr.Length; i++)
{
    if (arr[i] == arr[i + 1])
    {
        counter += 1;
    }
    else
    {
        counter = 1;
    }
    if (counter >= bestCount)
    {
        bestCount = counter;
        number = arr[i];
    }


}
for (int i = 0; i < bestCount; i++)
{
    Console.Write(number + " ");
}