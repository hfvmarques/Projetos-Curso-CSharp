using System;
using System.Globalization;

namespace ConsoleApp2 {
    class Program {
        static void Main(string[] args) {
            
            Pessoa p1 = new Pessoa();
            Pessoa p2 = new Pessoa();
            
            Console.WriteLine("Digite o nome da primeira pessoa e depois seu salário:");
            
            p1.Nome = Console.ReadLine();
            p1.Salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Digite o nome da segunda pessoa e depois seu salário:");

            p2.Nome = Console.ReadLine();
            p2.Salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Salário médio = "+((p1.Salario+p2.Salario)/2));
        }
    }
}
