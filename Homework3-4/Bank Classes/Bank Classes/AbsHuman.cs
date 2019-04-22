using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank
{
    public abstract class AbsHuman
    {
        public string Name { get; set; }

        public AbsHuman(string name)
        {
            Name = name;
        }

        public abstract void Display();
    } 
}
