using System;
using DelegatesIntro.Services;

namespace DelegatesIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            double a = 10.0;
            double b = 12.0;

            double result = CalculationService.Sum(a, b);
            Console.WriteLine(result);
        }
    }
}
