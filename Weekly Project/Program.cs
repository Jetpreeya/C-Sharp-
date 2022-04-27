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
            //List 
            //List<Products> product = new List<Products>();
            int index = 0;
            string[] myCategory = new string[10];
            string[] myProducts = new string[10];
            int[] myPrice = new int[10];
            while (true)
            {
                Console.Write("Add a category:");
                string data = Console.ReadLine();
                if (data.ToLower().Trim() == "q") //exit with type q
                {
                    break;
                }
                myCategory[index] = data;
                index++;

                Console.Write("Add a product:");
                string product = Console.ReadLine();
                if (data.ToLower().Trim() == "q") //exit with type q
                {
                    break;
                }
                myProducts[index] = product;
                index++;

                Console.Write("Add a price:");
                int price = Convert.ToInt32(Console.ReadLine());
                if (data.ToLower().Trim() == "q") //exit with type q
                {
                    break;
                }
                myPrice[index] = price;
                index++;
            }

            //Show the Category list
            Array.Resize(ref myCategory, index);
            Console.WriteLine("My Category List");
            Console.WriteLine("---------------");
            for (int i = 0; i < myCategory.Length; i++)
            {
                Console.WriteLine(myCategory[i]);
            }
            //Show the products list
            Array.Resize(ref myProducts, index);
            Console.WriteLine("My Products List");
            Console.WriteLine("---------------");
            for (int i = 0; i < myProducts.Length; i++)
            {
                Console.WriteLine(myProducts[i]);
            }

            //Show the price list
            Array.Resize(ref myPrice, index);
            Console.WriteLine("My Price List");
            Console.WriteLine("---------------");
            for (int i = 0; i < myPrice.Length; i++)
            {
                Console.WriteLine(myPrice[i]);

            }


            {
                Console.WriteLine("My Products!");
                List<Products> cars = new List<Products>();
                Products products1 = new Products("Food","Rice", 22);
                cars.Add(products1);

                cars.Add(new Products("Car", "Saab", 19500));

                List<Products> extraCars = new List<Products>
            {
                new Products("Fruit", "Orange", 30),
                new Products("Fruit", "Grape", 45)
            };

                cars.AddRange(extraCars); //can add more than one

                cars.AddRange(new List<Products>
            {
                new Products("Kichken","Spoon", 210),
                new Products("Animal","Duck", 170)
            });

                int highPrice = cars.Max(car => car.Price);
                int lowPrice = cars.Min(car => car.Price);
                double averagePrice = cars.Average(car => car.Price);
                int sumOfAllPrice = cars.Sum(car => car.Price);
                int countCars = cars.Count();

                int countVolvo = cars.Where(car => car.Category.Contains("Fruit")).Count();


                //Console.WriteLine("My Product - Unsorted");
                Console.WriteLine("____________________________");
                Console.WriteLine("Category".PadRight(10)+ "Brand".PadRight(10) + "Price".PadRight(10));
                Console.WriteLine("____________________________");
                foreach (Products car in cars)
                {
                    Console.WriteLine(car.Category.PadRight(10)+ car.Brand.PadRight(10) + car.Price.ToString().PadRight(10));
                }
                // Will be continouse 27/04/2022
                Console.WriteLine("Total Sum is ");

                Console.WriteLine("____________________________");
                Console.WriteLine("My Cars - Sorted by Brand");
                Console.WriteLine("____________________________");

                List<Products> sortedCars = cars.OrderBy(car => car.Brand).ToList();
                Console.WriteLine("Category".PadRight(10) + "Brand".PadRight(10) + "Price".PadRight(10));
                foreach (Products car in sortedCars)
                {
                    Console.WriteLine(car.Category.PadRight(10) + car.Brand.PadRight(10) + car.Price.ToString().PadRight(10));
                }

                Console.WriteLine("____________________________");
                Console.WriteLine("My product - Filtered by Price between 1-300");
                Console.WriteLine("____________________________");

                List<Products> filteredCars = cars.Where(car => car.Price >= 1 && car.Price <= 300).ToList();
                Console.WriteLine("Category".PadRight(10) + "Brand".PadRight(10) + "Price".PadRight(10));
                foreach (Products car in filteredCars)
                {
                    Console.WriteLine(car.Category.PadRight(10) + car.Brand.PadRight(10) + car.Price.ToString().PadRight(10));
                }

                Console.WriteLine("____________________________");
                Console.WriteLine("The sum of all products");
                Console.WriteLine("____________________________");

                //Will be co
                List<Products> SumCars = cars;
                Console.WriteLine("Price".PadRight(10));
                foreach (Products car in SumCars)
                {
                    Console.WriteLine(car.Price.ToString().PadRight(10));
                }

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

