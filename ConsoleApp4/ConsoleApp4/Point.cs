using System;
using System.Globalization;

namespace ConsoleApp4 {
    struct Point {
        public double X, Y;

        public override string ToString() {
            return "(" + X + ", " + Y + ")";
        }
    }
}
