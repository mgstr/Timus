using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _1493
{
    /// <summary>
    /// http://acm.timus.ru/problem.aspx?space=1&num=1493
    /// </summary>
    class Program
    {
        static void Main()
        {
            var number = int.Parse(Console.ReadLine());
            Console.WriteLine(Lucky(number - 1) || Lucky(number + 1) ? "Yes" : "No");
        }

        private static bool Lucky(int number)
        {
            return Digit(number, 0) + Digit(number, 1) + Digit(number, 2)
                == Digit(number, 3) + Digit(number, 4) + Digit(number, 5);
        }

        private static int Digit(int number, int digit)
        {
            return (number / Convert.ToInt32(Math.Pow(10, digit))) % 10;
        }
    }
}
