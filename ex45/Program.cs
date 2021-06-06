using System;

namespace ex45
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Was:");
            string s = "  Two    words  string    to lace   from the ceiling  ";
            Console.WriteLine(s);
            s = s.Trim();
            while (s.Contains("  "))
                s = s.Replace("  ", " ");
            string[] attString = s.Split(' ');
            Array.Sort(attString);
            string sNew = string.Join(' ', attString);
            Console.WriteLine();
            Console.WriteLine("Became:");
            Console.WriteLine(sNew);
            Console.ReadKey();
        }
    }
}
