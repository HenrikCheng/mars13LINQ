using System;

namespace _1300Delegater3
{
    class Program
    {
        static void Main(string[] args)
        {
            Func<int, int, bool> foo = IsLessThan;
            foo(5, 4);

            //Håkans sätt att lösa problemet
            Func<int, int, bool> foo1 = IsLessThan1;
            if (foo1(10, 5))
            {
                Console.WriteLine("Yes");
            }
            else
                Console.WriteLine("no");
        }

        static bool IsLessThan (int tal1, int tal2)
        {
            if (tal1 < tal2)
            {
                Console.WriteLine("is true");
                return true;
            }
            else
            {
                Console.WriteLine("is false");
                return false;
            }
        }
        //Del av Håkans lösning
        static bool IsLessThan1(int tal1, int tal2)
        {
            return tal1 < tal2;
        }
    }
}
