using System;
using System.IO;

namespace FileFileInfoIOException
{
    class Program
    {
        static void Main(string[] args)
        {
            string sourcePath = @"D:\Programação\ws-vs2019\FileFileInfoIOException\file1.txt";
            string targetPath = @"D:\Programação\ws-vs2019\FileFileInfoIOException\file2.txt";

            try
            {
                FileInfo fileinfo = new FileInfo(sourcePath);
                fileinfo.CopyTo(targetPath);
                string[] lines = File.ReadAllLines(sourcePath);
                foreach (string line in lines)
                {
                    Console.WriteLine(line);
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
