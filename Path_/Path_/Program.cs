using System;
using System.IO;

namespace Path_
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"D:\Programação\ws-vs2019\Path_\myfolder\file1.txt";

            Console.WriteLine("DirectorySeparatorChar: "+Path.DirectorySeparatorChar);
            Console.WriteLine("PathSeparator: "+Path.PathSeparator);
            Console.WriteLine("GetDirectoryName: "+Path.GetDirectoryName(path));
            Console.WriteLine("GetFileName: "+Path.GetFileName(path));
            Console.WriteLine("GetFileNameWithoutExtension: "+Path.GetFileNameWithoutExtension(path));
            Console.WriteLine("GetExtension: "+Path.GetExtension(path));
            Console.WriteLine("GetFullPath: "+Path.GetFullPath(path));
            Console.WriteLine("GetTempPath: "+Path.GetTempPath());

        }
    }
}
