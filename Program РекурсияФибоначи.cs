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
            Console.WriteLine("25-5*2=?");
            WriteNumber();
            Console.ReadLine();
        }

        public static void WriteNumber()
        {
            int a = int.Parse(Console.ReadLine());

            if (a == 15)
            {
                Console.WriteLine("Правильно, 15");
            }

            else
            {
                Console.WriteLine("Неправильно");
            }

            Console.ReadLine();

        }
    }

}