using System;
using System.Collections.Generic;
using System.Linq;

namespace DateTimeExercise
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("ADD ID, Birth of Date, Name and close with Exit");
            List<Person> Pr = new List<Person>();

            while (true)
            {
                Console.WriteLine("Enter Your Birth Date: (yyyy-MM-dd): "); //ADD Birth date
                DateTime dt = DateTime.Parse(Console.ReadLine());

                Console.Write("Add Your ID:"); // ADD Name
                int id = Convert.ToInt32(Console.ReadLine());

                Console.Write("Add Your Name:"); // ADD Name
                String name = Console.ReadLine();
                if (name.ToLower().Trim() == "exit")
                {
                    break;
                }

                Pr.Add(new Person(dt, id, name)); 
                Console.WriteLine("____________________________");
                Console.WriteLine("Date(yyyy-MM-dd)" + "  "+ "Id" + "  " + "Name");

                List<Person> sortedBirth = Pr.OrderBy(item => item.BirthDate).ToList();
                foreach (var person in sortedBirth)
                {
                    Console.WriteLine(dt + "  "+ id + "  " + name);
                }

                Console.WriteLine("Press exit + Enter to exit or just press Enter to add more items");
                string decision = Console.ReadLine();
                if (decision.ToLower().Trim() == "exit")
                {
                    break;
                }
                Console.ReadLine();
            }
        }
        class Person
        {
            public Person(DateTime dt, int id, string name)
            {
                BirthDate = dt;
                ID = id;
                Name = name;
            }
            public DateTime BirthDate { get; set; }
            public int ID { get; set; }
            public string Name { get; set; }
            
        }
    }
}
