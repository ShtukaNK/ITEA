using System;

namespace ConsoleApplication52
{
    class Program
    {
        static void Main()
        {

            Console.WriteLine("Hello. How are you?");

            string[] questions =
            {
                "it's interesting, isn't it",
                "I see your point of view",
                "do you really think so?",
                "are you sure?",
                "I disagree with you",
                "I know a lot of people like you"
            };

            string[] answers =
            {
                "I have to think",
                "Well...it's hard to say",
                "Why are you asking this question?",
                "Who knows...",
                "I'm not sure",
                "Let's change topic. I don't want to answer this question"
            };

            Random r = new Random();

            for (; ; )

            {
                string s = Console.ReadLine();

                if (s == null)

                    Console.WriteLine("Why you wrote nothing??");

                else

                {
                    string[] next = s.Contains("?") ? answers : questions;
                    Console.WriteLine(next[r.Next(next.Length)]);
                }

            }
        }
    }
}