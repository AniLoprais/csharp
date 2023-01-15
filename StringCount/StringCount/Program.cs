using System;
using System.Collections.Generic;
using System.Linq;

namespace StringCount
{
    public class Program
    {

        static void Main(string[] args)
        {

            string content = "It is better to be hated for what you are than to be loved for what you are not.";
            string letters = content.Replace(" ", "").Replace(".", "").Replace(",", "").Replace("!", "").Replace("?", "");
            int newlettersLength = letters.Length;

            Console.WriteLine("Contains " + newlettersLength + " letters: \n" + content);

            string lowerletters = letters.ToLower();

            Console.WriteLine(lowerletters);

            //char[] characters = lowerletters.GroupBy(g => g).OrderByDescending(c => c.Count()).ThenBy(c => c.Key).SelectMany(c => c).ToArray();
            char[] characters = lowerletters.GroupBy(g => g)
                .OrderByDescending(c => c.Count()).ThenBy(c => c.Key).SelectMany(c => c).ToArray();

            Dictionary<char, int> slovnik = new Dictionary<char, int>();

            for (int i = 0; i < characters.Length; i++)
            {
                char znak = characters[i];
                if (slovnik.ContainsKey(znak))
                {
                    continue;
                }

                int counter = 0;

                for (int j = 0; j < characters.Length; j++)
                {
                    if (znak == characters[j])
                    {
                        counter++;
                    }
                }
                slovnik.Add(znak, counter);
                Console.WriteLine(znak.ToString() + " " + counter);
            }

            Console.WriteLine(characters);

            //var frequency = from f in characters
            //                group f by f into letterfrequency
            //                orderby letterfrequency.Key
            //                select new
            //                {
            //                    Letter = letterfrequency.Key,
            //                    Frequency = letterfrequency.Count()
            //                };

            //foreach (var f in frequency)
            //{
            //    Console.WriteLine($"{f.Letter} {f.Frequency}");
            //}


            Console.ReadLine();
        }
    }
}