namespace _1880
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// Solution for http://acm.timus.ru/problem.aspx?space=1&num=1880&locale=en
    /// </summary>
    public class Program
    {
        /// <summary>
        /// Read one number from console.
        /// </summary>
        /// <returns>Number</returns>
        private static int ReadNumber()
        {
            return int.Parse(Console.ReadLine());
        }

        public static void Main()
        {
            int count = ReadNumber();
            var data1 = Console.ReadLine().Split(" ".ToCharArray()).Select(n => int.Parse(n)).ToList<int>();

            count = ReadNumber();
            var data2 = Console.ReadLine().Split(" ".ToCharArray()).Select(n => int.Parse(n)).ToList<int>();

            var result = Merge(data1, data2);

            count = ReadNumber();
            var data3 = Console.ReadLine().Split(" ".ToCharArray()).Select(n => int.Parse(n)).ToList<int>();

            result = Merge(result, data3);

            Console.WriteLine(result.Count);
        }

        private static List<int> Merge(List<int> data1, List<int> data2)
        {
            var result = new List<int>();

            while (true)
            {
                if (data1.Count == 0 || data2.Count == 0)
                    return result;

                int n1 = data1.First();
                int n2 = data2.First();
                if (n1 == n2)
                {
                    result.Add(n1);
                    data1.RemoveAt(0);
                    data2.RemoveAt(0);
                }
                else
                    if (n1 < n2)
                        data1.RemoveAt(0);
                    else
                        data2.RemoveAt(0);
            }
        }
    }
}
