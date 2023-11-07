namespace Average_speed
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double first_time = Convert.ToDouble(Console.ReadLine());
            int first_speed = Convert.ToInt32(Console.ReadLine());
            int second_time = Convert.ToInt32(Console.ReadLine());
            int second_speed = Convert.ToInt32(Console.ReadLine());

            double first_distance = first_time * first_speed;
            double second_distance = second_time * second_speed;
            double total_distance = first_distance + second_distance;
            double total_time = first_time + second_time;
            double average_speed = total_distance / total_time;
            Console.WriteLine($"{average_speed:f2}");
        }
    }
}