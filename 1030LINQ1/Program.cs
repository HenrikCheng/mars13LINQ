using System;

namespace _1030LINQ1
{
    class Program
    {
        static void MyMethod()
        {
            Console.WriteLine("Hello World!");
        }

        public static void Main(string[] args)
        {
            // Tilldela variabeln a av typen Action metoden MyMethod.         
            Action a = MyMethod;
            // Anropa metoden som variabeln a tilldelats.         
            a();
        }
    }
}