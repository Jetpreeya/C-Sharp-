using System;
using System.Collections.Generic;
using System.Linq;
using System.Data.SqlClient;
using AssetTrackingDatabase;

string ConnectionString = @"Data Source = S4D08; Initial Catalog = AssetTracking; Integrated Security = True";

SqlConnection Connection = new SqlConnection(ConnectionString);

Connection.Open();

SqlCommand Command = new SqlCommand("select * from Products", Connection);

var Result = Command.ExecuteReader();

Console.WriteLine("Asset Tracking");
Console.WriteLine("--------------------------------------------------------------------------------------------------------------------------------------------------------------------------");
Console.WriteLine("ID".PadRight(10) + " |" + "Type".PadRight(15) + " |" + "Brand".PadRight(15) + " |" + "Model".PadRight(20) + " |" + "Office".PadRight(15) + " |" + "Purchase Date".PadRight(20) + " |" + "Price in USD".PadRight(15) + " |" + "Currency".PadRight(15) + " |" + "Local Price Today");
Console.WriteLine("--------------------------------------------------------------------------------------------------------------------------------------------------------------------------");

List<Products> orderedList = new List<Products>();

while (Result.Read())
{

    Products newProd = new Products();

    newProd.ProductID = Convert.ToInt32(Result["ProductID"].ToString());
    newProd.TypeProduct = Result["TypeProduct"].ToString();
    newProd.Brand = Result["Brand"].ToString();
    newProd.Model = Result["Model"].ToString();
    newProd.Office = Result["Office"].ToString();
    newProd.Purchase = Convert.ToDateTime(Result["Purchase"].ToString());
    newProd.PriceByUSD = Convert.ToInt32(Result["PriceByUSD"].ToString());
    newProd.Currency = Result["Currency"].ToString();
    newProd.LocalPrice = Convert.ToInt32(Result["LocalPrice"].ToString());

    orderedList.Add(newProd);

    Console.WriteLine(newProd.ProductID.ToString().PadRight(10) + ": " + newProd.TypeProduct.PadRight(15) + ": " + newProd.Brand.PadRight(15) + ": " + newProd.Model.PadRight(20) + ": " + newProd.Office.PadRight(15) + ": " + newProd.Purchase.ToString("yyyy-MM-dd").PadRight(20) + ": " + newProd.PriceByUSD.ToString().PadRight(15) + ": " + newProd.Currency.PadRight(15) + ":" + newProd.LocalPrice);
}

//Order by type
orderedList = orderedList.OrderBy(x => x.TypeProduct).ToList();
Console.WriteLine("--------------------------------------------------------------------------------------------------------------------------------------------------------------------------");
Console.WriteLine("Sort List by Type");
Console.WriteLine("--------------------------------------------------------------------------------------------------------------------------------------------------------------------------");
Console.WriteLine("ID".PadRight(10) + " |" + "Type".PadRight(15) + " |" + "Brand".PadRight(15) + " |" + "Model".PadRight(20) + " |" + "Office".PadRight(15) + " |" + "Purchase Date".PadRight(20) + " |" + "Price in USD".PadRight(15) + " |" + "Currency".PadRight(15) + " |" + "Local Price Today");
Console.WriteLine("--------------------------------------------------------------------------------------------------------------------------------------------------------------------------");

foreach (Products b in orderedList)
{
    Console.WriteLine(b.ProductID.ToString().PadRight(10) + " |" + b.TypeProduct.PadRight(15) + " |" + b.Brand.PadRight(15) + " |" + b.Model.PadRight(20) + " |" + b.Office.PadRight(15) + " |" + b.Purchase.ToString("yyyy-MM-dd").PadRight(20) + " |" + b.PriceByUSD.ToString().PadRight(15) + " |" + b.Currency.PadRight(15) + " |" + b.LocalPrice);
    Console.ResetColor();
}

