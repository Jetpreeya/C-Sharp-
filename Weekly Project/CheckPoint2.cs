using System;
using System.Collections.Generic;
using System.Linq;

namespace CheckPoint2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Add a product and exit with q!");
            //List Level 1 
            int index = 0;
            string[] myCategory = new string[10];
            string[] myProducts = new string[10];
            int[] myPrice = new int[10];
            while (true)
            {
                { 
                Console.Write("Add a category:");
                string data = Console.ReadLine();
                if (data.ToLower().Trim() == "q") //exit with type q
                {
                    break;
                }
                myCategory[index] = data;
                index++;
                }
                { 
                Console.Write("Add a product:");
                string product = Console.ReadLine();
                if (product.ToLower().Trim() == "q") //exit with type q
                {
                    break;
                }
                myProducts[index] = product;
                index++;
                }
                { 
                Console.Write("Add a price:");
                string Products = Console.ReadLine();
                //int price = Convert.ToInt32(Console.ReadLine());
                //Check that user input price as a number or not   //Level 3 
                bool isInt = int.TryParse(Products, out int prices);
                if (isInt)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine($"{Products} is a number");
                    Array.Resize(ref myProducts, index + 1);
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine($"{Products} is NOT a number");
                }
                Console.ResetColor();
                if (Products.ToLower().Trim() == "q") //exit with type q
                {
                    break;
                }
                }

                // input then show information from user
                Array.Resize(ref myCategory, index);
                Console.WriteLine("My Category List");
                Console.WriteLine("---------------");
                Console.WriteLine("Category".PadRight(10) + "Brand".PadRight(10) + "Price".PadRight(10));
                for (int i = 0; i < myCategory.Length; i++)
                {
                    Console.WriteLine(myCategory[i]);
                }
                //Show the Products list
                Array.Resize(ref myProducts, index);
                Console.WriteLine("My Products List");
                Console.WriteLine("---------------");
                for (int i = 0; i < myProducts.Length; i++)
                {
                    Console.WriteLine(myProducts[i]);
                }

                //Show the Price list
                Array.Resize(ref myPrice, index);
                Console.WriteLine("My Price List");
                Console.WriteLine("---------------");
                for (int i = 0; i < myPrice.Length; i++)
                {
                    Console.WriteLine(myPrice[i]);
                }

                //Show the Products list
            }

            //Show the Products list
            {
                List<Products> products = new List<Products>();
                Products products1 = new Products("Food","Rice", 28);
                products.Add(products1);

                products.Add(new Products("Car", "Saab", 19500));

                List<Products> extraCars = new List<Products>
            {
                new Products("Fruit", "Orange", 30),
                new Products("Fruit", "Grape", 45)
            };
                products.AddRange(extraCars); //can add more than one
                products.AddRange(new List<Products>
            {
                new Products("Kichken","Spoon", 210),
                new Products("Animal","Duck", 170),
                new Products("Room","Bed", 1650)
            });

                int highPrice = products.Max(product => product.Price);
                int lowPrice = products.Min(product => product.Price);
                double averagePrice = products.Average(product => product.Price);
                int sumOfAllPrice = products.Sum(product => product.Price);
                int countCars = products.Count();
                int countVolvo = products.Where(product => product.Category.Contains("Fruit")).Count();

                Console.WriteLine("___________________________________");
                Console.WriteLine("The products list - Sorted by Price");
                Console.WriteLine("___________________________________");

                List<Products> sortedProduct = products.OrderBy(product => product.Price).ToList();
                Console.WriteLine("Category".PadRight(10) + "|" + "Brand".PadRight(10) + "|"  + "Price".PadRight(10));
                foreach (var product in sortedProduct) 
                {
                    Console.WriteLine(product.Category.PadRight(10) +"|"+ product.Brand.PadRight(10) + "|" + product.Price.ToString().PadRight(10));
                }

                {
                Console.WriteLine("___________________________________");
                Console.WriteLine("Total Sum is " + products.Sum(product => product.Price)); // Summary process Level 2 
                Console.WriteLine("___________________________________");
                }
                Console.WriteLine("Press enter to continue...");
                Console.ReadLine();

            }
        }
        //class /*Category*/
        //{
        //    public Category(string type)
        //    {
        //        Type = type;
        //    }

        //    public string Type { get; set; }
        //}
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

