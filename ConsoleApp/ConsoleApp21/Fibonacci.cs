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
            Console.WriteLine(Fibonacci(10));
        }
        static int Fibonacci(int x)
        {
            if (x <= 1)
                return 1;
            return Fibonacci(x - 1) + Fibonacci(x - 2);
        }

        
    }
    }
}
