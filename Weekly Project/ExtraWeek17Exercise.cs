using System;

namespace Extra_Exercise_20220421
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Q2 Random number and sum
            //Random random = new Random();
            //int num1 = random.Next(1, 100);
            //int num2 = random.Next(1, 100);
            //int num3 = random.Next(1, 100);
            //int num4 = random.Next(1, 100);
            //int num5 = random.Next(1, 100);

            //int sum =num1+num2+num3+ num4+num5;

            //Console.WriteLine(num1);
            //Console.WriteLine(num2);
            //Console.WriteLine(num3);
            //Console.WriteLine(num4);
            //Console.WriteLine(num5);
            //Console.WriteLine(sum);
            {

                //q3 classify number
                //Console.Write("enter a number: ");
                //int num = int.Parse(Console.ReadLine());
                //if (num > 0)
                //{
                //    Console.WriteLine("this is a positive number ");
                //}
                //if (num < 0)
                //{
                //    Console.WriteLine("this is a negative number");
                //}

                //Q4

                //Console.Write("enter a number: ");
                //int index = 0;
                //string[] mycars = new string[10];
                //{
                //    string data = Console.ReadLine();
                //    {
                //        mycars[index] = data;
                //        index++;
                //    }
                //    Random random = new Random();
                //    for (int i = 0; i < 10; i++)
                //    { 
                //    Console.WriteLine(random.Next(1, 100));
                //    }
                //}

                Console.WriteLine("Add Your products and close with Exit");
                int index = 0;
                string[] myProducts = new string[10];

                while (true)
                {
                    Console.Write("Add a product:");
                    string inputData = Console.ReadLine();
                    string[] inputPart = inputData.Split("-");

                    //foreach (string s in inputPart)
                    //{
                    //    Console.WriteLine(s);
                    //}

                    if (inputData.ToLower().Trim() == "exit")
                    {
                        break;
                    }

                    if (string.IsNullOrEmpty(inputData))
                    {
                        Console.WriteLine("Please input the product list");
                    }
                    else
                    {

                        bool check = char.IsLetter(inputPart, i);
                        for (int i = 0; i < inputPart[0].Length; i++)
                        {
                            if (!char.IsUpper(inputPart[0], i))
                            {
                                check = false;
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.WriteLine("The right part of the product have to be number.");
                                break;
                            }
                        }

                        if (check && int.TryParse(inputPart[1], out int second) && second >= 200 && second <= 500)
                        {
                            myProducts[index] = inputData;
                            index++;
                        }
                        else
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("The number have to be between 200 and 500");
                        }
                    }
                }
                Array.Resize(ref myProducts, index);
                Console.WriteLine("---------------");
                Console.WriteLine("This is your products list:");

                for (int i = 0; i < myProducts.Length; i++)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("*" + myProducts[i]);
                }

            }

            Console.ReadKey();

        }
    }
}