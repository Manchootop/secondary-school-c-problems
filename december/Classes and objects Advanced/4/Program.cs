using System;

namespace _4_
{
    class Engine
    {
        private int horsePower;
        public int HorsePower { get { return horsePower; } set { horsePower = value; } }

        private double cubicCapacity;
        public double CubicCapacity { get { return cubicCapacity; } set { cubicCapacity = value; } }

        public Engine(int horsePower, double cubicCapacity)
        {
            horsePower = horsePower;
            cubicCapacity = cubicCapacity;
        }
    }
    class Tire
    {
        private int year;
        public int Year { get { return year; } set { year = value; } }

        private double pressure;
        public double Pressure { get { return pressure; } set { pressure = value; } }

        public Tire(int year, double pressure)
        {
            Year = year;
            Pressure = pressure;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            
        }
    }
}
