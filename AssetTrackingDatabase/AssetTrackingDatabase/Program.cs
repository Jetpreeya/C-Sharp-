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
Console.WriteLine("--------------------------------------------------------------------------------------------------------------------");
Console.WriteLine("ID".PadRight(10) + " |" + "Type".PadRight(15) + " |" + "Brand".PadRight(15) + " |" + "Model".PadRight(20) + " |" + "Office".PadRight(15) + " |" + "Purchase Date".PadRight(20) + " |" + "Price in USD".PadRight(15) + " |" + "Currency".PadRight(15) + " |" + "Local Price Today");
Console.WriteLine("--------------------------------------------------------------------------------------------------------------------");

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
Console.WriteLine("----------------------------------------------------------------------------------------------------------");
Console.WriteLine("Sort List by Type");
Console.WriteLine("----------------------------------------------------------------------------------------------------------");

foreach (Products b in orderedList)
{
    Console.WriteLine(b.ProductID.ToString().PadRight(10) + " |" + b.TypeProduct.PadRight(15) + " |" + b.Brand.PadRight(15) + " |" + b.Model.PadRight(20) + " |" + b.Office.PadRight(15) + " |" + b.Purchase.ToString("yyyy-MM-dd").PadRight(20) + " |" + b.PriceByUSD.ToString().PadRight(15) + " |" + b.Currency.PadRight(15) + " |" + b.LocalPrice);
    Console.ResetColor();
}



Connection.Close();

