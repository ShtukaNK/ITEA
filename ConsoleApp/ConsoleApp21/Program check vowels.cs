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
            Console.WriteLine("Lets check if you string contains vowels:)");
            WritePhrase();
            Console.ReadLine();
        }

        public static void WritePhrase()
        {
            var vowels = Console.ReadLine()
            .Where(c => "aeiouAEIOU".Contains(c))
            .Distinct();

            foreach (var vowel in vowels)
                Console.WriteLine("I found {0}", vowel);

            if (!vowels.Any())
                Console.WriteLine("I found nothig. Try again.");
        }
    }
}
