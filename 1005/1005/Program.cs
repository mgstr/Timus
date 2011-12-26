namespace _1005
{
    using System;
    using System.Collections.Generic;
    class Program
    {
        static void Main()
        {
            int stoneCount = int.Parse(Console.ReadLine());

            var stones = new List<int>();
            foreach (var stoneWeight in Console.ReadLine().Split(" ".ToCharArray()))
                stones.Add(int.Parse(stoneWeight));

            int totalWeight = 0;
            foreach (var stoneWeight in stones)
                totalWeight += stoneWeight;

            Console.WriteLine(totalWeight);
        }
    }
}
