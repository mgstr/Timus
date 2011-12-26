namespace _1409
{
    using System;
    class Program
    {
        static void Main(string[] args)
        {
            var shots = Console.ReadLine().Split(" ".ToCharArray());
            int shot1 = Int16.Parse(shots[0]);
            int shot2 = Int16.Parse(shots[1]);
            int total = shot1 + shot2 - 1;
            Console.WriteLine("{0} {1}", total - shot1, total - shot2);
        }
    }
}
