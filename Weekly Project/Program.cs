using System;
using System.Collections.Generic;

namespace Day6.ExtraProject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Book List!");

            List<string> bookAuthors = new List<string>();
            bookAuthors.Add("William Shakespeare");
            bookAuthors.Add("Georges Simenon");

            List<string> bookNames = new List<string>();
            bookNames.Add("Pilots Of Next Year");
            bookNames.Add("Creation Of The World");
            foreach (string bookAuthor in bookAuthors)
            {
                Console.WriteLine(bookAuthor);
            }
            Console.WriteLine("__________________");
            foreach (string bookName in bookNames)
            {
               
                Console.WriteLine(bookName);
            }
            Console.WriteLine("__________________");
            Book number1 = new Book("J. K. Rowling", "Harry Potter the Sorcerer's Stone", 223);
           
            Console.WriteLine(number1.toString());
        }
    }

    class Book
    {
        private string author;
        private string name;
        private int pages;

        public Book()
        {
        }

        public Book(string author, string name, int pages)
        {
            this.author = author;
            this.name = name;
            this.pages = pages;
        }
        public string setAuthor(string author)
        { this.author = author; return this.author; }

        public string getAuthor()
        { return this.author; }

        public string setName(string name)
        { this.name = name; return this.name; }

        public string getName()
        { return this.name; }

        public int setPages(int pages)
        { this.pages = pages; return this.pages; }

        public int getPages()
        { return this.pages; }

        public string toString()
        {
            return this.author + " " + this.name + " " + this.pages + " pages";
        }
    }
}
