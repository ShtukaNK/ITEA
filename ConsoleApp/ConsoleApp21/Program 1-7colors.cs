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
            Console.WriteLine("Write a number from 1 to 7");
            WriteColor();
            Console.ReadLine();
        }

        public static void WriteColor()
        {
            int a = int.Parse(Console.ReadLine());

            if (a == 1)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Красный");
            }

            else if (a == 2)
            {
                Console.BackgroundColor = ConsoleColor.White;
                Console.WriteLine("Белый");
            }

            else if (a == 3)
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("Желтый");
            }

            else if (a == 4)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Зелёный");
            }

            else if (a == 5)
            {
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("Голубой");
            }

            else if (a == 6)
            {
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("Синий");
            }

            else if (a == 7)
            {
                Console.ForegroundColor = ConsoleColor.Magenta;
                Console.WriteLine("Фиолетовый");
            }

            else
            {
                Console.WriteLine("Что-то пошло не так");
            }

            Console.ReadLine();

        }
    }

}