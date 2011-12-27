namespace _1585
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class Program
    {
        static void Main()
        {
            var count = int.Parse(Console.ReadLine());
            var map = new Dictionary<string, int>();

            while (count-- != 0)
            {
                var name = Console.ReadLine();
                if (map.ContainsKey(name))
                    ++map[name];
                else
                    map.Add(name, 1);
            }

            var max = map.Values.Max();
            Console.WriteLine(map.First(p => p.Value == max).Key);
        }
    }
}
