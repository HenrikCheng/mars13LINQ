using System;

namespace Delegater4
{
    class Program
    {
        static void Main(string[] args)
        {
            SomeMethod("Darth Vader", AnotherMethod);
        }

        static void SomeMethod(string name, Func<bool> foo)
        {
            if (foo())
            {
                Console.WriteLine(name.ToUpper());
            }
            else
                Console.WriteLine(name.ToLower());
        }

        static bool AnotherMethod()
        {
            if (true)
                return true;
            else
                return false;
        }
    }
}
