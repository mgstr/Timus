using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _1644
{
    /// <summary>
    /// http://acm.timus.ru/problem.aspx?space=1&num=1644
    /// </summary>
    class Program
    {
        static void Main()
        {
            var tests = new int[10];
            var n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; ++i)
            {
                var data = Console.ReadLine().Split(" ".ToCharArray());
                var number = int.Parse(data[0]);
                var result = data[1] == "hungry" ? - 1 : +1;


                while (number >= 0 && number < 10)
                {
                    if (tests[number] != 0 && tests[number] != result)
                    {
                        Console.WriteLine("Inconsistent");
                        return;
                    }
                    tests[number] = result;
                    number += result;
                }
            }

            int first = -1;
            for (int i = 0; i < 10; ++i)
            {
                if (tests[i] == 1 && first == -1)
                    first = i;
            }
            Console.WriteLine(first == -1 ? 10 : first);
        }
    }
}
