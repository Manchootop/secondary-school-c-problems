namespace _01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();

            int lastNum = numbers[numbers.Count - 1];

            numbers.RemoveAll(x => x == lastNum);

            Console.WriteLine(String.Join(' ', numbers));
        }
    }
}