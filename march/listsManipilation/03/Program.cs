namespace _03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> numsStr = Console.ReadLine().Split('|').ToList();
            List<int> nums = new List<int>();

            for (int i = numsStr.Count - 1; i >= 0; i--)
            {
                string el = numsStr[i];
                foreach(int num in el.Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray())
                {
                    nums.Add(num);
                }
            }

            Console.WriteLine(String.Join(' ', nums));
        }
    }
}