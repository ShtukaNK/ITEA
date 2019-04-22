using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank
{
    public class Money : ISpendable
    {
        public void Spend()
        {
            Console.WriteLine("Катя потратила все деньги на услуги банка");
        }
    }
}
