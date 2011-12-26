namespace _1820
{
    using System;
    class Program
    {
        static void Main()
        {
            var numbers = Console.ReadLine().Split(" ".ToCharArray());
            int steaksTotal = Int16.Parse(numbers[0]);
            int steaksPerPan = Int16.Parse(numbers[1]);
            if (steaksPerPan > steaksTotal)
                steaksPerPan = steaksTotal;
            int sides = 2 * steaksTotal;
            int minutes = sides / steaksPerPan;
            if (sides % steaksPerPan != 0)
                ++minutes;
            Console.WriteLine(minutes);
        }
    }
}
