using System;
using System.IO;
using System.Linq;

namespace _1515DelegatesDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            const string DirPath = @"C:\Projects\OOdemo";

            FileFinder.FindFiles(DirPath);

        }
    }
    class FileFinder
    {
        public static void FindFiles(string dirPath)
        {
            var filePaths = Directory.GetFiles(dirPath);

            foreach (var path in filePaths)
            {
                if (Path.GetExtension(path) == ".txt")
                    Console.WriteLine(path);
            }
            //var books = books.Where(b => b.PageCount > 300).OrderBy(b => b.Title).ToList();
        }
    }
}
