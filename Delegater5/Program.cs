using System;

namespace Delegater5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
        public static void SortIntArray(int[] intArr)
        {
            for (int i = 0; i < intArr.Length - 1; i++)
            {
                int minIndex = i;
                for (int j = i + 1; j < intArr.Length; j++)
                    if (intArr[j] < intArr[minIndex])
                        minIndex = j;
                int tmp = intArr[i];
                intArr[i] = intArr[minIndex];
                intArr[minIndex] = tmp;
            }
        }
    }
}
