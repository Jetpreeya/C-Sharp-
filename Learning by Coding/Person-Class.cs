using System;

namespace Day6_personClass
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Person!");
            Person person1 = new Person("John", 45);
            Person person2 = new Person();
            person2.setName("Veronica");
            person2.setAge(35);

            Console.WriteLine(person1.toString());
            Console.WriteLine(person2.toString());
        }
    }

    class Person
    {
        private string name;
        private int age;

        public Person()
        { 
        }

        public Person(string name, int age)
        {
            this.name = name;
            this.age = age;
        }
        public string setName(string name)
        { this.name = name; return this.name; }

        public string getName()
        { return this.name; }

        public  int setAge(int age)
        { this.age = age; return this.age; }

        public int getAge()
        { return this.age; }

        public string toString()
        {
            return this.name + " " + this.age;
        }
    }
}
