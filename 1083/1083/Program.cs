namespace _1083
{
    using System;

    class Program
    {
        static void Main()
        {
            var input = Console.ReadLine();
            var tokens = input.Split(" ".ToCharArray());
            int n = int.Parse(tokens[0]);
            int k = tokens[1].Length;

            //Console.WriteLine("n={0}", n);
            //Console.WriteLine("k={0}", k);

            decimal result = n;
            int end = n % k;
            if (end == 0)
                end = k;
            int number = n - k;
            while (number >= end)
            {
                result *= number;
                number -= k;
            }
            Console.WriteLine(result);
        }
    }
}
