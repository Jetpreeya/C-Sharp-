using System;

namespace Day11_inheritance
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("My Vehicles!");
            Car car = new Car("Volvo", "V40", 2020, 220);
            Motorcycle mc = new Motorcycle("Suzuki", "X", 2018, 230);
            Console.WriteLine(car.Brand + " " + car.Model + " " + car.Year + " " + car.Speed);
            Console.WriteLine(mc.Brand + " " + mc.Model + " " + mc.Year + " " + mc.Speed);
            Car car2 = new Car("Toyota", "Auris", 2019, 200, 4);
            Console.WriteLine(car2.Brand + " " + car2.Model + " " + car2.Year + " " + car2.Speed + " " + car2.NumberOfWheel);
        }
    }

    class Vehicle : Wheel
    {
        public string Brand { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
        public int Speed { get; set; }
    }
    class Car : Vehicle  // inherits from Vehicle
    {
        public Car(string brand, string model, int year, int speed)
        {
            Brand = brand;
            Model = model;
            Year = year;
            Speed = speed;
        }
        public Car(string brand, string model, int year, int speed, int numberOfWheel)
        {
            Brand = brand;
            Model = model;
            Year = year;
            Speed = speed;
            NumberOfWheel = numberOfWheel;
        }

        //public string Brand { get; set; }
        //public string Model { get; set; }
        //public int Year { get; set; }
        //public int Speed { get; set; }
    }

    class Motorcycle : Vehicle  // inherits from Vehicle
    {
        public Motorcycle(string brand, string model, int year, int speed)
        {
            Brand = brand;
            Model = model;
            Year = year;
            Speed = speed;
        }

        //public string Brand { get; set; }
        //public string Model { get; set; }
        //public int Year { get; set; }
        //public int Speed { get; set; }
    }
    class Wheel
    {
        public int NumberOfWheel { get; set; }
    }
}