using CarShowroom;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            var car = new Car(12000);
            Console.WriteLine(car.Price);
            Console.ReadKey();
;        }
    }
}
