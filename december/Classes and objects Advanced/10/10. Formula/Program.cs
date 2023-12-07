namespace _10._Formula
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int repeatTimes = int.Parse(Console.ReadLine());
            List<Driver> drivers = new List<Driver>();

            for (int i = 0; i < repeatTimes; i++)
            {
                string[] driverInfo = Console.ReadLine()
                    .Split()
                    .ToArray();

                string firstName = driverInfo[0];
                string lastName = driverInfo[1];
                int age = int.Parse(driverInfo[2]);
                decimal totalTime = decimal.Parse(driverInfo[3]);
                decimal speed = decimal.Parse(driverInfo[4]);

                drivers.Add(new Driver(firstName, lastName, age, totalTime, speed));
            }

            drivers = drivers.OrderBy(d => d.TotalTime).Take(1).ToList();
            drivers.ForEach(d => Console.WriteLine(d));
        }
    }
    class Driver
    {
        public Driver(string firstName, string lastName, int age, decimal totalTime, decimal speed)
        {
            FirstName = firstName;
            LastName = lastName;
            Age = age;
            TotalTime = totalTime;
            Speed = speed;
        }

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public decimal TotalTime { get; set; }
        public decimal Speed { get; set; }

        public override string ToString()
        {
            return $"DriverName: {FirstName} {LastName}\n  DriverAge: {Age}\n\tTime: {TotalTime}\n\tSpeed: {Speed}";
        }
    }
}