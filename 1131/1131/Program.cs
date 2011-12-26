namespace _1131
{
    using System;
    class Program
    {
        static void Main()
        {
            var numbers = Console.ReadLine().Split(" ".ToCharArray());
            int computersTotal = Int32.Parse(numbers[0]);
            int cables = Int32.Parse(numbers[1]);

            int hours = 0;
            int computers = 1;
            while (computers < computersTotal)
            {
                if (computers < cables)
                {
                    ++hours;
                    computers += Math.Min(computers, cables);
                }
                else
                {
                    // next - just divide the number of remaiing computers to the number of cables
                    hours += (computersTotal - computers) / cables;
                    if ((computersTotal - computers) % cables != 0)
                        ++hours;
                    break;
                }
            }
            Console.WriteLine(hours);
        }
    }
}
