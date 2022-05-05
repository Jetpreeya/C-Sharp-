using System;
using System.Collections.Generic;
using System.Linq;

namespace MiniProject1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Mini Project 1");
            Console.WriteLine("----------------------------------------------------------------------------------------------");
            Console.WriteLine("Type".PadRight(10) + " |"+ "Brand".PadRight(10) + " |" + "Model".PadRight(20) + " |" + "Office".PadRight(10) + " |" + "Purchase Date".PadRight(15) + " |" + "Price in USD".PadRight(15) + " |" + "Currency".PadRight(15) + " |" + "Local Price Today");
            Console.WriteLine("----------------------------------------------------------------------------------------------");
            //Phone p1 = new Phone("Phone","Iphone", "8","Spain", 2018, 970,"EUR",801.65);
            //Phone p2 = new Phone("Phone", "Samsung", "Note 10", "Korea", 2022, 450, "EUR", 4443.24);
            //Phone p3 = new Phone("Phone", "Nokia", "3310", "Finland", 2017, 59, "USD", 590);
            //Computer ct1 = new Computer("Computer","MacBook", "Apple MacBook Air", "USA", 2022, 1150, "EUR", 11488);
            //Computer ct2 = new Computer("Computer", "ASUS", "VivoBook", "Taiwan", 2022, 600, "USD", 5590);
            //Computer ct3 = new Computer("Computer", "Lenovo", "ThinkPad L480", "China", 2018, 9000, "SEK", 9521.55);
            //Console.WriteLine(p1.Type.PadRight(10) + " |"+ p1.Brand.PadRight(10) + " |" + p1.Model.PadRight(20) + " |" + p1.Office.PadRight(10) + " |" + p1.Year.ToString().PadRight(15) + " |" + p1.Price.ToString().PadRight(15) + " |" + p1.Currency.PadRight(15) + " |" + p1.LocalPrice);
            //Console.WriteLine(ct1.Type.PadRight(10) + " |"+ ct1.Brand.PadRight(10) + " |" + ct1.Model.PadRight(20) + " |" + ct1.Office.PadRight(10) + " |" + ct1.Year.ToString().PadRight(15) + " |" + ct1.Price.ToString().PadRight(15) + " |" + ct1.Currency.PadRight(15) + " |" + ct1.LocalPrice);
            //Console.WriteLine(p2.Type.PadRight(10) + " |" + p2.Brand.PadRight(10) + " |" + p2.Model.PadRight(20) + " |" + p2.Office.PadRight(10) + " |" + p2.Year.ToString().PadRight(15) + " |" + p2.Price.ToString().PadRight(15) + " |" + p2.Currency.PadRight(15) + " |" + p2.LocalPrice);
            //Console.WriteLine(p3.Type.PadRight(10) + " |" + p3.Brand.PadRight(10) + " |" + p3.Model.PadRight(20) + " |" + p3.Office.PadRight(10) + " |" + p3.Year.ToString().PadRight(15) + " |" + p3.Price.ToString().PadRight(15) + " |" + p3.Currency.PadRight(15) + " |" + p3.LocalPrice);
            //Console.WriteLine(ct2.Type.PadRight(10) + " |" + ct2.Brand.PadRight(10) + " |" + ct2.Model.PadRight(20) + " |" + ct2.Office.PadRight(10) + " |" + ct2.Year.ToString().PadRight(15) + " |" + ct2.Price.ToString().PadRight(15) + " |" + ct2.Currency.PadRight(15) + " |" + ct2.LocalPrice);
            //Console.WriteLine(ct3.Type.PadRight(10) + " |" + ct3.Brand.PadRight(10) + " |" + ct3.Model.PadRight(20) + " |" + ct3.Office.PadRight(10) + " |" + ct3.Year.ToString().PadRight(15) + " |" + ct3.Price.ToString().PadRight(15) + " |" + ct3.Currency.PadRight(15) + " |" + ct3.LocalPrice);
            
            List<Function> ts = new List<Function>(); // The second way to do is Created a list and Add // 
            Phone p1 = new Phone("Phone", "Iphone", "8", "Spain", 2018, 970, "EUR", 801.65);
            Phone p2 = new Phone("Phone", "Samsung", "Note 10", "Korea", 2022, 450, "EUR", 4443.24);
            Phone p3 = new Phone("Phone", "Nokia", "3310", "Finland", 2017, 59, "USD", 590);
            Computer ct1 = new Computer("Computer", "MacBook", "Apple MacBook Air", "USA", 2022, 1150, "EUR", 11488);
            Computer ct2 = new Computer("Computer", "ASUS", "VivoBook", "Taiwan", 2022, 600, "USD", 5590);
            Computer ct3 = new Computer("Computer", "Lenovo", "ThinkPad L480", "China", 2018, 9000, "SEK", 9521.55);
            ts.Add(p1);
            ts.Add(p2);
            ts.Add(p3);
            ts.Add(ct1);
            ts.Add(ct2);
            ts.Add(ct3);
            foreach (Function a in ts)
            {
                Console.WriteLine(a.Type.PadRight(10) + " |" + a.Brand.PadRight(10) + " |" + a.Model.PadRight(20) + " |" + a.Office.PadRight(10) + " |" + a.Year.ToString().PadRight(15) + " |" + a.Price.ToString().PadRight(15) + " |" + a.Currency.PadRight(15) + " |" + a.LocalPrice);
            }

            //Filter by less than 3 months 

            List<Function> filteredCars = ts.Where(ts => ts.Year >= 2020 && ts.Year <= 2019).ToList();
            foreach (Function b in filteredCars)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(b.Brand.PadRight(10) + b.Model.PadRight(10) + b.Year.ToString().PadRight(10) + b.Price);
            }
        }
    }
    class Function // Function is the main Class
    {
        public string Type { get; set; }
        public string Brand { get; set; }
        public string Model { get; set; }
        public string Office { get; set; }
        public int Year { get; set; }
        public int Price { get; set; }
        public string Currency { get; set; }
        public double LocalPrice { get; set; }
    }
    class Phone : Function  // inherits from Function
    {
        public Phone(string type,string brand, string model, string office , int year, int price, string currency, double localPrice)
        {
            Type = type;
            Brand = brand;
            Model = model;
            Office = office;
            Year = year;
            Price = price;
            Currency = currency;
            LocalPrice = localPrice;
        }
    }

    class Computer : Function  // inherits from Function
    {
        public Computer(string type, string brand, string model, string office, int year, int price, string currency, double localPrice)
        {
            Type = type;
            Brand = brand;
            Model = model;
            Office = office;
            Year = year;
            Price = price;
            Currency = currency;
            LocalPrice = localPrice;
        }
    }
}
