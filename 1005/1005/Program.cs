namespace _1005
{
    using System;
    using System.Collections.Generic;
    class Program
    {
        static void Main()
        {
            int stoneCount = int.Parse(Console.ReadLine());

            var temp = new List<int>();
            foreach (var stoneWeight in Console.ReadLine().Split(" ".ToCharArray()))
                temp.Add(int.Parse(stoneWeight));
            var stones = temp.ToArray();

            long minDifference = long.MaxValue;
            for (long mask = (1L << stoneCount) - 1; mask != 0; --mask)
            {
                long total = 0;
                for (long flag = 1, stone = 0; stone < stoneCount; ++stone, flag <<= 1)
                    if ((flag & mask) != 0)
                        total += stones[stone];
                    else
                        total -= stones[stone];
                long difference = Math.Abs(total);

                if (minDifference > difference)
                    minDifference = difference;
            }

            Console.WriteLine(minDifference);
        }
    }
}
