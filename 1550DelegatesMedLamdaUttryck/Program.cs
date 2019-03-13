using System;
using System.IO;
using System.Linq;

namespace _1550DelegatesMedLamdaUttryck
{
    class Program
    {
        static void Main(string[] args)
        {
            //const string DirPath = @"C:\Projects\OOdemo";

            //named method (C# 1.0)
            //FileFinder.FindFiles(DirPath, myTextFilter);
            //Console.WriteLine();

            //Lambda (C# 3.0)
            FileFinder.FindFiles(@"C:\Projects\OOdemo", p =>Path.GetExtension(p) == ".txt");
        }

        //static bool myTextFilter(string path)
        //{
        //    return Path.GetExtension(path) == ".txt";
        //}
    }
    class FileFinder
    {
        public static void FindFiles(string dirPath, Func<string, bool> filter)
        {
            //var filePaths = Directory.GetFiles(dirPath);

            foreach (var path in Directory.GetFiles(@"C:\Projects\OOdemo"))
            {
                if (filter(path))
                    Console.WriteLine(path);
            }
            //var books = books.Where(b => b.PageCount > 300).OrderBy(b => b.Title).ToList();
        }
    }
}
