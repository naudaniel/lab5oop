using System;

namespace ex25
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Print only those letters of words that are only in \n " +
                 "one of them (including repetitive ones). ");
            Console.Write("Enter the first word:");
            string s = Console.ReadLine();
            Console.Write("Enter the second word:");
            string s2 = Console.ReadLine();
            for (int i = 0; i < s.Length; i++)
                if (!s2.Contains(s[i], StringComparison.OrdinalIgnoreCase))
                    Console.Write(s[i] + " ");
            for (int i = 0; i < s2.Length; i++)
                if (!s.Contains(s2[i], StringComparison.OrdinalIgnoreCase))
                    Console.Write(s2[i] + " ");
            Console.WriteLine();
            Console.ReadKey();
        }
    }
}
