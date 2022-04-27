using System;
using System.Collections.Generic;
using System.Linq;

namespace Day7_list_link_class
{
    internal class Program
    {
        public static object List { get; private set; }

        static void Main(string[] args)
        {
            Console.WriteLine("My Cars!");
            List<Car> cars = new List<Car>();
            Car car1 = new Car("Toyota", "Auris", 2020, 220);
            cars.Add(car1);
            cars.Add(new Car("Sabb", "900T", 1985, 195));

            List<Car> extraCars = new List<Car>
            {
                new Car("Opel", "Vectra", 2000, 200),
                new Car("Volvo", "V60", 2019, 220) 
            };
            cars.AddRange(extraCars); //Can add more than one

            cars.AddRange(new List<Car>
                {
                new Car("Mercedes", "D200", 1986, 210),
                new Car("Volvo","V90",1990,230)
            });

            int highSpeed = cars.Max(car => car.Speed);
            int lowSpeed = cars.Min(car => car.Speed);
            double averageSpeed = cars.Average(car => car.Speed);
            int sumOfAllSpeed = cars.Sum(car => car.Speed);
            int countCars = cars.Count();
            int countVolvo = cars.Where(car => car.Brand.Contains("volvo")).Count();

            Console.WriteLine("My Cars - Unsorted");
            Console.WriteLine("Brand".PadRight(10) + "Modal".PadRight(10) + "Year".PadRight(10) + "Speed");
            foreach(Car car in cars) // PadRight will give a space between 2 string
            {
                Console.WriteLine(car.Brand.PadRight(10)+ car.Modal.PadRight(10)+ car.Year.ToString().PadRight(10)+car.Speed);
            }

            Console.WriteLine("------------------");
            Console.WriteLine("My Cars - Sorted by Brand"); 
            Console.WriteLine("------------------");
            List<Car> sortedCars = cars.OrderBy(car => car.Brand).ToList();
            Console.WriteLine("Brand".PadRight(10) + "Modal".PadRight(10)+ "Year".PadRight(10) + "Speed");
            foreach (Car car in cars) // PadRight will give a space between 2 string 
            {
                Console.WriteLine(car.Brand.PadRight(10) + car.Modal.PadRight(10) + car.Year.ToString().PadRight(10) + car.Speed);
            }
            Console.WriteLine("------------------");
            Console.WriteLine("My Cars - Sorted by Year between 1980-2000");
            Console.WriteLine("------------------");
            List<Car> filterCars = cars.Where(car => car.Year >= 1980 && car.Year <= 2000).ToList();
            Console.WriteLine("Brand".PadRight(10) + "Modal".PadRight(10) + "Year".PadRight(10) + "Speed");
            foreach (Car car in filterCars) // PadRight will give a space between 2 string
            {
                Console.WriteLine(car.Brand.PadRight(10) + car.Modal.PadRight(10) + car.Year.ToString().PadRight(10) + car.Speed);
            }
            Console.ReadLine();
        }
    }


    //class Car
    //{
    //    public Car(string brand, string modal, int year, int speed)
    //    {
    //        Brand = brand;
    //        Modal = modal;
    //        Year = year;
    //        Speed = speed;
    //    }

    //    public string Brand { get; set; }
    //    public string Modal { get; set; }
    //    public int Year { get; set; }
    //    public int Speed { get; set; }
    //}
}
