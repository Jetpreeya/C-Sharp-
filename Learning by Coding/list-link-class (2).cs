using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day7_list_link_class
{
    internal class Car
    {
            public Car(string brand, string modal, int year, int speed)
            {
                Brand = brand;
                Modal = modal;
                Year = year;
                Speed = speed;
            }

            public string Brand { get; set; }
            public string Modal { get; set; }
            public int Year { get; set; }
            public int Speed { get; set; }
  
    }
}
