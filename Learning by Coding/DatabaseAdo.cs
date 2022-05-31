using sql_EF;

Car Car1 = new Car();
Car1.Brand = "Volvo";
Car1.Model = "240";
Car1.Year = 1980;

MyDbContext Context = new MyDbContext();

Car Car2 = new Car();
Car2.Brand = "Mercedes";
Car2.Model = "560";
Car2.Year = 1986;

Context.Cars.Add(Car2);
Context.SaveChanges();
____________________________________________________________________
var Cars = Context.Cars.ToList(); //Show list of car more than one row

var car = context.cars.singleordefault(x => x.model == "240"); // Get data only one row by singleOrdefault
Console.WriteLine(Car.Brand + " " + Car.Model);

foreach (Car Car in Cars)
{
    Console.WriteLine(Car.Model);
}
____________________________________________________________________
var Car = Context.Cars.SingleOrDefault(x => x.Id == 2); // For Update
Car.Brand = "SAAB";
Car.Model = "9000";
Car.Year = 1999;
Context.SaveChanges();
