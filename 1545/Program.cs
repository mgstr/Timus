using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _1545
{
    /// <summary>
    /// http://acm.timus.ru/problem.aspx?space=1&num=1545
    /// </summary>
    class Program
    {
        static void Main()
        {
            var words = int.Parse(Console.ReadLine());

            var map = new Dictionary<char, string>();

            for (int word = 1; word <= words; ++word)
            {
                var text = Console.ReadLine();
                char letter = text[0];
                if (map.ContainsKey(letter))
                    map[letter] += "\r\n" + text;
                else
                    map.Add(letter, text);
            }

            var first = Console.ReadLine()[0];
            if (map.ContainsKey(first))
                Console.WriteLine(map[first]);
        }
    }
}
