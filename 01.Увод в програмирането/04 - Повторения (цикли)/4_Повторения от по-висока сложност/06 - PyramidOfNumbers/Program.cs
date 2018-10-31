using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PyramidOfNumbers {
    class Program {
        static void Main(string[] args) {
            int n = int.Parse(Console.ReadLine());
            int k = 1;
            for (int i = 1; i <= n; i++) {
                for (int j = 1; j <= i; j++) {
                    if (k <= n) {
                        Console.Write($"{k} ");
                        k++;
                        if (j == i) {
                            Console.WriteLine();
                        }
                    }
                }
            }
        }
    }
}
