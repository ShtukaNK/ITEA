﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zoo
{
    public class Visitor : Human
    {
        public Visitor(int age, string name) : base(age, name)
        {
        }
    }
}
