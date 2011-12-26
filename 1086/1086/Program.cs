namespace _1086
{
    using System;

    class Program
    {
        const int MaxPrimeNumber = 15000;
        static int[] primes = new int[MaxPrimeNumber];

        static void Main()
        {
            primes[0] = 2;
            primes[1] = 3;
            primes[2] = 5;

            int index = 2;
            int n = 5;

            while (++index < MaxPrimeNumber)
            {
                do
                {
                    n += 2;
                }
                while (!IsPrime(n));

                primes[index] = n;
            }

            int k = int.Parse(Console.ReadLine());
            for (int i = 1; i <= k; ++i)
            {
                n = int.Parse(Console.ReadLine());
                Console.WriteLine(primes[n-1]);
            }
        }

        static bool IsPrime(int number)
        {
            int max = (int)Math.Round(0.5 + Math.Sqrt(number));
            for (int i = 1; primes[i] <= max; ++i)
                if (number % primes[i] == 0)
                    return false;
            return true;
        }
    }
}
