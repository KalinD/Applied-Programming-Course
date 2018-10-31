using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PowerOfNumber {
    class Program {
        static void Main(string[] args) {
            double a = double.Parse(Console.ReadLine());
            double n = double.Parse(Console.ReadLine());
            Console.WriteLine(Power(a, n));
        }
        static double Power(double a, double n) {
            double result = 1;
            for (int i = 0; i < n; i++) {
                result *= a;
            }
            return result;
        }
    }
}
