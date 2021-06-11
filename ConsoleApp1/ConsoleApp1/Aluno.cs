using System;
using System.Globalization;

namespace ConsoleApp1 {
    class Aluno {
        public string Nome;
        public double N1, N2, N3;

        public double NotaFinal() {
            return N1 + N2 + N3;
        }

        public double NotaFaltante() { 
            return 60.0-NotaFinal();
        }
    }
}
