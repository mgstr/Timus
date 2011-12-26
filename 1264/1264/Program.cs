namespace _1264
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    class Program
    {
        static void Main()
        {
            var n = ReadNumbers();
            Console.WriteLine(n[0] * (1 + n[1]));
        }

        /// <summary>
        /// Read numbers separated by space from standard input stream
        /// </summary>
        /// <returns>Array of int's</returns>
        private static int[] ReadNumbers()
        {
            return Console.ReadLine().Split(" ".ToCharArray()).Select(n => int.Parse(n)).ToArray();
        }
    }
}
