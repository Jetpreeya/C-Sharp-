using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssetTrackingDatabase
{
    internal class Computer : Products
    {
        public Computer(string type, string brand, string model, string office, DateTime year, int price, string currency, double localPrice)
        {
            TypeProduct = type;
            Brand = brand;
            Model = model;
            Office = office;
            Purchase = year;
            PriceByUSD = price;
            Currency = currency;
            LocalPrice = localPrice;
        }
    }
}
