using System;
using System.IO;
using System.Linq;

namespace _1540DelegatesForts
{
    class Program
    {
        static void Main(string[] args)
        {
            const string DirPath = @"C:\Projects\OOdemo";

            //named method (C# 1,0)
            FileFinder.FindFiles(DirPath, myTextFilter);
        }

        static bool myTextFilter(string path)
        {
            return Path.GetExtension(path) == ".txt";
        }
    }
    class FileFinder
    {
        public static void FindFiles(string dirPath, Func<string, bool> filter)
        {
            var filePaths = Directory.GetFiles(dirPath);

            foreach (var path in filePaths)
            {
                if (filter(path))
                    Console.WriteLine(path);
            }
            //var books = books.Where(b => b.PageCount > 300).OrderBy(b => b.Title).ToList();
        }
    }
}
