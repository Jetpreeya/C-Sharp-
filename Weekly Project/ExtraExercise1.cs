using System;

namespace ExtraProject220503
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Extra Exercise Part1 & Part2!");
            A car = new A("Audi", "BMW", "Saab");
            Console.WriteLine(car.One + " " + car.Two + " " + car.Three);
            B car2 = new B("Volvo", "Benz", "Honda","Misubusi");
            Console.WriteLine(car2.One + " " + car2.Two + " " + car2.Three+" "+ car2.Four);
            B car3 = new B("Toyota", "Mini", "Susuki", "Lanlover");
            Console.WriteLine(car3.One + " " + car3.Two + " " + car3.Three+ " "+ car3.Four);
        }
    }
    class D : C // A,B is the main class // C,D is child class so C,D cannot Console in the top
    {
    public string One { get; set; }
    public string Two { get; set; }
    public string Three { get; set; }
    }
    class A : D
    {
        public A(string one, string two, string three)
        {
            One = one;
            Two = two;
            Three = three;
        }
    }
    class B : D
    {
        public B(string one, string two, string three, string four)
        {
            One = one;
            Two = two;
            Three = three;
            Four = Four;
    }

        //public string One { get; set; }
        //public string Two { get; set; }
        //public string Three { get; set; }

    }
    class C 
    {
        public string Four { get; set; }
    }
}

