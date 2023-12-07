using System;
using System.Collections.Generic;

namespace _10
{
    class Driver
    {
        private string name;
        public string Name { get { return this.name; } set { this.name = value; } }

        private int age;
        public int Age { get { return this.age; } set { this.age = value; } }

        private double totalTime;
        public double TotalTime { get { return this.totalTime; } set { this.totalTime = value; } }

        private double speed;
        public double Speed { get { return this.speed; } set { this.speed = value; } }

        public Driver(string name, int age, double totalTime, double speed)
        {
            this.Name = name;
            this.Age = age;
            this.TotalTime = totalTime;
            this.Speed = speed;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Driver> drivers = new List<Driver>();

            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string[] data = Console.ReadLine().Split(' ');

                string name = $"{data[0]} {data[1]}";
                int age = int.Parse(data[2]);
                double totalTime = double.Parse(data[3]);
                double speed = double.Parse(data[4]);

                Driver driver = new Driver(name, age, totalTime, speed);
                drivers.Add(driver);
            }


            double bestTime = double.MaxValue;
            Driver bestDriver = null;

            foreach (Driver driver in drivers)
            {
                if (driver.TotalTime < bestTime)
                {
                    bestTime = driver.TotalTime;
                    bestDriver = driver;
                }
            }

            Console.WriteLine($"DriverName: {bestDriver.Name}\r\n  DriverAge: {bestDriver.Age}\r\n    Time: {bestDriver.TotalTime}\r\n    Speed: {bestDriver.Speed}\r\n");
        }
    }
}
