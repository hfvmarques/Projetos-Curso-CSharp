using System;
using System.Globalization;

namespace ConsoleApp5 {
    class Program {
        static void Main(string[] args) {

            Console.Write("Quantos quartos serão alugados? ");
            int N = int.Parse(Console.ReadLine());
            Console.WriteLine();

            Quartos[] q = new Quartos[10];

            for (int i = 0; i < N; i++) {
                Console.WriteLine("Aluguel #"+(i+1));
                Console.Write("Nome: ");
                string nome = Console.ReadLine();
                Console.Write("Email: ");
                string email = Console.ReadLine();
                Console.Write("Quarto: ");
                int numero = int.Parse(Console.ReadLine());
                q[numero] = new Quartos(nome, email);
                Console.WriteLine();
            }

            for (int i = 0; i < 10; i++) {
                if (q[i]!= null) {
                    Console.WriteLine(i+": "+q[i]);
                }
            }            
        }
    }
}