//Level 2 
List<Products> sortedDate = orderedList.OrderBy(any => any.Purchase).ToList();
Console.WriteLine("--------------------------------------------------------------------------------------------------------------------------------------------------------------------------");
Console.WriteLine("Sort List by Date ");
Console.WriteLine("Mark any item *RED* if purchase date is less than 3 months away from 3 years.");
Console.WriteLine("--------------------------------------------------------------------------------------------------------------------------------------------------------------------------");
Console.WriteLine("ID".PadRight(10) + " |" + "Type".PadRight(15) + " |" + "Brand".PadRight(15) + " |" + "Model".PadRight(20) + " |" + "Office".PadRight(15) + " |" + "Purchase Date".PadRight(20) + " |" + "Price in USD".PadRight(15) + " |" + "Currency".PadRight(15) + " |" + "Local Price Today");
Console.WriteLine("--------------------------------------------------------------------------------------------------------------------------------------------------------------------------");

foreach (Products b in sortedDate) // Mark any item *RED* if purchase date is less than 3 months away from 3 years.
{
    bool test = b.Purchase > DateTime.Now.AddYears(-3).AddMonths(3);
    if (test) Console.ForegroundColor = ConsoleColor.Red;
    Console.WriteLine(b.ProductID.ToString().PadRight(10) + " |" + b.TypeProduct.PadRight(15) + " |" + b.Brand.PadRight(15) + " |" + b.Model.PadRight(20) + " |" + b.Office.PadRight(15) + " |" + b.Purchase.ToString("yyyy-MM-dd").PadRight(20) + " |" + b.PriceByUSD.ToString().PadRight(15) + " |" + b.Currency.PadRight(15) + " |" + b.LocalPrice);
    Console.ResetColor();
}

Console.WriteLine("--------------------------------------------------------------------------------------------------------------------------------------------------------------------------");
Console.WriteLine("Mark any item *Yellow* if date less than 6 months away from 3 years.");
Console.WriteLine("--------------------------------------------------------------------------------------------------------------------------------------------------------------------------");
Console.WriteLine("ID".PadRight(10) + " |" + "Type".PadRight(15) + " |" + "Brand".PadRight(15) + " |" + "Model".PadRight(20) + " |" + "Office".PadRight(15) + " |" + "Purchase Date".PadRight(20) + " |" + "Price in USD".PadRight(15) + " |" + "Currency".PadRight(15) + " |" + "Local Price Today");
Console.WriteLine("--------------------------------------------------------------------------------------------------------------------------------------------------------------------------");

foreach (Products b in sortedDate) // Items *Yellow* if date less than 6 months away from 3 years
{
    bool test = b.Purchase > DateTime.Now.AddYears(-6).AddMonths(3);
    if (test) Console.ForegroundColor = ConsoleColor.Yellow;
    Console.WriteLine(b.ProductID.ToString().PadRight(10) + " |" + b.TypeProduct.PadRight(15) + " |" + b.Brand.PadRight(15) + " |" + b.Model.PadRight(20) + " |" + b.Office.PadRight(15) + " |" + b.Purchase.ToString("yyyy-MM-dd").PadRight(20) + " |" + b.PriceByUSD.ToString().PadRight(15) + " |" + b.Currency.PadRight(15) + " |" + b.LocalPrice);
    Console.ResetColor();
}

//Filtered by currency Level 3 

List<ExchangeRate> showCurrency = new List<ExchangeRate>();
ExchangeRate c1 = new ExchangeRate( "EUR", 801.65);
ExchangeRate c2 = new ExchangeRate( "SEK", 50.65);
showCurrency.Add(c1);
showCurrency.Add(c2);

// List<ExchangeRate> filteredCurrency = showCurrency.Where(c => c.Currency == "SEK").ToList();
Console.WriteLine("-----------------------------------");
Console.WriteLine("Currency".PadRight(15) + "|" + "Rate".PadRight(10));
Console.WriteLine("-----------------------------------");
foreach (ExchangeRate curren1 in showCurrency)
{
    Console.WriteLine(curren1.Currency.PadRight(15) + curren1.Rate.ToString().PadRight(15));
}

Connection.Close();
