using System;
using System.Collections.Generic;
using System.Globalization;
using Exercicio2MetodosAbstratos.Entities;

namespace Exercicio2MetodosAbstratos
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the number of tax payers: ");
            int n = int.Parse(Console.ReadLine());

            List<TaxPayer> list = new List<TaxPayer>();

            for (int i = 1; i<=n; i++)
            {
                Console.WriteLine($"Tax payer #{i} data:");
                Console.Write("Individual or company(i / c) ? ");
                char type = char.Parse(Console.ReadLine());
                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Anual Income: ");
                double anualIncome = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                if (type == 'i')
                {
                    Console.Write("Health expenditures: ");
                    double healthExpenditures = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                    list.Add(new Individual(name, anualIncome, healthExpenditures));
                }
                else
                {
                    Console.Write("Number of employees: ");
                    int numberOfEmplooyes = int.Parse(Console.ReadLine());

                    list.Add(new Company(name, anualIncome, numberOfEmplooyes));
                }
            }
            Console.WriteLine();

            Console.WriteLine("TAXES PAID:");
            double total = 0.0;
            foreach (TaxPayer taxPayer in list)
            {
                Console.WriteLine(taxPayer.Name+": $ "+taxPayer.Tax().ToString("F2", CultureInfo.InvariantCulture));
                total += taxPayer.Tax();
            }
            Console.WriteLine();

            Console.WriteLine("TOTAL TAXES: $ "+total.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}
