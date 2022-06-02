using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssetTrackingDatabase
{
    internal class Computer : Function
    {
        public Computer(string type, string brand, string model, string office, DateTime year, int price, string currency, double localPrice)
        {
            Type = type;
            Brand = brand;
            Model = model;
            Office = office;
            Year = year;
            Price = price;
            Currency = currency;
            LocalPrice = localPrice;
        }
    }
}
