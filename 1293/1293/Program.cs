namespace _1293
{
    using System;
    using System.Linq;
    class Program
    {
        static void Main()
        {
            var n = Console.ReadLine().Split(" ".ToCharArray()).Select(s=>Int16.Parse(s)).ToArray();
            Console.WriteLine(n[0]*n[1]*n[2]*2);
        }
    }
}
