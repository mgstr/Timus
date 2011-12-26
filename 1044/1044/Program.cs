namespace _1044
{
    using System;

    class Program
    {
        static void Main()
        {
            int digits = int.Parse(Console.ReadLine());
            int max = (int)Math.Pow(10, digits);
            int half = (int)Math.Pow(10, digits / 2);

            int[] sums = new int[4 * 9 + 1]; // max sum of 9999
            for (int n = 0; n < half; ++n)
            {
                int sum = Sum(n);
                ++sums[sum];
            }

            int lucky = 0;
            for (int s = 0; s < sums.Length; ++s)
            {
                lucky += sums[s] * sums[s];
            }
            Console.WriteLine(lucky);
        }

        static int Sum(int number)
        {
            if (cache[number] != 0)
                return cache[number];

            int sum = 0;
            int n = number;
            do
            {
                int digit = n % 10;
                sum += digit;
                n /= 10;
            }
            while (n != 0);

            cache[number] = sum;
            return sum;
        }

        static int[] cache = new int[10000];
    }
}
