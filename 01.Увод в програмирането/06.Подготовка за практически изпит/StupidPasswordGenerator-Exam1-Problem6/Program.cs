using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StupidPasswordGenerator_Exam1_Problem6 {
    class Program {
        static void Main(string[] args) {
            int n = int.Parse(Console.ReadLine());
            int l = int.Parse(Console.ReadLine());
            for (int first = 1; first <= n; first++) {
                for (int second = 1; second <= n; second++) {
                    for (int third = 'a'; third <= 'a' + l - 1; third++) {
                        for (int fourth = 'a'; fourth <= 'a' + l - 1; fourth++) {
                            for (int fifth = Math.Max(first, second) + 1; fifth <= n; fifth++) {
                                Console.Write($"{first}{second}{(char)third}{(char)fourth}{fifth} ");
                            }
                        }
                    }
                }
            }
            Console.WriteLine();
        }
    }
}
