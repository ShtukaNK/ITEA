using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank
{
    public class Banker : AbsHuman
    {
        public string Position { get; set; }

        public Banker(string name, string position) : base(name)
        {
            Position = position;
        }

        public override void Display()
        {
            Console.WriteLine($"{Name} работает в банке на должности {Position}");
        }
    }
}
