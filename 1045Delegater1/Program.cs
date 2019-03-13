using System;

namespace _1045Delegater1
{
    class Program
    {
        public static void Main(string[] args)
        {
            Action carAction = Accelerate;
            carAction();
            carAction = Decelerate;
            carAction();
        }
        public static void Accelerate()
        {
            Console.WriteLine("Vrooom");
        }
        public static void Decelerate()
        {
            Console.WriteLine("Whiplash");
        }
    }
}
