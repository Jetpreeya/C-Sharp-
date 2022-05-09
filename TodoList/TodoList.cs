using System;

namespace TodoList
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to TODO List");
            Console.WriteLine("You have X tasks todo and Y tasks are done!");
            Console.WriteLine("Pick an option :");
            Console.WriteLine("(1) Show task list (by date or project) ");
            Console.WriteLine("(2) Add New Task ");
            Console.WriteLine("(3) Edit Task(update, mark as done, remove) ");
            Console.WriteLine("(4) Save and Quit ");
        }
    }
}
