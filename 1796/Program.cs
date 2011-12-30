using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _1796
{
    /// <summary>
    /// http://acm.timus.ru/problem.aspx?space=1&num=1796
    /// </summary>
    class Program
    {
        static void Main()
        {
            var nominals = new[] { 10, 50, 100, 500, 1000, 5000 };

            var money = Console.ReadLine().Split(" ".ToCharArray()).Select(t => int.Parse(t)).ToArray();
            var price = int.Parse(Console.ReadLine());

            var total = 0;
            var min = int.MaxValue;
            for (var i = 0; i < nominals.Length; ++i)
            {
                total += money[i] * nominals[i];
                if (money[i] != 0 && min == int.MaxValue)
                    min = nominals[i];
            }

            var maxCount = total / price;
            var minCount = 1 + (total - min) / price;
            var count = maxCount - minCount + 1;
            Console.WriteLine(count);
            for (int c = 0; c < count; ++c)
            {
                Console.Write(minCount + c);
                Console.Write(" ");
            }
        }
    }
}
