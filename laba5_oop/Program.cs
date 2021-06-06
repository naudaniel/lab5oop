using System;
using System.Text;

namespace laba5_oop
{
    class Program
    {
        static void Main(string[] args)
        {
            StringBuilder sb = new StringBuilder("Given a string. Show the third, sixth, ninth, and so on characters.");

            Console.Write("third characters: ");
            for (int i = 1; i < sb.Length; i++)
                if (i % 3 == 0)
                    Console.Write(sb[i] + " ");

            Console.WriteLine();
            Console.Write("sixth characters: ");
            for (int i = 1; i < sb.Length; i++)
                if (i % 6 == 0)
                    Console.Write(sb[i] + " ");

            Console.WriteLine();
            Console.Write("ninth characters: ");
            for (int i = 1; i < sb.Length; i++)
                if (i % 9 == 0)
                    Console.Write(sb[i] + " ");

            Console.WriteLine();
            Console.WriteLine();
        }
    }
}
