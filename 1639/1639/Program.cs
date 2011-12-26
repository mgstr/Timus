namespace _1639
{
    using System;
    using System.Linq;

    class Program
    {
        static void Main()
        {
            var numbers = ReadNumbers();
            var m = numbers[0];
            var n = numbers[1];

            Console.WriteLine(m * n % 2 == 0 ? "[:=[first]" : "[second]=:]");
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
