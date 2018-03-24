using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FibonacciNumber {
    class Program {
        static void Main(string[] args) {
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine(fib(n));
        }
        static int fib(int n) {
            if (n <= 1) {
                return 1;
            }
            return fib(n - 1) + fib(n - 2);
        }
    }
}
