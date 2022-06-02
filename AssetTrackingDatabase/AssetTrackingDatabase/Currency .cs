using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssetTrackingDatabase
{
    internal class Currency
    {
        public Currency(string country, string curren, double price, string usd, double usdprice)
        {
            Country = country;
            Curren = curren;
            Price = price;
            USD = usd;
            UsdPrice = usdprice;
        }
        public string Country { get; set; }
        public string Curren { get; set; }
        public double Price { get; set; }
        public string USD { get; set; }
        public double UsdPrice { get; set; }

    }
}
