using System;
using System.Globalization;

namespace ConsoleApp1 {
    class ConversorDeMoeda {

        public static double Iof = 6.0;

        public static double DolarParaReal(double valor, double cotacao) {
            double total = valor * cotacao;
            return total + total * Iof / 100.0;
        }        
    }
}
