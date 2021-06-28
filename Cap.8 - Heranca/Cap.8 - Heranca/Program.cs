using System;
using Cap._8___Heranca.Entities;

namespace Cap._8___Heranca
{
    class Program
    {
        static void Main(string[] args)
        {
            BusinessAccount account = new(8010, "Bob Brown", 100.0, 500.0);

            Console.WriteLine(account.Balance);

            //account.Balance = 200.0
        }
    }
}
