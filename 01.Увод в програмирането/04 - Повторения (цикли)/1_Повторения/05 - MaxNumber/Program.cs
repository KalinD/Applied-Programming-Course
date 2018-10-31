using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaxNumber {
    class Program {
        static void Main(string[] args) {
            int n = int.Parse(Console.ReadLine());
            double max_n = double.Parse(Console.ReadLine());
            for (int i = 1; i < n; i++) {
                double num = double.Parse(Console.ReadLine());
                if (max_n < num) {
                    max_n = num;
                }
            }
            Console.WriteLine(max_n);
        }
    }
}
