using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumOfTheOthers {
    class Program {
        static void Main(string[] args) {
            int n = int.Parse(Console.ReadLine());
            int M = int.MinValue;
            double sum = 0.0;
            for (int i = 0; i < n; i++) {
                int num = int.Parse(Console.ReadLine());
                sum += num;
                if (num > M) {
                    M = num;
                }
            }
            if (sum / 2 == M) {
                Console.WriteLine("Yes");
                Console.WriteLine("Sum = " + M);
            }
            else {
                Console.WriteLine("No");
                Console.WriteLine("Diff = " + Math.Abs(M - (sum - M)));
            }
        }
    }
}
