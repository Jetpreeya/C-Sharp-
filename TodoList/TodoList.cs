using System;
using System.Collections.Generic;
using System.Linq;

namespace TodoList
{
     internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to TODO List");
            Console.WriteLine("You have X tasks todo and Y tasks are done!"); // Maybe use boolean 
            Console.WriteLine("Pick an option :");
            Console.WriteLine("(1) Show task list (by date or project) ");
            Console.WriteLine("(2) Add New Task ");
            Console.WriteLine("(3) Edit Task(update, mark as done, remove) "); /*listTodo.RemoveAt(Something you want to delete);*/ /*for remove*/
            Console.WriteLine("(4) Save and Quit ");

            List<Todo> listTodo = new List<Todo>();
            while (true)
            {
                while (true)
                {
                    Console.Write("Input option: ");
                    string categoryInput = Console.ReadLine();
                    if (categoryInput.ToLower().Trim() == "4") // Optionnumber 4 break =>  Save and Quit
                    {
                        break;
                    }
                    else if (categoryInput.ToLower().Trim() == "2") // Option number 2 
                    {
                        Console.Write("Date (yyyy-MM-dd): ");
                        string date = Console.ReadLine();
                        if (date.ToLower().Trim() == "4")
                        {
                            break;
                        }

                        DateTime dt = Convert.ToDateTime(date);
                        Console.Write("List order number: ");
                        string id = Console.ReadLine();
                        if (id.ToLower().Trim() == "4")
                        {
                            break;
                        }
                        int Id = Convert.ToInt32(id);
                        Console.Write("Your List: ");
                        string name = Console.ReadLine();
                        if (name.ToLower().Trim() == "4")
                        {
                            break;
                        }
                        Todo list = new Todo(dt, Id, name);
                        listTodo.Add(list);
                    }
                    else if (categoryInput.ToLower().Trim() == "1") // Option number 1 
                    {
                        List<Todo> sortedByDate = listTodo.OrderBy(personn => personn.Dt).ToList();
                        Console.WriteLine("Show task list (by date)");
                        Console.WriteLine("-----------------------------------------------");
                        Console.WriteLine("Date".PadRight(20) + "|" + "Id".PadRight(10) + "|" + "List".PadRight(10));
                        Console.WriteLine("-----------------------------------------------");
                        foreach (Todo person in sortedByDate)
                        {
                            Console.WriteLine(person.Dt.ToString("yyyy-MM-dd").PadRight(20) + "|" + person.OrderNum.ToString().PadRight(10) + "|" + person.List.PadRight(10));
                        }
                    }
                    else if (categoryInput.ToLower().Trim() == "3") // Option number 3 remove // will be continouse here. use RemoveAt
                    {
                        Console.WriteLine("Which list do you want to delete ?");
                        string removeInput = Console.ReadLine();
                        if (removeInput == "1")
                        {
                            listTodo.RemoveAt(0); // Remove at Index 2 
                            Console.WriteLine("No you delete Todo list number 1");
                        }
                        else if (removeInput == "2")
                                {
                            listTodo.RemoveAt(1); // Remove at Index 2 
                            Console.WriteLine("No you delete Todo list number 1");
                        }
                        else if (removeInput == "3")
                        {
                            listTodo.RemoveAt(2); // Remove at Index 2 
                            Console.WriteLine("No you delete Todo list number 3");
                        }
                        List<Todo> sortedByDate = listTodo.OrderBy(personn => personn.Dt).ToList();
                        Console.WriteLine("Show task list (by date)");
                        Console.WriteLine("-----------------------------------------------");
                        Console.WriteLine("Date".PadRight(20) + "|" + "Id".PadRight(10) + "|" + "List".PadRight(10));
                        Console.WriteLine("-----------------------------------------------");
                        foreach (Todo person in sortedByDate)
                        {
                            Console.WriteLine(person.Dt.ToString("yyyy-MM-dd").PadRight(20) + "|" + person.OrderNum.ToString().PadRight(10) + "|" + person.List.PadRight(10));
                        }
                    }
                }

                List<Todo> sortedDate = listTodo.OrderBy(personn => personn.Dt).ToList();
                Console.WriteLine("-----------------------------------------------");
                Console.WriteLine("Date".PadRight(20) + "|" + "Id".PadRight(10) + "|" + "List".PadRight(10));
                Console.WriteLine("-----------------------------------------------");
                foreach (Todo person in sortedDate)
                {
                    Console.WriteLine(person.Dt.ToString("yyyy-MM-dd").PadRight(20) + "|" + person.OrderNum.ToString().PadRight(10) + "|" + person.List.PadRight(10));
                }
                Console.ReadLine();
            }
        }
        class Todo
        {
            public Todo(DateTime dt, int num, string list)
            {
                Dt = dt;
                OrderNum = num;
                List = list;
            }
            public DateTime Dt { get; set; }
            public int OrderNum { get; set; }
            public string List { get; set; }
        }
    }
}
