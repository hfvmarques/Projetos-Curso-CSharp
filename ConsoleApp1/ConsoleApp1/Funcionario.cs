using System;
using System.Globalization;

namespace ConsoleApp1 {
    class Funcionario {
        public string Nome;
        public double SalarioBruto;
        public double Imposto;

        public double SalarioLiquido() {
            return SalarioBruto - Imposto;
        }

        public override string ToString() {
            return Nome + ", $ " + SalarioLiquido().ToString("F2", CultureInfo.InvariantCulture);
        }

        public void AumentarSalario(double porcentagem) {
            SalarioBruto = SalarioBruto*(1+porcentagem / 100);
        }
    }
}
