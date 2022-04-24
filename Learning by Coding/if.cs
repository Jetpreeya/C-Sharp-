using System;

namespace ConsoleApp6
{
    class Program
    {
        static void Main (string[] args)
        //{
        //    int counter = 0;
        //    while (counter < 10)
        //    {
        //        Console.WriteLine($"Hello World ! The counter is {counter}");
        //            counter++;
        //    }
        //}
        {
            int sum = 0;
            for (int i = 1; i<=20; i++)
            {
                if (i % 3 == 0)
                { 
                    sum = sum + i; 
                }
            }
            Console.WriteLine($"The sum is {sum}");
        }
    }
}
