using System;
using System.Collections.Generic;

namespace mars14_0930CodeAlong
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> vs = new List<int>()
            {
                1, 2, 7, 12, 14, 16
            };

            foreach (var item in vs)
            {
                if (Utils.IsOdd(item))
                {
                Console.WriteLine(item);
                }
            }
        }
    }
    class Utils
    {
        public static bool IsOdd(int i)
        {
            return i % 2 == 1;
        }
    }
}
