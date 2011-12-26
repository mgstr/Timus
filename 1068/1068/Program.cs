namespace _1068
{
    using System;
    class Program
    {
        static void Main()
        {
            int number = Int32.Parse(Console.ReadLine());
            int sum = 0;

            if (number < 1)
                for (int i = number; i <= 1; ++i)
                    sum += i;
            else
                for (int i = 1; i <= number; ++i)
                    sum += i;

            Console.WriteLine(sum);
        }
    }
}
