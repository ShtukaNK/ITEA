using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarShowroom
{
    public class Car
    {
        public string ModelName;
        public int Price { get; private set; }
        public string color;
        public string CarNumber;
        public string[] Inforamation;
        public string Owner { get; private set; }

        public Car(int price)
        {
            Price = price;
        }

        private void Moving(string owner )
        {
            Owner = Owner;
           
        }
    }

}


