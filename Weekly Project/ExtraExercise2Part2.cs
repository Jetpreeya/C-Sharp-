using System;
using System.Collections.Generic;

namespace ExtraExercise2Part2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Extra Exercise 2 Person");
            Person ada = new Person("Ada Lovelace", "24 Maddox St. London W1S 2QN");
            Console.WriteLine(ada.Name + " " + ada.Adress);
            Person esko = new Person("Esko Ukkonen", "Mannerheimintie 15 00100 Helsinki");
            Console.WriteLine(esko.Name + " " + esko.Adress );
            Person ollie = new Person("Ollie", "6381 Hollywood Blvd. Los Angeles 90028");
            Console.WriteLine(ollie.Name + " " + ollie.Adress); // Part 2 
            Console.WriteLine("--------------------------------------------");
            int number = 0; //Part3 
            while (number < 3)
            {
                Console.WriteLine(ollie.Name + " " + ollie.Adress);
                Console.WriteLine("Study credits " + number);
                number++;
            }

            Console.WriteLine("--------------------------------------------"); // Part4 
            Teacher ad = new Teacher("Ada Lovelace", "24 Maddox St. London W1S 2QN",1200);
            Console.WriteLine(ad.Name + " " + ad.Adress + " " + "salary " + ad.Salary + " Euro/month ");
            Teacher esk = new Teacher("Esko Ukkonen", "Mannerheimintie 15 00100 Helsinki", 5400);
            Console.WriteLine(esk.Name + " " + esk.Adress + " " + "salary "+ esk.Salary + " Euro/month ");
            int i = 25; //Part3 
            while (i<26)
            {
                Console.WriteLine("--------------------------------------------");
                Console.WriteLine(ollie.Name + " " + ollie.Adress);
                Console.WriteLine("Study credits " + i);
                 i = i + 1;
            }
            Console.WriteLine("--------------------------------------------");
            List<Person> persons = new List<Person>();  // Part 5 
            List<Teacher> teachers = new List<Teacher>();
            teachers.Add(new Teacher("Ada Lovelace", "24 Maddox St. London W1S 2QN", 1200));
            persons.Add(new Person("Ollie", "6381 Hollywood Blvd. Los Angeles 90028"));
            foreach (Person person in persons)
            {
                Console.WriteLine(person.Name + person.Adress);
            }
            foreach (Teacher teacher in teachers)
            {
                Console.WriteLine(teacher.Name + teacher.Adress +" Salary "+ teacher.Salary + " Euro/month ");
            }
        }
    }
    
    class Person
    { 
        public Person(string name, string adress)
        {
            Name = name;
            Adress = adress;
        }
        public string Name { get; set; }
        public string Adress { get; set; }
    }
    class Student : Person
    {
        public Student(string name, string adress,int grade) :base (name,adress)
        {
            Name = name;
            Adress = adress;
            Grade = grade;
        }
        public int Grade { get; set; }
    }
    class Teacher : Person
    {
        public Teacher(string name, string adress, int salary) : base(name, adress)
        {
            Name = name;
            Adress = adress;
            Salary = salary;
        }
        public int Salary { get; set; }

    }
}
