namespace Running
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int easyDays = Convert.ToInt32(Console.ReadLine());
            int minutes = 0, hours = 0, diff =0;

            int hardDays = 365 - easyDays;
            int runningTime = easyDays * 55 + hardDays * 115;

            if (runningTime > 40000)
            {
                Console.WriteLine("Too much running!");
                diff = runningTime - 40000;
                hours = diff / 60;
                minutes = diff % 60;
                Console.WriteLine($"Too hard to run for another {hours} hours and {minutes} minutes.");
            }
            else
            {
                Console.WriteLine("Great training!");
                diff = 40000 - runningTime;
                hours = diff / 60;
                minutes = diff % 60;
                Console.WriteLine($"She can run for {hours} hours and {minutes} minutes more.");
            }
        }
    }
}