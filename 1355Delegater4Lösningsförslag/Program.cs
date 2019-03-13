using System;

namespace _1355Delegater4Lösningsförslag
{
    class Program
    {
        static void Main(string[] args)
        {
            SomeMethod("Obi Wan Kenobi", UpperOrLower);
        }
        static bool UpperOrLower()
        {
            Console.WriteLine("Stora eller små bokstäver? S/L");
            //allt nedan säger samma sak
            //4 rader
            if (Console.ReadKey().Key == ConsoleKey.S)
                return true;
            else
                return false;

            //2 rader
            bool istheSKey = Console.ReadKey(true).Key == ConsoleKey.S;
            return istheSKey; 

            //1 rad
            return Console.ReadKey(true).Key == ConsoleKey.S;
        }
        static void SomeMethod(string message, Func <bool> storbokstav)
        {
            if (storbokstav())
            {
                Console.WriteLine(message.ToUpper());
            }
            else
            {
                Console.WriteLine(message.ToLower());
            }
        }
    }
}
