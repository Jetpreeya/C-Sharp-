using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssetTrackingDatabase
{
    public class Products
    {
        public int ProductID { get; set; }
        public string TypeProduct { get; set; }
        public string Brand { get; set; }
        public string Model { get; set; }
        public string Office { get; set; }
        public DateTime Purchase { get; set; }
        public int PriceByUSD { get; set; }
        public string Currency { get; set; }
        public double LocalPrice { get; set; }
    }

}
