using System;
using System.IO;
using System.Collections.Generic;

namespace DirectoryDirectoryInfo
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"D:\Programação\ws-vs2019\DirectoryDirectoryInfo\myfolder";

            try
            {
                IEnumerable<string> folders = Directory.EnumerateDirectories(path, "*.*", SearchOption.AllDirectories);
                Console.WriteLine("Folders:");
                foreach (string s in folders)
                {
                    Console.WriteLine(s);
                }
            }
            catch (IOException e)
            {
                Console.WriteLine("An error occurred");
                Console.WriteLine(e.Message);
            }
        }
    }
}
