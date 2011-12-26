namespace _1787
{
    using System;
    using System.Linq;

    class Program
    {
        static void Main()
        {
            var numbers = ReadNumbers();
            var k = numbers[0];
            var n = numbers[1];

            numbers = ReadNumbers();

            int cars = 0;
            for (int time = 0; time < n; ++time)
            {
                cars += numbers[time];
                cars -= k;
                if (cars < 0)
                    cars = 0;
            }

            Console.WriteLine(cars);
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
