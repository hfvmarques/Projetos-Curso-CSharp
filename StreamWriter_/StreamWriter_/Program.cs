using System;
using System.IO;

namespace StreamWriter_
{
    class Program
    {
        static void Main(string[] args)
        {
            string sourcePath = @"D:\Programação\ws-vs2019\StreamWriter_\file1.txt";
            string targetPath = @"D:\Programação\ws-vs2019\StreamWriter_\file2.txt";


            try
            {
                string[] lines = File.ReadAllLines(sourcePath);

                using (StreamWriter sw = File.AppendText(targetPath))
                {
                    foreach (string line in lines)
                    {
                        sw.WriteLine(line.ToUpper());
                    }
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
