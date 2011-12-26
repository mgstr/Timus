namespace _1654
{
    using System;
    using System.Text.RegularExpressions;

    class Program
    {
        static void Main()
        {
            var encoded = Console.ReadLine();
            // * is illegal char and can't be in the input stream, use it as a guard to prevent out of the bound condition
            var chars = ("*" + encoded).ToCharArray();

            int prev = 0;
            int next = 1;

            while (next < chars.Length)
            {
                if (chars[prev] != chars[next])
                {
                    chars[++prev] = chars[next++];
                }
                else
                {
                    --prev;
                    ++next;
                }
            }

            // Don't forget about guard char
            for (int i = 1; i <= prev; ++i)
                Console.Write(chars[i]);
        }
    }
}
