namespace _1877
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    class Program
    {
        static void Main()
        {
            int code1 = int.Parse(Console.ReadLine());
            int code2 = int.Parse(Console.ReadLine());

            Console.WriteLine(code1 % 2 == 0 || code2 % 2 == 1 ? "yes" : "no");
        }
    }
}
