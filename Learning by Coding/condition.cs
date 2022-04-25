using System;

namespace ConsoleApp1_condition_20220421
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Add a car and close with Exit!");
            int index = 0;
            string[] myCars = new string[10];
            while (true)
            {
                Console.WriteLine("Add a car :");
                string data = Console.ReadLine();
                if(data.ToLower().Trim() == "exit")
                {
                    break;
                }
                myCars[index] = data;
                index++;
            }
            Array.Resize(ref myCars, index);
            Console.WriteLine("My Cars with for loop ");
            Console.WriteLine("---------------");
            //Console.WriteLine(myCars[0]);
            for (int i = 0; i < myCars.Length; i++)
            {
                Console.WriteLine(myCars[i]);
            }

            Array.Sort(myCars);
            Console.WriteLine("My Cars with foreach loop ");
            Console.WriteLine("---------------");
            //Console.WriteLine(myCars[0]);
            foreach(string car in myCars)
            {
                Console.WriteLine(car);
            }

            Console.ReadLine();
        }
    }
}
