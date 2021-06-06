using System;
using System.Text;

namespace ex35
{
    class Program
    {
        static void Main(string[] args)
        {
            string phrase = "Modern computers not supports PS/2 keyboard";
            Console.WriteLine(phrase);

            StringBuilder sb = new StringBuilder();
            foreach (string word in phrase.Split(' '))
                sb.Append(word[0]);
            Console.WriteLine("\nText composed of the first letters of the sentence: " + sb.ToString());

            Console.WriteLine("\nWords containing more than one letter 's' :");
            foreach (string word in phrase.Split(' '))
            {
                int count = 0;
                foreach (char letter in word)
                    if (letter == 's') count++;
                if (count > 1) Console.WriteLine(word);
            }

            Console.ReadKey();
        }
    }
}
