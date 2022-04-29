using System;
using System.Collections.Generic;
using System.Linq;

namespace Friday_CheckPoint2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List <Products> Pr =new List <Products> ();
            Console.WriteLine("Add a product and exit with q!");
            while (true)
            {
                Console.Write("Add a category:");
                string category = Console.ReadLine();
                if (category.ToLower().Trim() == "q") //exit with type q
                {
                    break;
                }                
                Console.Write("Add a product:");
                string brand = Console.ReadLine();
                if (brand.ToLower().Trim() == "q") //exit with type q
                {
                    break;
                }

                Console.Write("Add a price:");
                string price =Console.ReadLine();
                if (price.ToLower().Trim() == "q") //exit with type q
                {
                    break;
                }

                Pr.Add(new Products(category, brand, int.Parse(price)));

                Console.WriteLine("____________________________");
                Console.WriteLine("Category".PadRight(10) + "Brand".PadRight(10) + "Price".PadRight(10));
                Console.WriteLine("____________________________");
                foreach (Products item in Pr)
                {
                    Console.WriteLine(item.Category.PadRight(10) + item.Brand.PadRight(10) + item.Price.ToString().PadRight(10));
                }

                //Sum of the products
                Console.WriteLine("____________________________");
                Console.WriteLine("The sum of all products");
                Console.WriteLine("Price".PadRight(10));
                foreach (Products item in Pr)
                {
                    Console.WriteLine(item.Price.ToString().PadRight(10));
                }
            }
        }
        class Products
        {
            public Products(string category, string brand, int price)
            {
                Category = category;
                Brand = brand;
                Price = price;
            }
            public string Category { get; set; }
            public string Brand { get; set; }
            public int Price { get; set; }
        }
    }
}
