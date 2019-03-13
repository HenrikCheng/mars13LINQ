using System;

namespace _1130Delegater2
{
    class Program
    {
        static void Main(string[] args)
        {
            Action<string, bool> carAction = PrintIt;
            carAction("Henrik I, II och III", true);
        }
        static void PrintIt(string namn, bool sant)
        {
            if (sant)
                Console.WriteLine(namn.ToUpper());
            else
                Console.WriteLine(namn.ToLower());
        }
    }
}
