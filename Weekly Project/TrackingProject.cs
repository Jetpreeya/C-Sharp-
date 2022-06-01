using System;
using System.Collections.Generic;
using System.Linq;
using System.Data.SqlClient;


string ConnectionString = @"Data Source = S4D08; Initial Catalog = AssetTracking; Integrated Security = True";

SqlConnection Connection = new SqlConnection(ConnectionString);
Connection.Open();

SqlCommand Command = new SqlCommand("select * from Products", Connection);

var Result = Command.ExecuteReader();

while (Result.Read())
{
   
    var ProductID = Result["ProductID"].ToString();
    var TypeProduct = Result["TypeProduct"].ToString();
    var Brand = Result["Brand"].ToString();
    var Model = Result["Model"].ToString(); 
    var Office = Result["Office"].ToString(); 
    var Purchase = Result["Purchase"].ToString(); 
    var PriceByUSD = Result["PriceByUSD"].ToString(); 
    var Currency = Result["Currency"].ToString(); 
    var LocalPrice = Result["LocalPrice"].ToString();

    Console.WriteLine(ProductID + ": " + TypeProduct.PadRight(15) + ": " + Brand.PadRight(15) + ": " + Model.PadRight(18)+ ": " + Office.PadRight(15) + ": " + Purchase.PadRight(20) + ": " + PriceByUSD.PadRight(10) + ": " + Currency.PadRight(15) + ":" + LocalPrice.PadRight(5));
}

Connection.Close();

