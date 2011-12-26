namespace _1869
{
    using System;

    class Program
    {
        static int[,] a;
        static int stations;
        static int max;

        static void Main()
        {
            stations = int.Parse(Console.ReadLine());
            a = new int[stations, stations];
            for (int i = 0; i < stations; ++i)
            {
                var line = Console.ReadLine();
                var an = line.Split(" ".ToCharArray());
                for (int j = 0; j < stations; ++j)
                    a[i, j] = int.Parse(an[j]);
            }

            Run(false);
            Run(true);

            int v = max / 36;
            if (max % 36 != 0)
                ++v;

            Console.WriteLine(v);
        }

        static void Run(bool flag)
        {
            int people = 0;
            for (int i = 0; i < stations; i++)
            {
                people -= SumColumns(i, flag) * (flag ? 1 : -1);
                people += SumRows(i, flag) * (flag ? 1 : -1);
                if (max < people)
                    max = people;
            }
        }

        static int SumColumns(int col, bool flag)
        {
            int sum = 0;

            for (int row = 0; row < stations; ++row)
                if (flag ^ (row > col))
                    sum += a[row, col];

            return sum;
        }


        static int SumRows(int row, bool flag)
        {
            int sum = 0;

            for (int col = 0; col < stations; ++col)
                if (flag ^ (row > col))
                    sum += a[row, col];

            return sum;
        }
    }
}
