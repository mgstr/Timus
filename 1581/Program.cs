namespace _1581
{
    using System;

    /// <summary>
    /// http://acm.timus.ru/problem.aspx?space=1&num=1581
    /// </summary>
    class Program
    {
        static void Main()
        {
            Console.ReadLine();

            int p = 0;
            int c = 0;

            foreach (var number in Console.ReadLine().Split(" ".ToCharArray()))
            {
                int n = int.Parse(number);

                if (n == p)
                    ++c;
                else
                {
                    if (p != 0)
                    {
                        Console.Write(c);
                        Console.Write(" ");
                        Console.Write(p);
                        Console.Write(" ");
                    }
                    p = n;
                    c = 1;
                }
            }
            Console.Write(c);
            Console.Write(" ");
            Console.Write(p);
        }
    }
}
