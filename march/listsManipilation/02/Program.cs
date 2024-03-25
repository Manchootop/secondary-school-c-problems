namespace _02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();

            int n = numbers.RemoveAll(x => x < 0);

            if(n == 0)
            {
                Console.WriteLine($"Empty");
            }
            else
            {
                Console.WriteLine(String.Join(' ', numbers));
            }
        }
    }
}