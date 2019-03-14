using System;

namespace _1150FunkExempel
{
    class Program
    {
        public static void Main(string[] args)
        {
            /* Tilldela variabeln foo av typen Func<string, int>
             * * metoden ReturnStringLength. */
            Console.Write("Mata in en sträng: ");
            string s = Console.ReadLine();

            Func<string, int> foo = ReturnStringLength;

            // Anropa metoden som variabeln foo tilldelats.
            int i = foo(s);
            Console.WriteLine($"Strängens längd = {i}");
        }
        static int ReturnStringLength(string s)
        {
            return s.Length;
        }
    }
}
