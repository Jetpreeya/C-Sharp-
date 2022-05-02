using System;
using System.Collections.Generic;
using System.Linq;

namespace Friday_CheckPoint2
{
   internal class Program
    {
        static void Main(string[] args)
        {
            List <Products> Pr =new List <Products> (); // Created the list for the object
            Console.WriteLine("Add a product and exit with q!");
            while (true)
            {
                Console.Write("Add a category:");
                string category = Console.ReadLine();
                if (string.IsNullOrEmpty(category))
                {
                    Console.WriteLine("Please input the category");
                }
                if (category.ToLower().Trim() == "q") //exit with type q
                {
                    Console.WriteLine("Are you sure you want to exit?");
                    break;
                }                
                Console.Write("Add a product:");
                string brand = Console.ReadLine();
                if (string.IsNullOrEmpty(brand))
                {
                    Console.WriteLine("Please input the product");
                }
                if (brand.ToLower().Trim() == "q") //exit with type q
                {
                    break;
                }

                Console.Write("Add a price:");
                string price =Console.ReadLine();
                if (string.IsNullOrEmpty(price))
                {
                    Console.WriteLine("Please input the price");
                }
                if (price.ToLower().Trim() == "q") //exit with type q
                {
                    break;
                }

                    Pr.Add(new Products(category, brand, int.Parse(price))); // ADD Object to the list

                Console.WriteLine("____________________________");
                Console.WriteLine("Category".PadRight(10) + "Brand".PadRight(10) + "Price".PadRight(10));

                List<Products> sortedProduct = Pr.OrderBy(item => item.Price).ToList(); // List from lower price to higher price
                //Sum of the products
                int sumOfAllPrice = Pr.Sum(product => product.Price); //LINQ
                Console.WriteLine("____________________________");
                foreach (var product in sortedProduct)
                {
                    Console.WriteLine(product.Category.PadRight(10) + "|" + product.Brand.PadRight(10) + "|" + product.Price.ToString().PadRight(10));
                }
                Console.WriteLine("____________________________");
                Console.WriteLine("Total Sum is " + Pr.Sum(product => product.Price));
            }        
            Console.WriteLine("Press enter to continue...");
            Console.ReadLine();
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
