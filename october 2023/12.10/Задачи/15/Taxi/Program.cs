namespace Taxi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string month = Console.ReadLine();
            string timeOfTheDay = Console.ReadLine();
            double travelled_km = Convert.ToDouble(Console.ReadLine());

            double output = 0.0;
            switch (month)
            {
                case "Jan":
                case "Feb":
                case "March":
                case "Apr":
                    if (timeOfTheDay == "Day")
                    {
                        output = travelled_km * 0.81;
                    }
                    else
                    {
                        output = travelled_km * 1;
                    }
                    break;
                case "May":
                case "June":
                case "July":
                case "Aug":
                    if (timeOfTheDay == "Day")
                    {
                        output = travelled_km * 0.91;
                    }
                    else
                    {
                        output = travelled_km * 1.05;
                    }
                    break;
                case "Sept":
                case "Oct":
                case "Nov":
                case "Dec":
                    if (timeOfTheDay == "Day")
                    {
                        output = travelled_km * 0.85;
                    }
                    else
                    {
                        output = travelled_km * 1.03;
                    }
                    break;
            }
            Console.WriteLine($"Total cost: {output:f2}lv.");
        }
    }
}