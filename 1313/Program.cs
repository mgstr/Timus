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

            for (int c = 0; c < n; ++c)
            {
                int column = c;
                int j = 0;
                while (j >= 0 && column >= 0)
                {
                    Console.Write(numbers[column, j]);
                    Console.Write(" ");
                    j += 1;
                    column -= 1;
                }
            }
            for (int r = 1; r < n; ++r)
            {
                int column = r;
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
