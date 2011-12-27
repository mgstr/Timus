using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _1313
{
    class Program
    {
        static void Main()
        {
            var n = int.Parse(Console.ReadLine());
            var numbers = new int[n,n];
            for (int row = 0; row < n; ++row)
            {
                var data = Console.ReadLine().Split(" ".ToCharArray());
                for (int column = 0; column < n; ++column)
                    numbers[row, column] = int.Parse(data[column]);
            }

            for (int r = 0; r < n; ++r)
            {
                int row = r;
                int column = 0;
                while (row >= 0 && column >= 0)
                {
                    Console.Write(numbers[row, column]);
                    Console.Write(" ");
                    row -= 1;
                    column += 1;
                }
            }
            for (int c = 1; c < n; ++c)
            {
                int column = c;
                int row = n - 1;
                while (column < n && row >= 0)
                {
                    Console.Write(numbers[row, column]);
                    Console.Write(" ");
                    row -= 1;
                    column += 1;
                }
            }
        }
    }
}
