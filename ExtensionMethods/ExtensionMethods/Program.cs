using System;

namespace ExtensionMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime dt = new DateTime(2021, 07, 12, 8, 10, 45);
            Console.WriteLine(dt.ElapsedTime());
        }
    }
}
