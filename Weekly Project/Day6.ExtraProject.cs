using System;
using System.Collections.Generic;

namespace Day6.ExtraProject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Book List!");

            //List//
            List<Book> book = new List<Book>();

            Book number1 = new Book("J. K. Rowling", "Harry Potter the Sorcerer's Stone", 223);
            Book number2 = new Book("Gabriel García Márquez", "One Hundred Years of Solitude", 202);
            book.Add(number1);
            book.Add(number2);

            Console.WriteLine("-------");
            foreach (var item in book)
            {
                Console.WriteLine("*"+ item.toString());
            }
  
            //Console.WriteLine("---- Book list by String ----");
            //Console.WriteLine(number1.toString());
            //Console.WriteLine(number2.toString());
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
