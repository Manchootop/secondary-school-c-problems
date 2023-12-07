using System;

namespace _1
{
     class Car
     {
        public string Make { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
     }
    class Program
    {
        static void Main(string[] args)
        {
            Car car = new Car();
            car.Make = "VW";
            car.Model = "MK3";
            car.Year = 1992;

            Console.WriteLine($"Make: {car.Make}\nModel: {car.Model}\nYear: {car.Year}");
        }
    }
}
