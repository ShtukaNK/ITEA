using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;
        }

        public static int Fibonachi(int n)
        {

            if (n == 0)
            {
                return 0;
            }

            if (n == 1)
            {
                return 1;
            }

            else

            {
                return Fibonachi(n - 1) + Fibonachi(n - 2);
            }


        }
    }

}