using System;

namespace Week17.project.Jetpreeya
{
    internal class Program
    {
        static void Main(string[] args)
        //{
        //    //Q1
        //    Console.WriteLine("Add Your products and close with Exit");
        //    int index = 0;
        //    string[] myProducts = new string[10];
        //    while (true)
        //    {
        //        Console.WriteLine("Add a product:");
        //        string data = Console.ReadLine();
        //        if (data == "exit")
        //        {
        //            break;
        //        }
        //    myProducts[index] = data;
        //        index++;
        //    }
        //    Array.Resize(ref myProducts, index);
        //    Console.WriteLine("---------------");
        //    Console.WriteLine("This is your products list:");

        //    for (int i = 0; i < myProducts.Length; i++)
        //    {
        //        Console.WriteLine("*"+myProducts[i]);
        //    }
        {
            ////Q2 To lower case 
            //Console.WriteLine("Add Your products and close with Exit");
            //int index = 0;
            //string[] myProducts = new string[10];
            //while (true)
            //{
            //    Console.WriteLine("Add a product:");
            //    string data = Console.ReadLine();
            //    if (data.ToLower().Trim() == "exit")
            //    {
            //        break;
            //    }
            //    myProducts[index] = data;
            //    index++;
            //}
            //Array.Resize(ref myProducts, index);
            //Console.WriteLine("---------------");
            //Console.WriteLine("This is your products list:");

            //for (int i = 0; i < myProducts.Length; i++)
            //{
            //    Console.WriteLine("*"+myProducts[i]);
            //}
                
            //Q3
                    Console.WriteLine("Add Your products and close with Exit");
                    int index = 0;
                    string[] myProducts = new string[10];

                    while (true)
                    {
                        Console.Write("Add a product:");
                        string inputData = Console.ReadLine();
                        string[] inputPart = inputData.Split("-");

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
                          
                            bool check = true;
                            for (int i = 0; i < inputPart[0].Length; i++)
                            {
                                if (!char.IsUpper(inputPart[0], i))
                                {
                                    check = false;
                                    Console.ForegroundColor = ConsoleColor.Red;
                                    Console.WriteLine("The left part of the product have to be number.");
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


            Console.ReadLine();
        }
    }
}
