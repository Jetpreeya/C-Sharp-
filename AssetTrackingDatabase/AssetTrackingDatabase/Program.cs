using System;
using System.Collections.Generic;
using System.Linq;
using System.Data.SqlClient;

string ConnectionString = @"Data Source = S4D08; Initial Catalog = AssetTracking; Integrated Security = True";

SqlConnection Connection = new SqlConnection(ConnectionString);

Connection.Open();

SqlCommand Command = new SqlCommand("select * from Products", Connection);

var Result = Command.ExecuteReader();

Console.WriteLine("Asset Tracking");
Console.WriteLine("--------------------------------------------------------------------------------------------------------------------");
Console.WriteLine("ID".PadRight(10) + " |" + "Type".PadRight(15) + " |" + "Brand".PadRight(15) + " |" + "Model".PadRight(20) + " |" + "Office".PadRight(15) + " |" + "Purchase Date".PadRight(20) + " |" + "Price in USD".PadRight(10) + " |" + "Currency".PadRight(15) + " |" + "Local Price Today");
Console.WriteLine("--------------------------------------------------------------------------------------------------------------------");

while (Result.Read())
{

    var ProductID = Result["ProductID"].ToString();
    var TypeProduct = Result["TypeProduct"].ToString();
    var Brand = Result["Brand"].ToString();
    var Model = Result["Model"].ToString();
    var Office = Result["Office"].ToString();
    var Purchase = Result["Purchase"].ToString();
    var PriceByUSD = Result["PriceByUSD"].ToString();
    var Currency = Result["Currency"].ToString();
    var LocalPrice = Result["LocalPrice"].ToString();

    Console.WriteLine(ProductID?.PadRight(10) + " |" + TypeProduct?.PadRight(15) + " |" + Brand?.PadRight(15) + " |" + Model?.PadRight(20) + " |" + Office?.PadRight(15) + " |" + Purchase?.PadRight(20) + " |" + PriceByUSD?.PadRight(10) + " |" + Currency?.PadRight(15) + " |" + LocalPrice?.PadRight(5));
}


Connection.Close();







