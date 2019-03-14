using System;
using System.Collections.Generic;
using System.Linq;

namespace mars14_0935SammaFastMedExtensionMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> vs = new List<int>()
            {
                1, 2, 7, 12, 14, 16
            };

            var q = vs.OrderBy(x => x.)

            Console.WriteLine("Odd numbers:");
            foreach (var oneInt in vs)
            {
                if (oneInt.IsOdd())
                {
                    Console.WriteLine(oneInt);
                }
            }
                Console.WriteLine();

            foreach (var oneInt in vs)
            {
                if (oneInt.IsBetween(2, 10))
                    Console.WriteLine($"{oneInt} is between one and ten");
                else
                    Console.WriteLine($"{oneInt} is not between one and ten");
            }
        }
    }
    static class Utils
    {
        public static bool IsOdd(this int i)
        {
            return i % 2 == 1;
        }

        /// <summary>
        /// Lets you know if number is between 1 and 10
        /// </summary>
        /// <param name="i">Comment for i</param>
        /// <param name="tal1">Comment for min</param>
        /// <param name="tal2">Comment for maximum</param>
        /// <returns></returns>
        public static bool IsBetween(this int i, int tal1, int tal2)
        {
            if (i >= tal1 && i <= tal2)
                    return true;
            else
                return false;
        }
    }
}