namespace MiniProject_AssetTracking
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Mini Project 1");
            Console.WriteLine("----------------------------------------------------------------------------------------------------------");
            Console.WriteLine("Type".PadRight(10) + " |" + "Brand".PadRight(10) + " |" + "Model".PadRight(20) + " |" + "Office".PadRight(10) + " |" + "Purchase Date".PadRight(15) + " |" + "Price in USD".PadRight(15) + " |" + "Currency".PadRight(15) + " |" + "Local Price Today");
            Console.WriteLine("----------------------------------------------------------------------------------------------------------");

            List<Function> ts = new List<Function>(); // The second way to do is Created a list and Add // 
            Phone p1 = new Phone("Phone", "Iphone", "8", "Spain", Convert.ToDateTime("2022-10-11"), 970, "EUR", 801.65);
            Phone p2 = new Phone("Phone", "Samsung", "Note 10", "Korea", Convert.ToDateTime("2022-09-11"), 450, "EUR", 4443.24);
            Phone p3 = new Phone("Phone", "Nokia", "3310", "Finland", Convert.ToDateTime("2017-03-25"), 59, "USD", 590);
            Computer ct1 = new Computer("Computer", "MacBook", "Apple MacBook Air", "USA", Convert.ToDateTime("2000-12-07"), 1150, "EUR", 11488);
            Computer ct2 = new Computer("Computer", "ASUS", "VivoBook", "Taiwan", Convert.ToDateTime("2022-04-18"), 600, "USD", 5590);
            Computer ct3 = new Computer("Computer", "Lenovo", "ThinkPad L480", "China", Convert.ToDateTime("2018-11-02"), 9000, "SEK", 9521.55);
            ts.Add(p1);
            ts.Add(p2);
            ts.Add(p3);
            ts.Add(ct1);
            ts.Add(ct2);
            ts.Add(ct3);

            foreach (Function a in ts)
            {
                Console.WriteLine(a.Type.PadRight(10) + " |" + a.Brand.PadRight(10) + " |" + a.Model.PadRight(20) + " |" + a.Office.PadRight(10) + " |" + a.Year.ToString("yyyy-MM-dd").PadRight(15) + " |" + a.Price.ToString().PadRight(15) + " |" + a.Currency.PadRight(15) + " |" + a.LocalPrice.ToString("C"));
            }

            //Level 2 : Sort by Type of the product (computers first, then phones)
            List<Function> sortedType = ts.OrderBy(any => any.Type).ToList();
            Console.WriteLine("----------------------------------------------------------------------------------------------------------");
            Console.WriteLine("Sort List by Type");
            Console.WriteLine("----------------------------------------------------------------------------------------------------------");
            foreach (Function b in sortedType)
            {
                Console.WriteLine(b.Type.PadRight(10) + " |" + b.Brand.PadRight(10) + " |" + b.Model.PadRight(20) + " |" + b.Office.PadRight(10) + " |" + b.Year.ToString("yyyy-MM-dd").PadRight(15) + " |" + b.Price.ToString().PadRight(15) + " |" + b.Currency.PadRight(15) + " |" + b.LocalPrice.ToString("C"));
                Console.ResetColor();
            }

            //Level 2 : Sorted by purchase date
            List<Function> sortedDate = ts.OrderBy(any => any.Year).ToList();
            Console.WriteLine("----------------------------------------------------------------------------------------------------------");
            Console.WriteLine("Sort List by Date");
            Console.WriteLine("----------------------------------------------------------------------------------------------------------");
            foreach (Function b in sortedDate) // Mark any item *RED* if purchase date is less than 3 months away from 3 years.
            {
                bool test = b.Year > DateTime.Now.AddYears(-3).AddMonths(3);
                if (test) Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(b.Type.PadRight(10) + " |" + b.Brand.PadRight(10) + " |" + b.Model.PadRight(20) + " |" + b.Office.PadRight(10) + " |" + b.Year.ToString("yyyy-MM-dd").PadRight(15) + " |" + b.Price.ToString().PadRight(15) + " |" + b.Currency.PadRight(15) + " |" + b.LocalPrice.ToString("C"));
                Console.ResetColor();
            }
            Console.WriteLine("----------------------------------------------------------------------------------------------------------");
            foreach (Function b in sortedDate) // Items *Yellow* if date less than 6 months away from 3 years
            {
                bool test = b.Year > DateTime.Now.AddYears(-6).AddMonths(3);
                if (test) Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine(b.Type.PadRight(10) + " |" + b.Brand.PadRight(10) + " |" + b.Model.PadRight(20) + " |" + b.Office.PadRight(10) + " |" + b.Year.ToString("yyyy-MM-dd").PadRight(15) + " |" + b.Price.ToString().PadRight(15) + " |" + b.Currency.PadRight(15) + " |" + b.LocalPrice.ToString("C"));
                Console.ResetColor();
            }

            // Sorted first by office
            List<Function> sortedOffice = ts.OrderBy(any => any.Office).ToList();
            Console.WriteLine("----------------------------------------------------------------------------------------------------------");
            Console.WriteLine("The Item sorted by office");
            Console.WriteLine("----------------------------------------------------------------------------------------------------------");
            foreach (Function c in sortedOffice)
            {
                Console.WriteLine(c.Type.PadRight(10) + " |" + c.Brand.PadRight(10) + " |" + c.Model.PadRight(20) + " |" + c.Office.PadRight(10) + " |" + c.Year.ToString("yyyy-MM-dd").PadRight(15) + " |" + c.Price.ToString().PadRight(15) + " |" + c.Currency.PadRight(15) + " |" + c.LocalPrice.ToString("C"));
                Console.ResetColor();
            }

            // Level 3 Currency
            List<Currency> showCurrency = new List<Currency>();
            Currency c1 = new Currency("Spain","EUR", 801.65,"USD", 845.12);
            Currency c2 = new Currency("Sweden", "SEK", 50.65,"USD", 5.06);
            showCurrency.Add(c1);
            showCurrency.Add(c2);

            //Filtered by currency 
            List<Currency> filteredCurrency = showCurrency.Where(c => c.Country == "Spain").ToList();
            Console.WriteLine("----------------------------------------------");
            Console.WriteLine("Office Country".PadRight(15)+ "|" + "Currency".PadRight(15) + "|" + "Price".PadRight(10) + "|" + "USD");
            Console.WriteLine("----------------------------------------------");
            foreach (Currency curren1 in filteredCurrency)
            {
                Console.WriteLine(curren1.Country.PadRight(15) + curren1.Curren.PadRight(15) + curren1.Price.ToString().PadRight(10) + curren1.UsdPrice.ToString());
            }
            List<Currency> filteredCurrency1 = showCurrency.Where(c => c.Country == "Sweden").ToList();
            foreach (Currency curren2 in filteredCurrency1)
            {
                Console.WriteLine(curren2.Country.PadRight(15) + curren2.Curren.PadRight(15) + curren2.Price.ToString("C").PadRight(10) + curren2.UsdPrice);
            }
        }
    }
    class Function // Function is the main Class
    {
        public string Type { get; set; }
        public string Brand { get; set; }
        public string Model { get; set; }
        public string Office { get; set; }
        public DateTime Year { get; set; }
        public int Price { get; set; }
        public string Currency { get; set; }
        public double LocalPrice { get; set; }
        public string Country { get; set; }
    }
    class Phone : Function  // inherits from Function
    {
        public Phone(string type, string brand, string model, string office, DateTime year, int price, string currency, double localPrice)
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
        public Computer(string type, string brand, string model, string office, DateTime year, int price, string currency, double localPrice)
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
    class Currency  // class for Level 3 
    {
        public Currency(string country, string curren, double price, string usd, double usdprice)
        {
             Country = country;
             Curren = curren;
             Price = price;
            USD = usd;
            UsdPrice = usdprice;
        }
        public string Country { get; set; }
        public string Curren { get; set; }
        public double Price { get; set; }
        public string USD { get; set; }
        public double UsdPrice { get; set; }

    }
}
