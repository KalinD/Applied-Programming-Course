using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MinNumber {
    class Program {
        static void Main(string[] args) {
            int n = int.Parse(Console.ReadLine());
            double min_n = double.Parse(Console.ReadLine());
            for (int i = 1; i < n; i++) {
                double num = double.Parse(Console.ReadLine());
                if (min_n > num) {
                    min_n = num;
                }
            }
            Console.WriteLine(min_n);
        }
    }
}
