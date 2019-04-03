using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp15
{
    class Program
    {
        static void Main(string[] args)
        {E:\c#\Program 18+.cs
            Console.WriteLine("How old are you, bro?");

            int age = Convert.ToInt32(Console.ReadLine());

            if (age >= 18)
            {
                Console.WriteLine("Congratulations, you are allowed to smoke and drink to die earlier!)");
            }

            else
            {
                Console.WriteLine("You will have to  wait a couple of years before start drinking.");
            }

            Console.ReadKey();
        }
    }
}
