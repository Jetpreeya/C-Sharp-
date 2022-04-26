using System;

namespace Day6.Class.Object
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("My Cars!");
            Car carl = new Car();
            carl.Brand = "Volvo";
            carl.Model = "V40";
            Console.WriteLine(carl.Brand + " " + carl.Model);

            Car car2 = new Car();
            car2.Brand = "Audi";
            car2.Model = "A4";
            Console.WriteLine(car2.Brand+" "+ car2.Model);

            Car car3 = new Car("Opel", "Vectra");
            Console.WriteLine(car3.Brand + " " + car3.Model);

            Console.ReadLine();
        }
    }

    class Car
    {
        //constructor
        public Car()
        {
        }

        //constructor
        public Car(string brand, string model)
        {
            Brand = brand;
            Model = model;
        }

        //fields or properties
        public string Brand { get; set; }
        public string Model { get; set; }



    }
}
