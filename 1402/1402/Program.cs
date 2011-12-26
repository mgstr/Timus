namespace _1402
{
    using System;
    class Program
    {
        static void Main()
        {
            int n = Int16.Parse(Console.ReadLine());
            if (n == 1)
            {
                Console.WriteLine("0");
                return;
            }
            if (n == 2)
            {
                Console.WriteLine("2");
                return;
            }

            decimal result = 0;
            for (int k = 2; k <= n; ++k)
            {
                decimal t = f(n) / f(n - k);
                result += t;
            }
            Console.WriteLine(result);
        }

        static decimal f(int i)
        {
            decimal result = 1;

            for (int number = 2; number <= i; ++number)
                result *= number;

            return result;
        }
    }
}
