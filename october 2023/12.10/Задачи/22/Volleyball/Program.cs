namespace Volleyball
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string year = Console.ReadLine();
            int p = Convert.ToInt32(Console.ReadLine());
            int h = Convert.ToInt32(Console.ReadLine());

            double weekendsInSofia = 48 - h;
            double SaturdayGamesInSofia = weekendsInSofia * 3 / 4;
            double gamesInSofiaOnAHoliday = p * 2 / 3;
            double totalGames= SaturdayGamesInSofia + h + gamesInSofiaOnAHoliday;
            if(year == "leap")
            {
                totalGames *= 1.15;
            }
            Console.WriteLine(Math.Floor(totalGames));
        }
    }
}