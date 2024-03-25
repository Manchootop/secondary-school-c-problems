namespace _04
{
    internal class Program
    {
        static void Main(string[] args)
        {

            List<int> nums = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            int[] data = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            int bomb = data[0];
            int power = data[1];

            int bombIndex = nums.IndexOf(bomb);

            while (true)
            {
                int leftIndex = bombIndex - power;
                if (leftIndex < 0)
                {
                    leftIndex = 0;
                }

                int rightIndex = bombIndex + power;
                if (rightIndex >= nums.Count)
                {
                    rightIndex = nums.Count - 1;
                }

                for (int i = leftIndex; i <= rightIndex; i++)
                {
                    nums[i] = int.MinValue;
                }

                bombIndex = nums.IndexOf(bomb);
                if (bombIndex < 0)
                {
                    break;
                }
            }

            nums.RemoveAll(x => x == int.MinValue);

            Console.WriteLine();
            Console.WriteLine(nums.Sum());
        }
    }
}