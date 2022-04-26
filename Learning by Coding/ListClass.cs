using System;
using System.Collections.Generic;

namespace Day6.listClass
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Cars!");
            List<string> carBrands = new List<string>();
            carBrands.Add("Toyota");
            carBrands.Add("Volvo");
            foreach(string carBrand in carBrands)
            {
                Console.WriteLine(carBrand);
            }
            List<Car> cars = new List<Car>();

            Car car1 = new Car("Toyota", "Auris");
            car1.Year = 2010;
            Car car2 = new Car("Volvo", "V40");
            car2.Year = 2018;

            Car car3 = new Car("Audi", "A4", 2020);
            //carBrands.Add(carl);
            cars.Add(car1);
            cars.Add(car2);
            cars.Add(car3);

            
            Console.WriteLine("-----------------");
            foreach(Car car in cars)
            {
                Console.WriteLine(car.Brand + " " + car.Model+ " " + car.Year);
            }

            Console.WriteLine("-----------------");
            foreach (var car in cars)
            {
                Console.WriteLine(car.Brand + " " + car.Model + " " + car.Year);
            }

        }
        class Car
        {
            public Car(string brand, string model)
            {
                Brand = brand;
                Model = model;
            }

            public Car(string brand, string model, int year) 
            {
                Brand = brand;
                Model = model;
                Year = year;
            }

            public string Brand { get; set; }
            public string Model { get; set; }
            public int Year { get; set; }   


        }
    }
}
