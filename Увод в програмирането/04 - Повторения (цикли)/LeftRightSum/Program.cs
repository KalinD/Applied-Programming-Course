using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeftRightSum {
    class Program {
        static void Main(string[] args) {
            int n = int.Parse(Console.ReadLine());
            int sum1 = 0;
            int sum2 = 0;
            for (int i = 0; i < n * 2; i++) {
                int number = int.Parse(Console.ReadLine());
                if (i < n) {
                    sum1 += number;
                }
                else {
                    sum2 += number;
                }
            }
            if (sum1 == sum2) {
                Console.Write("Yes, ");
                Console.WriteLine("sum = {0}", sum1);
            }
            else {
                Console.Write("No, ");
                Console.WriteLine("diff = {0}", Math.Abs(sum1 - sum2));
            }
        }
    }
}
