﻿using System;

namespace _1330MetoderTIllVariabler
{
    class Program
    {
        public static void Main(string[] args)
        {
            I_Take_A_Delegate(HelloWorldMethod);
        }
        static void I_Take_A_Delegate(Action HelloWorldMethod)
        {
            Console.WriteLine("Time to call the method in parameter 'a'");
            HelloWorldMethod();
        }
        static void HelloWorldMethod()
        {
            Console.WriteLine("Hello Academy!");
        }
    }
}
