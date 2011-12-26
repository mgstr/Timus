namespace _1025
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    class Program
    {
        static void Main()
        {
            int k = int.Parse(Console.ReadLine());
            Console.WriteLine(Console.ReadLine().Split(" ".ToCharArray()).Select(n => int.Parse(n)).OrderBy(i => i).TakeWhile((i, index) => index < (k + 1) / 2).Select(i => (i + 1) / 2).Sum());
        }
    }
}
